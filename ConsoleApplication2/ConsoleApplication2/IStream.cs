using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public interface IStream : IReadStream, IWriteStream
    {
        int Size { get; } 
    }

    public interface IReadStream
    {
        void Read();
    }

    public interface IWriteStream
    {
        void Write();
    }

 
}
