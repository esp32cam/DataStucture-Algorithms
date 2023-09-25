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
            ArrayCollection x = new ArrayCollection(10);
            x.add(1);x.add(3);x.add(4);x.add(5);
            Console.WriteLine(x.Size());
        }
    }
}
