using MyClassLibrary.CLasses;
using MyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Task3_1 : IRunable
    {
        private void AddPerson()
        {
            Person person = new Person();

            Person.persons = new List<Person>();
            Person.persons.Add(new Person() { Name = "Bob", Age = 45, PhoneNumbers = new List<string>() { "0933674534", "0733964788", "0636783274" } });
            Person.persons.Add(new Person() { Name = "Bill", Age = 23, PhoneNumbers = new List<string>() { "0634356814", "0668306065", "0800300999", "0961200407" } });
            Person.persons.Add(new Person() { Name = "John", Age = 33, PhoneNumbers = new List<string>() { "0800305020", "0445033335" } });
            Person.persons.Add(new Person() { Name = "Mike", Age = 56, PhoneNumbers = new List<string>() { "0961080644", "0990384447" } });
            Person.persons.Add(new Person() { Name = "Steve", Age = 44, PhoneNumbers = new List<string>() { "0977380449", "0676465360", "0679521566" } });
            Person.persons.Add(new Person() { Name = "Lisa", Age = 27, PhoneNumbers = new List<string>() { "0931252831", "0678528285", "0668306065" } });

            foreach (Person per in Person.persons)
            {
                Console.WriteLine($"Iм'я: {per.Name}, Вiк: {per.Age}");
            }
        }

        public void Run()
        {
            Console.WriteLine("\n==========Task 3.1==========\n");
            AddPerson();
        }
    }
}
