using MyClassLibrary.CLasses;
using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Task3_2 : IRunable
    {
        private void AddTwoPerson()
        {
            Person person = new Person();

            List<Person> addrangeperson = new List<Person>();
            addrangeperson.Add(new Person() { Name = "Tom", Age = 24, PhoneNumbers = new List<string> { "0939955047", "0930218846", "0986604946" } });
            addrangeperson.Add(new Person() { Name = "Micky", Age = 34, PhoneNumbers = new List<string> { "0975437683", "0559474104", "0662907728" } });

            Person.persons.AddRange(addrangeperson);

            foreach (Person per in Person.persons)
            {
                Console.Write($"\nIм'я: {per.Name}, номери телефонiв: ");
                foreach (var i in per.PhoneNumbers)
                    Console.Write($"{i}; ");
            }
        }

        public void Run()
        {
            Console.WriteLine("\n==========Task 3.2==========");
            AddTwoPerson();
        }
    }
}
