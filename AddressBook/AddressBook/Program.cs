using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//var person = new MainBook();

////Console.WriteLine("Enter First Name");
////string firstName = Console.ReadLine();
////var newentry = new Entry(firstName);
////person.AddContact(newentry);

//person.DisplayList();
//Console.ReadKey();
//        }
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
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;


            }
        }
    }
}
