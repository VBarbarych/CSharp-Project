using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Task1_4_2
    {
        public const double PI = 3.1415926535897931;
        public static double Radius { get; set; }




        public static double Square(double radius)
        {
            return PI * radius * radius;
        }

        public static double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }




        

    }
}
