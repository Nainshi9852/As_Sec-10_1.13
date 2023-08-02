using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Student : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, Age: {Age}");
        }
    }
}
