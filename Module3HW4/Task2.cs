using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3HW4
{
    public class Task2
    {
        public Task2()
        {
            Contacts = new List<Contact>();
        }

        public List<Contact> Contacts { get; set; }
        public void Test()
        {
            Contacts.Add(new Contact { FirstName = "Igor", LastName = "Ivanov", Number = "0973251231" });
            Contacts.Add(new Contact { FirstName = "Petr", LastName = "Petrov", Number = "0662341222" });
            Contacts.Add(new Contact { FirstName = "Olga", LastName = "Shevchenko", Number = "0958793522" });
            Contacts.Add(new Contact { FirstName = "Igor", LastName = "Prokopenko", Number = "0509603853" });
            Contacts.Add(new Contact { FirstName = "Igor", LastName = "Prokopenko", Number = "0509603853" });

            var result1 = Contacts.Where(w => w.FirstName == "Igor").OrderBy(o => o.Number).ToList();
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Number} - {item.FullName}");
            }

            Console.WriteLine();
            var result2 = Contacts.OrderBy(o => o.Number).Select(s => s.Number);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var result3 = Contacts.FirstOrDefault(f => f.FullName.Contains("ko"));
            Console.WriteLine(result3.FullName);
            Console.WriteLine();
            Console.WriteLine(Contacts.All(a => a.Number.Length == 10));
            Console.WriteLine();
            foreach (var item in Contacts.Distinct(new ContactEqualityComparer()).ToList())
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine();
        }
    }
}
