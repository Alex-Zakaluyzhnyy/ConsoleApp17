using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            var binary = new BinaryHeap();
            binary.Add(12);
            binary.Add(16);
            binary.Add(8);
            binary.Add(7);
            binary.Add(5);
            var i = binary.GetMax();
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
