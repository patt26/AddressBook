using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class FileIo // TODO
    {
        public static void WriteToText(Dictionary<string, Entry> dictionary)
        {
            const string TEXT = @"C:\Users\prat\source\Assignment\AddressBook\AddressBook\AddressBook\StoreText.txt";
                        
                if (File.Exists(TEXT))
                {
                    using (TextWriter tw = File.AppendText(TEXT))
                    {
                        tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,PinCode,PhoneNum,Email"));
                        foreach (var element in dictionary)
                        {
                            tw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", element.Value.FirstName, element.Value.LastName, element.Value.Address, element.Value.City, element.Value.State, element.Value.PinCode, element.Value.PhoneNum, element.Value.EmailId));
                        }
                       
                    }
                }
            
        }
    }
}
