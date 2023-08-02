using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Teacher : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Teacher: {FirstName} {LastName}, Age: {Age}");
        }
    }
}
