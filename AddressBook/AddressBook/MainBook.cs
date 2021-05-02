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
                Console.WriteLine(Entry.FirstName);
            }
        }
    } 
    
}
