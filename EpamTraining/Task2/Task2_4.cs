using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IDrawable
    {
        void Draw();
    }

    public class Figure4 : IDrawable
    {
        public double X { get; }
        public double Y { get; }


        public Figure4(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine(GetType().Name);
        }
    }

    public class Square4 : Figure4, IDrawable
    {
        public Square4(double x, double y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }


    }

    public class Rectangle4 : Figure4, IDrawable
    {
        public Rectangle4(double x, double y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }




    }


    public class Task2_4 : IRunable
    {
        public Task2_4()
        {

        }



        public void DrawAll(params IDrawable[] array)
        {
            foreach (var element in array)
            {
                element.Draw();
            }

        }

        public void Run()
        {

            Console.WriteLine("==========Task 2.4==========");
            Console.WriteLine();

            DrawAll(new Figure4(3, 5), new Square4(4, 2), new Rectangle4(5, 6));

           
        }
    }
}
