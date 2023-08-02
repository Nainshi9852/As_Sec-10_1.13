using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson[] people = new IPerson[]
            {
            new Student { FirstName = "John", LastName = "Doe", Age = 20 },
            new Teacher { FirstName = "Alice", LastName = "Smith", Age = 35 },
            new OfficeStaff { FirstName = "Mike", LastName = "Johnson", Age = 28 }
            };

            foreach (IPerson person in people)
            {
                person.DisplayDetails();
            }
            Console.ReadKey();
        }
    }
}
