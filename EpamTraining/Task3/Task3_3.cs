using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Task3_3 : IRunable
    {
        List<string> randomString = new List<string>();
        const int n = 200;

        private void GenerateList()
        {
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                StringBuilder word = new StringBuilder();
                for (int j = 0; j < 4; j++)
                {
                    char letter = Convert.ToChar(Convert.ToInt32(rand.Next(65, 91)));
                    word.Append(letter);
                }
                randomString.Add(word.ToString());
            }
        }

        private void RemoveEqual()
        {
            for (int i = 0; i < randomString.Count; i++)
            {
                for (int j = i + 1; j < randomString.Count; j++)
                {
                    if(randomString[i] == randomString[j])
                    {
                        randomString.RemoveAt(j);
                    }
                }
            }
            randomString.Sort();
            randomString.Reverse();
        }

        private void RemoveWords()
        {
            for (int i = 0; i < randomString.Count; i++)
            {
                if (randomString[i].StartsWith("Z"))
                {
                    randomString.RemoveAt(i);
                    i--;
                }
            }
        }

        private int CheckPageNumber()
        {
            int pageNumber = 0;
            Console.WriteLine("\nВведiть номер сторiнки: ");
            try
            {
                pageNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Environment.Exit(0);
            }
            
            return pageNumber;
        }

        private void DisplayPage(int pageNumber)
        {

            if (pageNumber * 5 < randomString.Count && pageNumber > 0)
            {
                Console.WriteLine($"\nЕлементи {pageNumber}-ої сторiнки:");
                for (int i = (pageNumber - 1) * 5; i < (pageNumber * 5); i++)
                {
                    Console.WriteLine(randomString[i]);
                }
            }
        }


        private void Print()
        {
            char ch = ' ';
            
            do
            {
                Console.WriteLine("\n1 - Вивести згенерований список без змiн, " +
                                  "2 - Вивести згенерований список пiсля проведення трансформацiй, " +
                                  "3 - Показати елементи з певної сторiнки, " +
                                  "4 - Вихiд\n");
                ch = Convert.ToChar(Console.ReadLine());
                
                switch(ch)
                {
                    case '1':
                        {
                            GenerateList();
                            Console.WriteLine($"Згенерований список без змiн");
                            foreach (var i in randomString)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine($"Кiлькiсть елементiв списку: {randomString.Count}");
                            break;
                        }
                    case '2':
                        {
                            RemoveEqual();
                            RemoveWords();

                            Console.WriteLine($"\nЗгенерований список пiсля проведення трансформацiй");
                            foreach (var i in randomString)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine($"Кiлькiсть елементiв списку: {randomString.Count}");
                            break;
                        }
                    case '3':
                        {
                            DisplayPage(CheckPageNumber());
                            break;
                        }
                    case '4':
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        break;

                }
            } while (ch != '4');
        }

        public void Run()
        {
            Console.WriteLine("\n\n==========Task 3.3==========");
            Print();
        }
    }
}
