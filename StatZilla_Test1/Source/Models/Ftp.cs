using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatZilla_Test1.Models
{
    public class Ftp
    {
        public bool isActive { get; set; }
        public string name { get; set; }
        public string ftpDomain { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string domainDestinatoonPath { get; set; }
    }
}
