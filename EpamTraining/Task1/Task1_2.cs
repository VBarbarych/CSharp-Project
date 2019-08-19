using MyClassLibrary.CLasses;
using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Task1_2 : IRunable
    {
        private Point UpperLeft { get; set; }
        private Point LowerRight { get; set; }

        public Task1_2()
        {
            
        }

        public Task1_2(Point upperLeft, Point lowerRight)
        {
            this.UpperLeft = upperLeft;
            this.LowerRight = lowerRight;
        }


        private double Length()
        {
            return UpperLeft.Y - LowerRight.Y;
        }

        private double Width()
        {
            return LowerRight.X - UpperLeft.X;
        }


        private double Perimeter
        {
            get
            {
                return Width() * 2 + Length() * 2;
            }
            
        }


        private double Square
        {
            get
            {
                return Width() * Length();
            }
        }


        private void Input()
        {
            int k = 0;

            do
            {
                var x1 = 0;
                var y1 = 0;
                var x2 = 0;
                var y2 = 0;
                try
                {
                    Console.WriteLine("==========Task 1.2==========");
                    Console.WriteLine();
                    Console.WriteLine("Введiть координату Х верхньої правої точки");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть координату Y верхньої правої точки");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть координату Х нижньої лiвої точки");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть координату Y нижньої лiвої точки");
                    y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    k++;
                }

                UpperLeft = new Point(x1, y1);
                LowerRight = new Point(x2, y2);
            } while (k != 0);

        }

        private void Print()
        {
            Console.WriteLine($"Периметр = {Perimeter}");
            Console.WriteLine($"Площа = {Square}");

        }


        public void Run()
        {
            Input();
            Print();
        }
    }

}

