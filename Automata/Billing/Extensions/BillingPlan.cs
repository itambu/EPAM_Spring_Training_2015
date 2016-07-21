using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Model
{
    public partial class BillingPlan : IBillingPlan
    {
        private ICostCalculator _calculator;
        public ICostCalculator Calculator
        {
            protected get
            {
                if (_calculator == null)
                {
                    if (this.boxedObj != null)
                    {
                        using (var stream = new MemoryStream(this.boxedObj))
                        {
                            var serializer = new BinaryFormatter();
                            _calculator = serializer.Deserialize(stream) as ICostCalculator;
                        }
                    }
                }
                return _calculator;
            }
            set
            {
                if (value != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        var serializer = new BinaryFormatter();
                        serializer.Serialize(stream, value);
                        var length = stream.Length;
                        boxedObj = stream.ToArray();
                    }
                }
            }
        }

        public Decimal CalculateCost(ICallInfo info, IEnumerable<ICallInfo> previousItems)
        {
            return Calculator.CalculateCost(info, previousItems);
        }

    }
}

