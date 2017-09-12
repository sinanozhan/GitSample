using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.ID = 5;
            person.Name = "Andy";

            Console.WriteLine("Hello world from the person that name is {0} and ID is {1}", person.Name, person.ID);

        }
    }
}
