using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##---Welcome To Address Book---##");
            var person = new MainBook();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            var newentry = new Entry(firstName);
            person.AddContact(newentry);
            person.DisplayList();
            Console.ReadKey();
        }
    }
}
