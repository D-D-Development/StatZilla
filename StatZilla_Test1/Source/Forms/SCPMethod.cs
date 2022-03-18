using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatZilla.Models;

namespace StatZilla.Forms
{
    public partial class SCPMethod : Form
    {
        private Scp scpMethod { set; get; }

        public SCPMethod()
        {
            InitializeComponent();
        }

        private void SCPMethod_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMethodButton_Click(object sender, EventArgs e)
        {
            scpMethod.user = usernameBox.Text;
            scpMethod.password = passwdBox.Text;
            scpMethod.host = hostBox.Text;
            scpMethod.path = pathBox.Text;
            scpMethod.port = portBox.Text;

            this.Close();
        }
    }
}
