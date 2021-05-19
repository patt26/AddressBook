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
            Console.WriteLine("Select Options\n 1:Add new Entry\n 2:Edit Entry\n 3:Delete Entry\n 4:Display Entry\n 5:Exit");
            string choice = Console.ReadLine();
            var person = new MainBook();
            while (true)
            {

                switch (choice)
                {
                    case "1":
                        MainBook.Save();
                        break;
                    case "2":
                        MainBook.EditName();
                        break;
                    case "3":
                       
                        MainBook.DeleteEntries();
                        break;
                    case "4":
                        person.DisplayList();
                        break;
                    case "5":
                        return;
                    case "6":
                        MainBook.Duplicate();
                        break;


                }

                Console.WriteLine("Select Options\n 1:Add new Entry\n 2:Edit Entry\n 3:Delete Entry\n 4:Display Entry\n 5:Exit");
                choice = Console.ReadLine();
            
                
            }
            
        }
    }
}
