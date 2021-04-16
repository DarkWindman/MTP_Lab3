using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new Bus("maz-105", "074-21 KA", new Park(4705));
            var result = bus.ShallowCopy();
            Console.WriteLine(result.id);
            Console.ReadKey();
        }
    }
}
