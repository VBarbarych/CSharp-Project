using MyClassLibrary.CLasses;
using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Task1_3 : IRunable
    {
        public const double PI = 3.1415926535897931;
        public double Radius { get; set; }

        public Task1_3()
        {

        }

        public Task1_3(double radius)
        {
            this.Radius = radius;
        }

        public double Square(double radius)
        {
            return PI * radius * radius;
        }

        public double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }

       


        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("==========Task 1.3==========");
            Console.WriteLine();
            Console.WriteLine("Введiть радiус: ");
            var r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Довжина кола = {Perimeter(r)}");
            Console.WriteLine($"Площа = {Square(r)}");

            Console.WriteLine();
        }

    }
}
