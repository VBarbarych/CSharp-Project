using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Figure2
    {
        public double X { get; }
        public double Y { get; }


        public Figure2(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Draw();
    }

    public class Square2 : Figure2
    {
        public Square2(double x, double y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }


    }

    public class Rectangle2 : Figure2
    {
        public Rectangle2(double x, double y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }




    }


    public class Task2_2 : IRunable
    {
        public Task2_2()
        {

        }

        public void Run()
        {
            Console.WriteLine("==========Task 2.2==========");
            Console.WriteLine();
            Square2 square = new Square2(3, 5);
            square.Draw();
            Rectangle2 rectangle = new Rectangle2(4, 6);
            rectangle.Draw();

            Console.WriteLine();
        }
    }

}
