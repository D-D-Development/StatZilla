using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatZilla.Models
{
    public class Scp 
    {
        public bool isActive { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string host { get; set; }
        public string path { get; set; }
        public string port { get; set; }
        public Scp() { }

        public Scp (string u, string  pswd, string hostname, string destination, string portNum)
        {
            user = u;
            password = pswd;
            host = hostname;
            path = destination;
            port = portNum;
        }
  
    }
}
