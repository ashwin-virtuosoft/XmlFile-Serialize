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

            //SerializeObjectToXmlString();       -- Just Creating xml in console

            //SerializeObjectToXmlFile();         -- created in xml file in local folder

            //SerializeListToXmlFile();

            //DeserializeListToXmlFile();

            DeserializeXmlFileToObject();

            Console.WriteLine("Completed..");
            Console.ReadLine();
        }

        private static void SerializeObjectToXmlString()
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
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, entry);
                var xmlContent = writer.ToString();
                Console.WriteLine(xmlContent);
                DeSerializeXmlStringToObject(xmlContent);
            }
        }

        private static void DeSerializeXmlStringToObject(string xmlString)
        {
            var xmlSerilizer=new XmlSerializer(typeof(Entry));
            using(var reader=new StringReader(xmlString))
            {
                var entry=(Entry)xmlSerilizer.Deserialize(reader);
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
            using (var writer = new StreamWriter(@"E:\XmlStudy\Sample1.xml"))
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
            using (var writer = new StreamWriter(@"E:\XmlStudy\Sample2.xml"))
            {
                xmlSerializer.Serialize(writer, entryList);
            }
        }

        private static void DeserializeListToXmlFile()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Entry>));
            using (var reader = new StreamReader(@"E:\XmlStudy\Sample2.xml"))
            {
                var entries = (List<Entry>)xmlSerializer.Deserialize(reader);
            }
        }

        private static void DeserializeXmlFileToObject()
        {
            var xmlSerializer = new XmlSerializer(typeof(Entry));
            using (var reader = new StreamReader(@"E:\XmlStudy\Sample1.xml"))
            {
                var entry = (Entry)xmlSerializer.Deserialize(reader);
            }
        }

    }
}
