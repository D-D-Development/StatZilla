using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatZilla.Source.Models;

namespace StatZilla.Models
{
    public class Ftp:Session
    {
        public bool isActive { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string ftpDomain { get; set; }
        public string domainDestinationPath { get; set; }
        
        
        
        public Ftp() { }
        public Ftp( string domain, string username, string pswd, string path)
        {
            ftpDomain = domain;
            user = username ;
            pass = pswd;
            domainDestinationPath = path;
        }
    }
}
