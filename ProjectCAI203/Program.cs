using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection;

namespace ProjectCAI203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Set x = new ArraySet(1);
            x.add(1);x.add(1);x.add(2);
            Console.WriteLine(x.Size());
        }
    }
}
