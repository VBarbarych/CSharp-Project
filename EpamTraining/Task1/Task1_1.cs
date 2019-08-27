using MyClassLibrary.CLasses;
using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Task1_1 : IRunable
    {
        private Point _upperLeft;
        private Point _lowerRight;

        public Task1_1()
        {
            _upperLeft = new Point(0, 0);
            _lowerRight = new Point(0, 0);
        }

        public Task1_1(Point upperLeft, Point lowerRight)
        {
            this._upperLeft = upperLeft;
            this._lowerRight = lowerRight;
        }


        private double Length()
        {
            return _upperLeft.Y - _lowerRight.Y;
        }

        private double Width()
        {
            return _lowerRight.X - _upperLeft.X;
        }


        public double Perimeter()
        {
            return Width() * 2 + Length() * 2;
        }


        public double Square()
        {
            return Width() * Length();
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
                    Console.WriteLine("==========Task 1.1==========");
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

                _upperLeft = new Point(x1, y1);
                _lowerRight = new Point(x2, y2);
            } while (k != 0);
        }

        private void Print()
        {
            Console.WriteLine($"Периметр = {Perimeter()}");
            Console.WriteLine($"Площа = {Square()}");
        }


        public void Run()
        {
            Input();
            Print();
        }
    }

}
