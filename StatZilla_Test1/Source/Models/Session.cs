using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatZilla.Forms;

namespace StatZilla.Models
{
    public class Session
    {
        public string sessionName { get; set; }
        public string sessionType { get; set; }
        public string sessionFilename { get; set; }
        public bool sessionStatus { get; set; }
        public DateTime sessionLastUpdate { get; set; }
    } 
}
