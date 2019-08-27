using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_3_2
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>
        {
            new Person { Name = "Ira", Age = 19, PhoneNumbers = new[] { "38-068-000-0001", "38-093-000-0010", "38-095-001-0000" } },
            new Person { Name = "Vasyl", Age = 55, PhoneNumbers = new[] { "38-068-000-0002", "38-093-000-0020", "38-095-002-0000" } },
            new Person { Name = "Andrew", Age = 21, PhoneNumbers = new[] { "38-068-000-0003", "38-093-000-0030", "38-095-003-0000" } },
            new Person { Name = "Oleg", Age = 33, PhoneNumbers = new[] { "38-068-000-0004", "38-093-000-0040", "38-095-004-0000" } },
            new Person { Name = "Maria", Age = 24, PhoneNumbers = new[] { "38-068-000-0005", "38-093-000-0050", "38-095-005-0000" } },
            new Person { Name = "Olena", Age = 27, PhoneNumbers = new[] { "38-068-000-0006", "38-093-000-0060", "38-095-006-0000" } },
            new Person { Name = "Viktoria", Age = 18, PhoneNumbers = new[] { "38-068-000-0007", "38-093-000-0070", "38-095-007-0000" } }
        };


            foreach (var i in allPersons)
            {
                Console.WriteLine("My name is " + i.Name + ", I am " + i.Age + " years old !");
            }

            allPersons.AddRange(new List<Person>()
        {
             new Person { Name = "Anastasia", Age = 23, PhoneNumbers = new List<string>() { "38-068-000-0008", "38-093-000-0080", "38-095-008-0000" } },
             new Person { Name = "Mykola", Age = 31, PhoneNumbers = new List<string>() { "38-068-000-0009", "38-093-000-0090", "38-095-009-0000" } }
        });
            foreach (var person in allPersons)
            {
                Console.WriteLine("My name is" + person.Name + ", I am " + person.Age + "years old. My phone numbers:");
                foreach (var n in person.PhoneNumbers)
                {
                    Console.Write($"{n}\n");
                }
            }
            Console.ReadLine();
        }



    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
