using MyClassLibrary.CLasses;
using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Figure 
    {
        public abstract void Draw();
    }

    public class Square : Figure
    {
        public Square()
        {

        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }

        
    }

    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }

        


    }


    public class Task2_1 : IRunable
    {
        public Task2_1()
        {

        }

        public void Run()
        {
            Console.WriteLine("==========Task 2.1==========");
            Console.WriteLine();
            Square square = new Square();
            square.Draw();
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            Console.WriteLine();
        }
    }

    
}
