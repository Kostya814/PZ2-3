using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product();
            prod.Read();
            prod.Display();
            prod.power();
            Console.ReadKey();
        }
    }
}
