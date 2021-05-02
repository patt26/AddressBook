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
            Console.WriteLine("Select Options\n 1:Add new Entry\n 2:Edit Entry\n 3:Delete Entry\n 4:Display Entry");
            string choice = Console.ReadLine();

            var person = new MainBook();
           
            switch (choice)
            {
                case "1":
                    Console.Write("Enter First Name- ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name- ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Phone Number- ");
                    string phoneNum = Console.ReadLine();
                    Console.Write("Enter Address- ");
                    string address = Console.ReadLine();
                    Console.Write("Enter City Name- ");
                    string city = Console.ReadLine();
                    Console.Write("Enter Your Pincode- ");
                    string pinCode = Console.ReadLine();
                    Console.Write("Enter State- ");
                    string state = Console.ReadLine();
                    Console.Write("Enter Email ID- ");
                    string emailId = Console.ReadLine();

                    var newEntry = new Entry(firstName, lastName, phoneNum, address, city, pinCode, state, emailId);
                    person.AddContact(newEntry);
                    break;
                case "2":
                    Console.WriteLine("Enter Name You Want to edit: ");
                    string Name = Console.ReadLine();
                    person.EditName(Name);
                    break;
                case "3":
                    Console.WriteLine("Enter Name You Want To Delete:- ");
                    string Name2 = Console.ReadLine();
                    person.DeleteEntries(Name2);
                    break;
                case "4":
                    person.DisplayList();
                    break;
                case "5":
                    return;
                    

                    Console.ReadLine();
            }
        }
    }
}
