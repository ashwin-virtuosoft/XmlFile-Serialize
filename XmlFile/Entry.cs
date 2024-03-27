﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlFile
{
    [Serializable]
    internal class Entry
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age {  get; set; }
        public DateTime JoiningDate {  get; set; }
    }
}
