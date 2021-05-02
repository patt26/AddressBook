using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Entry
    {
        public Entry(string firstName, string lastName, string phoneNum, string address, string city, string pinCode, string state, string emailId)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNum = phoneNum;
            Address = address;
            City = city;
            PinCode = pinCode;
            State = state;
            EmailId = emailId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public string EmailId { get; set; }
    }
}
