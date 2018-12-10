using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entites
{
    public partial class User
    {
        public string FullName 
        { 
            get { return String.Format("{0} {1}", FirstName, LastName); } 
        }
    }
}