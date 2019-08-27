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
        public abstract string Draw();
    }

    public class Square : Figure
    {
        public Square()
        {

        }

        public override string Draw()
        {
            return GetType().Name;
        }

        
    }

    public class Rectangle : Figure
    {
        public override string Draw()
        {
            return GetType().Name;
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
            Console.WriteLine(square.Draw());
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Draw());

            Console.WriteLine();
        }
    }

    
}
