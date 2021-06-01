using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class FileIo 
    {
        const string TEXT = @"C:\Users\prat\source\Assignment\AddressBook\AddressBook\AddressBook\StoreText.txt";
        const string CSV = @"C:\Users\prat\source\Assignment\AddressBook\AddressBook\AddressBook\StoreCSV.csv";
        const string JSON = @"C:\Users\prat\source\Assignment\AddressBook\AddressBook\AddressBook\StoreJason.json";
        public static void WriteToText(Dictionary<string, Entry> dictionary)
        {
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

        public static void WriteToCSV(Dictionary<string, Entry> dictionary)
        {
            if (File.Exists(CSV))
            {
                using (TextWriter tw = File.AppendText(CSV))
                {
                    tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,PinCode,PhoneNum,Email"));
                    foreach (var element in dictionary)
                    {
                        tw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", element.Value.FirstName, element.Value.LastName, element.Value.Address, element.Value.City, element.Value.State, element.Value.PinCode, element.Value.PhoneNum, element.Value.EmailId));
                    }

                }
            }
        }
        public static void WriteToJason(Dictionary<string,Entry> dictionary)
        {
            if (File.Exists(JSON))
            {
                JsonSerializer json = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(JSON)) 
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    json.Serialize(sw, dictionary);
                }
                Console.WriteLine("Successfully writen in JSON File");
            }
            else
            {
                Console.WriteLine("No file found!!");
            }
        }
        public static void ReadFromJson()
        {
            if (File.Exists(JSON))
            {
                Dictionary<string, Entry> dictionary = JsonConvert.DeserializeObject<Dictionary<string, Entry>>(File.ReadAllText(JSON));
                foreach(var element in dictionary)
                {
                    Console.Write("\n" + element.Value.FirstName);
                    Console.Write("\n" + element.Value.LastName);
                    Console.Write("\n" + element.Value.Address);
                    Console.Write("\n" + element.Value.City);
                    Console.Write("\n" + element.Value.State);
                    Console.Write("\n" + element.Value.PinCode);
                    Console.Write("\n" + element.Value.PhoneNum);
                    Console.Write("\n" + element.Value.EmailId);
                }
            }
            else
            {
                Console.WriteLine("No file Found!!");
            }
        }
    }
}
