using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skudår
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast årstal: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int leapyear = Leap(year);

            if (year <= 1000)
                Console.WriteLine("-1");
            else if (leapyear == 1)
                Console.WriteLine("leapyear, " + leapyear);
            else
                Console.WriteLine("not a leapyear, " + leapyear);


            Console.ReadKey();
        }

        static int Leap(int num)
        {
            int result = num % 4;

            if (result == 0)
                return 1;
            else
                return -1;
        }
    }
}
