using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class MainBook
    {
        public static List<Entry> list = new List<Entry>();
        public static Dictionary<string, Entry> dictionary = new Dictionary<string, Entry>();
        public void Add(Entry contact)
        {
            list.Add(contact);
           
        }

        public void DisplayList()
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($" Address Book: {element.Key}\n First Name: {element.Value.FirstName}\n Last Name: {element.Value.LastName}\n Phone Number: {element.Value.PhoneNum}\n Address: {element.Value.Address}\n City: {element.Value.City}\n Pin Code: {element.Value.PinCode}\n State: {element.Value.State}\n Email ID: {element.Value.EmailId}\n");
            }
        }
        

        public static void EditName()
        {
            Console.WriteLine("Available Address Books: ");
            foreach(var key in dictionary)
            {
                Console.WriteLine(key.Key);
            }
            Console.WriteLine("Name of Book You Want to Edit: ");
            string book = Console.ReadLine();
            
            foreach (var element in dictionary)
            {
                if (element.Key == book)
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
                    Console.WriteLine("Address Book is Missing!!!");
                }
                
            }
        }
        public static void DeleteEntries()
        {
            Console.WriteLine("Enter Name You Want To Delete:- ");
            string Name2 = Console.ReadLine();
            foreach (var Entry in list)
            {
                if (Entry.FirstName == Name2)
                {
                    list.Remove(Entry);
                    Console.WriteLine("Deleted Succesfully");
                    break;
                }
            }
        }
        public static void Save()
        {
            Console.WriteLine("Enter Name for Address Book: ");
            string BookName = Console.ReadLine();

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
            dictionary.Add(BookName, newEntry);
        }
       
    } 
    
}
