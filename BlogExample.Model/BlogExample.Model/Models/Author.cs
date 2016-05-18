using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample.Model
{
    using System;
    using System.Collections.Generic;

    public partial class Author
    {
        public string FullName 
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
    }
}

