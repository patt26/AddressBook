using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class MainBook
    {
        private List<Entry> list { get; set; } = new List<Entry>();
        public void AddContact(Entry contact)
        {
            list.Add(contact);
        }

        public void DisplayList()
        {
            foreach (var Entry in list)
            {
                Console.WriteLine(Entry.FirstName+" "+Entry.LastName+" "+Entry.PhoneNum+" "+Entry.Address+" "+Entry.City+" "+Entry.PinCode+" "+Entry.State+" " +Entry.EmailId);
            }
        }

        public void EditName(string Name)
        {
            foreach (var Entry in list)
            {
                if (Entry.FirstName == Name)
                {
                    Console.WriteLine("Enter Updated First Name: ");
                    string nfirstName = Console.ReadLine();
                    Console.WriteLine("Enter Updated Last Name: ");
                    string nlastName = Console.ReadLine();
                    Console.WriteLine("Enter Updated Phone Number: ");
                    string nphoneNum = Console.ReadLine();
                    Console.WriteLine("Enter Updated Address: ");
                    string naddress = Console.ReadLine();
                    Console.WriteLine("Enter Updated City Name: ");
                    string ncity = Console.ReadLine();
                    Console.WriteLine("Enter Updated Pin-Code: ");
                    string npinCode = Console.ReadLine();
                    Console.WriteLine("Enter Updated State: ");
                    string nstate = Console.ReadLine();
                    Console.WriteLine("Enter Updated Email-ID: ");
                    string nemailId = Console.ReadLine();
                    Console.WriteLine("Updated!!");
                }
                else
                {
                    Console.WriteLine("Entry is Missing!!!");
                }
                
            }
        }
       
    } 
    
}
