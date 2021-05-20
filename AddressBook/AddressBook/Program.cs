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
            Console.WriteLine("Select Options\n 1:Add new Entry\n 2:Edit Entry\n 3:Delete Entry\n 4:Display Entry\n 5:Search\n 6:View Person By City and State\n 7:Counter\n 8:Exit");
            string choice = Console.ReadLine();
            var person = new MainBook();
            while (true)
            {

                switch (choice)
                {
                    case "1":
                        person.Save();
                        break;
                    case "2":
                        person.EditName();
                        break;
                    case "3":
                       
                        person.DeleteEntries();
                        break;
                    case "4":
                        person.DisplayList();
                        break;
                    case "8":
                        return;
                    case "":
                        person.Duplicate();
                        break;
                    case "5":
                        person.Search();
                        break;
                    case "6":
                        person.View();
                        break;
                    case "7":
                        person.Count();
                        break;


                }

                Console.WriteLine("Select Options\n 1:Add new Entry\n 2:Edit Entry\n 3:Delete Entry\n 4:Display Entry\n 5:Search\n 6:View Person By City and State\n 7:Counter\n 8:Exit");
                choice = Console.ReadLine();
            
                
            }
            
        }
    }
}
