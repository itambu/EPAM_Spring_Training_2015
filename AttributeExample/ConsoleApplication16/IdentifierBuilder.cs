using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public class IdentifierBuilder
    {
        public static object GetIdentifier(object obj)
        {
            object idAttribute = obj.GetType()
                .GetCustomAttributes(typeof(IdentifierAttribute), true)
                .FirstOrDefault();
            if (idAttribute != null)
            {
                IdentifierAttribute temp = idAttribute as IdentifierAttribute;
                PropertyInfo idPropertyInfo = obj.GetType().GetProperty(temp.PropertyName);

                return idPropertyInfo.GetValue(obj);
            }
            else
            {
                return null;
            }
        }
    }
}
