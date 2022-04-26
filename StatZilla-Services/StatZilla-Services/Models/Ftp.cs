using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatZilla_Services.Models
{
    public class Ftp:Session
    {

        public bool IsActive { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string FtpDomain { get; set; }
        public string DomainDestinationPath { get; set; }



        public Ftp() { }
        public Ftp(string domain, string username, string pswd, string path, string filename)
        {
            FtpDomain = domain;
            User = username;
            Pass = pswd;
            DomainDestinationPath = path;
            sessionFilename = filename;
        }
    }
}
