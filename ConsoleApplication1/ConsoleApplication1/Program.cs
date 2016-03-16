using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = null;
            try
            {
                reader = File.OpenText(@"d:\stdafx1.h");
                string s = null;
                while ((s = reader.ReadLine()) != null)
                {
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                throw new Exception("Error", e);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                }
            }

            

        }
    }
}
