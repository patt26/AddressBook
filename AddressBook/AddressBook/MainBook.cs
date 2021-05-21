using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class MainBook
    {
        public List<Entry> list = new List<Entry>();
        public Dictionary<string, Entry> dictionary = new Dictionary<string, Entry>();
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
        

        public void EditName()
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
        public void DeleteEntries()
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
                else
                {
                    Console.WriteLine("No contact found");
                }
            }
        }
        public void Duplicate()  // TODO
        {
            Console.WriteLine("Enter Name for Address Book: ");
            string BookName = Console.ReadLine();
            Console.Write("Enter First Name- ");
            string firstName = Console.ReadLine();
            foreach (var element in dictionary)
            {
                if (element.Key.Equals(BookName))
                {
                    Console.WriteLine("Address book is already Present try with Different Name");
                }
            }
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
        public void Search()
        {
                Console.WriteLine("Enter Search Criteria::");
                Console.WriteLine("1.By City\n 2.By State\n 3.Exit");
                string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Enter City Name: ");
                            string city = Console.ReadLine();
                        foreach (var element in dictionary)
                        {
                            if (element.Value.City.Equals(city))
                            {
                                Console.WriteLine("Entry found in {0}: " + element.Value.FirstName, city);
                            }
                        }
                            break;
                        case "2":
                            Console.WriteLine("Enter State Name");
                            string state = Console.ReadLine();
                        foreach (var element in dictionary)
                        {
                            if (element.Value.State.Equals(state))
                            {
                                Console.WriteLine("Entry found in {0}: " + element.Value.FirstName, state);
                            }
                        }
                            break;
                        case "3":
                            return;
                    }
        }
        public void Count()
        {
            Console.WriteLine("Select Count criteria:\n 1:By City\n 2:By State\n 3:Exit\n ");
            string choice = Console.ReadLine();
            int counter = 0;
            int counter1 = 0;
                        
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter City Name: ");
                        string city = Console.ReadLine();
                        foreach (var element in dictionary)
                        {
                            if (element.Value.City.Equals(city))
                            {
                                counter++;
                            }
                        }
                        Console.WriteLine("Entries Found in {0} are {1}",city,counter);
                        break;
                    case "2":
                        Console.WriteLine("Enter State Name: ");
                        string state = Console.ReadLine();
                        foreach (var element in dictionary)
                        {
                            if (element.Value.State.Equals(state))
                            {
                                counter1++;
                            }
                        }
                        Console.WriteLine("Entries Found in {0} are {1}",state,counter1);
                        break;
                    case "3":
                        return;
                }
        }
        public void View()
        {
            Console.WriteLine("Enter Name of the person: ");
            string name = Console.ReadLine();

            foreach (var element in dictionary)
            {
                if (element.Value.FirstName.Equals(name))
                {
                    Console.WriteLine("{0}'s city : {1} and Its state is : {2}", name, element.Value.City, element.Value.State);
                }
                //else
                //{
                //    Console.WriteLine("Entered person is not in records!! "); // TODO
                //}
            }

                  
             
        }
        public void SortName()
        {
            Dictionary<string, Entry> sort = dictionary.OrderBy(x => x.Value.FirstName).ToDictionary(x => x.Key, x => x.Value);
            foreach(var element in sort)
            {
                Console.WriteLine("{0}, {1}",element.Value.FirstName,element.Value.LastName);
            }
        }
            
        public void Save()
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
