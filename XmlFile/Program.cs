using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SerializeObjectToXml();  -- Just Creating xml in console

            //SerializeObjectToXmlFile(); -- created in xml file in local folder

            SerializeListToXmlFile();

            Console.WriteLine("Completed..");
            Console.ReadLine();
        }

        private static void SerializeObjectToXml()
        {
            var entry = new Entry()
            {
                Name = "Ashwin",
                Email = "ashwin@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now,
                Password="Ask12@"
            };

            var xmlSerializer=new XmlSerializer(typeof(Entry));
            using(var writer=new StringWriter())
            {
                xmlSerializer.Serialize(writer, entry);
                var xmlContent=writer.ToString();
                Console.WriteLine(xmlContent);
            }
        }


        private static void SerializeObjectToXmlFile()
        {
            var entry = new Entry()
            {
                Name = "Ashwin",
                Email = "ashwin@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now,
                Password = "Ask12@"
            };

            var xmlSerializer = new XmlSerializer(typeof(Entry));
            using (var writer = new StreamWriter(@"C:\Users\ashwi\Desktop\Sample\Sample.xml"))
            {
                xmlSerializer.Serialize(writer, entry);
            }

        }

        private static void SerializeListToXmlFile()
        {
            var entryList = new List<Entry>()
            {
                new Entry
                {
                    Name = "Ashwin",
                    Email = "ashwin@gmail.com",
                    Age = 22,
                    JoiningDate = DateTime.Now,
                    Password = "Ask12@"
                },
                new Entry{
                    Name = "Vishnu",
                    Email = "vsih@gmail.com",
                    Age = 22,
                    JoiningDate = DateTime.Now,
                    Password = "Ask122@"
                },
                  new Entry
                {
                    Name = "sarath",
                    Email = "ashwin@gmail.com",
                    Age = 22,
                    JoiningDate = DateTime.Now,
                    Password = "Ask12@"
                },
                    new Entry
                {
                    Name = "Jezin",
                    Email = "ashwin@gmail.com",
                    Age = 22,
                    JoiningDate = DateTime.Now,
                    Password = "Ask12@"
                },
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Entry>));
            using (var writer = new StreamWriter(@"C:\Users\ashwi\Desktop\Sample\Sample.xml"))
            {
                xmlSerializer.Serialize(writer, entryList);
            }
        }
    }
}
