using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;

namespace AutoRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRunable> tasks = new List<IRunable>();
            tasks.Add(new Task1_1());
            tasks.Add(new Task1_2());
            tasks.Add(new Task1_3());
            tasks.Add(new Task1_5());
            tasks.Add(new Task2_1());
            tasks.Add(new Task2_2());
            tasks.Add(new Task2_3());
            tasks.Add(new Task2_4());

            foreach (var task in tasks)
            {
                task.Run();
            }


            Console.ReadKey();
        }
    }
}
