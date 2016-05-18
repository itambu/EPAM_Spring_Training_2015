using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample.DAL
{
    interface IDataContextFactory<Context> where Context : System.Data.Entity.DbContext
    {
        Context ContextObject { get; }
    }
}
