using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automata
{
    public  abstract  class Port : IPort
    {
        private PortState _state = PortState.UnPlagged;
        public PortState State
        {
            get
            {
                return _state;
            }
            set
            {
                if (_state != value)
                {
                    OnStateChanging(this, value);
                    _state = value;
                    OnStateChanged(this, _state);
                }
            }
        }

        public event EventHandler<PortState> StateChanging;
        public event EventHandler<PortState> StateChanged;

        protected virtual void OnStateChanged(object sender, PortState state)
        {
            if (StateChanged != null)
            {
                StateChanged(sender, state);
            }
        }

        protected virtual void OnStateChanging(object sender, PortState newState)
        {
            if (StateChanging != null)
            {
                StateChanging(sender, newState);
            }
        }

        public abstract void RegisterEventHandlersForTerminal(ITerminal terminal);

        public void ClearEvents()
        {
            this.StateChanged = null;
            this.StateChanging = null;
        }
    }
}
