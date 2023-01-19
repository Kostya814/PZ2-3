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
            Angle ang = new Angle(180,1);
            Angle ang1 = new Angle(350, 1);
            
            ang.Casting();

            ang.Compare(ang1);

            Console.ReadKey();
            

        }
    }
}
