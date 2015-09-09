using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automata
{
    public abstract class Station : IStation
    {
        

        public Station(ICollection<ITerminal> terminalCollection, ICollection<IPort> portCollection)
        {
            this._terminalCollection = terminalCollection;
            this._portCollection = portCollection;
            this._connectionCollection = new List<CallInfo>();
            this._callCollection = new List<CallInfo>();
            this._portMapping = new Dictionary<PhoneNumber, IPort>();
        }
        
        private ICollection<CallInfo> _connectionCollection;
        private ICollection<CallInfo> _callCollection;
        private ICollection<ITerminal> _terminalCollection;
        private ICollection<IPort> _portCollection;
        private IDictionary<PhoneNumber, IPort> _portMapping;

        protected ITerminal GetTerminalByPhoneNumber(PhoneNumber number)
        {
            return _terminalCollection.FirstOrDefault(x => x.Number == number);
        }

        protected IPort GetPortByPhoneNumber(PhoneNumber number)
        {
            return _portMapping[number];
        }

        protected void RegisterOutgoingRequest(Requests.OutgoingCallRequest request)
        {
            if ((request.Source!=default(PhoneNumber) && request.Target!=default(PhoneNumber))&&
                (GetCallInfo(request.Source) == null && GetConnectionInfo(request.Source) == null))
            {
                var callInfo = new CallInfo()
                {
                    Source = request.Source,
                    Target = request.Target,
                    Started = DateTime.Now
                };

                ITerminal targetTerminal = GetTerminalByPhoneNumber(request.Target);
                IPort targetPort = GetPortByPhoneNumber(request.Target);

                if (targetPort.State == PortState.Free)
                {
                    _connectionCollection.Add(callInfo);
                    targetPort.State = PortState.Busy;
                    targetTerminal.IncomingRequestFrom(request.Source);
                }
                else
                {
                    OnCallInfoPrepared(this, callInfo);
                }
            }
        }

        public abstract void RegisterEventHandlersForTerminal(ITerminal terminal);
        public abstract void RegisterEventHandlersForPort(IPort port);

        public void Add(ITerminal terminal)
        {
            var freePort = _portCollection.Except(_portMapping.Values).FirstOrDefault();
            if (freePort != null)
            {
                _terminalCollection.Add(terminal);

                MapTerminalToPort(terminal, freePort);

                // register event handlers
                
                this.RegisterEventHandlersForTerminal(terminal);
                this.RegisterEventHandlersForPort(freePort); 
            }
        }

        protected void MapTerminalToPort(ITerminal terminal, IPort port)
        {
            _portMapping.Add(terminal.Number, port);
            port.RegisterEventHandlersForTerminal(terminal);
            terminal.RegisterEventHandlersForPort(port);
        }

        protected void UnMapTerminalFromPort(ITerminal terminal, IPort port)
        {
            _portMapping.Remove(terminal.Number);
            terminal.ClearEvents();
            port.ClearEvents();
        }

        /// <summary>
        /// raise when the station generates a new CallInfo for billing 
        /// </summary>
        public event EventHandler<CallInfo> CallInfoPrepared;

        protected virtual void OnCallInfoPrepared(object sender, CallInfo callInfo)
        {
            if (CallInfoPrepared != null)
            {
                CallInfoPrepared(sender, callInfo);
            }
        }
        
        protected CallInfo GetConnectionInfo(PhoneNumber actor)
        {
            return this._connectionCollection.FirstOrDefault(x => (x.Source == actor || x.Target == actor));
        }

        protected CallInfo GetCallInfo(PhoneNumber actor)
        {
            return this._callCollection.FirstOrDefault(x => (x.Source == actor || x.Target == actor));
        }

        protected void SetPortStateWhenConnectionInterrupted(PhoneNumber source, PhoneNumber target)
        {
            var sourcePort = GetPortByPhoneNumber(source);
            if (sourcePort != null)
            {
                sourcePort.State = PortState.Free;
            }

            var targetPort = GetPortByPhoneNumber(target);
            if (targetPort != null)
            {
                targetPort.State = PortState.Free;
            }
        }
        
        protected void InterruptConnection(CallInfo callInfo)
        {
            this._callCollection.Remove(callInfo);
            SetPortStateWhenConnectionInterrupted(callInfo.Source, callInfo.Target);
            OnCallInfoPrepared(this, callInfo);
        }

        protected void InterruptActiveCall(CallInfo callInfo)
        {
            callInfo.Duration = DateTime.Now - callInfo.Started;
            this._callCollection.Remove(callInfo);
            SetPortStateWhenConnectionInterrupted(callInfo.Source, callInfo.Target);
            OnCallInfoPrepared(this, callInfo);
        }

        public void OnIncomingCallRespond(object sender, Responds.Respond respond)
        {
            var registeredCallInfo = GetConnectionInfo(respond.Source);
            if (registeredCallInfo != null)
            {
                switch (respond.State)
                {
                    case Responds.RespondState.Drop:
                        {
                            InterruptConnection(registeredCallInfo);
                            break;
                        }
                    case Responds.RespondState.Accept:
                        {
                            MakeCallActive(registeredCallInfo);
                            break;
                        }
                }
            }
            else
            {
                CallInfo currentCallInfo = GetCallInfo(respond.Source);
                if (currentCallInfo != null)
                {
                    this.InterruptActiveCall(currentCallInfo);
                }
            }
        }

        protected void MakeCallActive(CallInfo callInfo)
        {
            this._connectionCollection.Remove(callInfo);
            callInfo.Started = DateTime.Now;
            this._callCollection.Add(callInfo);
        }

        public void ClearEvents()
        {
            this.CallInfoPrepared = null;
        }
    }
}
