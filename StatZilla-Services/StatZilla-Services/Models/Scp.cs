using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatZilla_Services.Models
{
    public class Scp : Session
    {
        public bool IsActive { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public string Path { get; set; }
        public Scp() { }

        public Scp (string u, string  pswd, string hostname, string destination)
        {
            User = u;
            Password = pswd;
            Host = hostname;
            Path = destination;
        }
    }
}
