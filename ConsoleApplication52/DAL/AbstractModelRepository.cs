using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    internal class AbstractModelRepository<T> 
    {
        protected BloggingContainer context = new BloggingContainer(); 
    }
}
