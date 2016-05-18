using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ConsoleApplication14.DataSet1TableAdapters;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            //var c = ConfigurationManager.AppSettings["PathToSourceFile"];
            UserSetTableAdapter ad = new UserSetTableAdapter();
            DataSet1 ds = new DataSet1();
            ad.Fill(ds.UserSet);
            
            ds.UserSet.RemoveUserSetRow(ds.UserSet[0]);
            ad.Update(ds);
        }
    }
}
