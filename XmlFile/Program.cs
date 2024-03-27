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
            SerializeObjectToXml();
            Console.ReadLine();
        }

        private static void SerializeObjectToXml()
        {
            var entry = new Entry()
            {
                Name = "Ashwin",
                Email = "ashwin@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now
            };

            var xmlSerializer=new XmlSerializer(typeof(Entry));
            using(var writer=new StringWriter())
            {
                xmlSerializer.Serialize(writer, entry);
                var xmlContent=writer.ToString();
                Console.WriteLine(xmlContent);
            }
        }
    }
}
