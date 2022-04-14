using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatZilla.Forms;

namespace StatZilla.Source.Models
{
    public class Session
    {
        public string sessionName { get; set; }
        public MethodType sessionType { get; set; }
        public string sessionFilename { get; set; }
        public bool sessionStatus { get; set; }
        public int sessionLastUpdate { get; set; }
    } 
}
