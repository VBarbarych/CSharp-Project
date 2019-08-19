using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Task1_5 : IRunable
    {

        private double Real { get; set; }
        private double Imaginary { get; set; }

        #region Constructor
        public Task1_5()
        {
            Real = 0.0;
            Imaginary = 0.0;
        }

        public Task1_5(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        #endregion

        #region Overloaded Multiplication Operators
        public static Task1_5 operator *(Task1_5 c1, Task1_5 c2)
        {
            return new Task1_5(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
        }

        public static Task1_5 operator *(Task1_5 c1, double c2)
        {
            return new Task1_5(c1.Real * c2, c1.Imaginary * c2);
        }

        public static Task1_5 operator *(double c1, Task1_5 c2)
        {
            return new Task1_5(c1 * c2.Real, c1 * c2.Imaginary);
        }
        #endregion


        #region Overloaded Division Operators
        public static Task1_5 operator /(Task1_5 c1, Task1_5 c2)
        {
            double Denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            return new Task1_5((c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / Denominator,
                (c2.Real * c1.Imaginary - c2.Imaginary * c1.Real) / Denominator);
        }

        public static Task1_5 operator /(Task1_5 c1, double c2)
        {
            return new Task1_5(c1.Real / c2, c1.Imaginary / c2);
        }

        public static Task1_5 operator /(double c1, Task1_5 c2)
        {
            double Denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            return new Task1_5((c1 * c2.Real) / Denominator, (-c2.Imaginary * c1) / Denominator);
        }
        #endregion


        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("==========Task 1.5==========");
            Console.WriteLine();
            Task1_5 c1 = new Task1_5();
            Task1_5 c2 = new Task1_5();
            Console.Write("Введiть цiлу частину першого комплексного числа: ");
            c1.Real = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть уявну частину першого комплексного числа: ");
            c1.Imaginary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть цiлу другого першого комплексного числа: ");
            c2.Real = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть уявну частину першого комплексного числа: ");
            c2.Imaginary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Множення комплексних чисел:      {0} + {1}i", (c1 * c2).Real, (c1 * c2).Imaginary);
            Console.WriteLine("Дiлення комплексних чисел:      {0} + {1}i", (c1 / c2).Real, (c1 / c2).Imaginary);

            Console.WriteLine();
        }

    }
}
