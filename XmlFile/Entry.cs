using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlFile
{
    [Serializable]

    [XmlRoot("EntryDetails")]
    public class Entry
    {
        [XmlElement("EntryName")]
        public string Name { get; set; }
        [XmlElement("EntryEmail")]
        public string Email { get; set; }
        
        public int Age {  get; set; }

        [XmlIgnore]
        public DateTime JoiningDate {  get; set; }

        [XmlAttribute("Password")]
        public string Password {  get; set; }
    }
}
