using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{




    public class Figure3
    {
        public double X { get; }
        public double Y { get; }


        public Figure3(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine(GetType().Name);
        }
    }

    public class Square3 : Figure3
    {
        public Square3(double x, double y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }


    }

    public class Rectangle3 : Figure3
    {
        public Rectangle3(double x, double y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }




    }


    public class Task2_3 : IRunable
    {
        public Task2_3()
        {

        }

        public void Run()
        {
            Console.WriteLine("==========Task 2.3==========");
            Console.WriteLine();
            Figure3 figure = new Figure3(4, 7);
            figure.Draw();
            Square3 square = new Square3(3, 5);
            square.Draw();
            Rectangle3 rectangle = new Rectangle3(4, 6);
            rectangle.Draw();

            Console.WriteLine();
        }
    }
}
