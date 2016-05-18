using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample.DAL.ContextFactory
{
    public class BlogContextFactory : IDataContextFactory<BlogExample.Model.ModelContainer>
    {
        public Model.ModelContainer ContextObject
        {
            get { return new Model.ModelContainer(); }
        }
    }
}
