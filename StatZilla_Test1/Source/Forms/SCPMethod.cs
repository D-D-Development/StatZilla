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
    public partial class SCP_Protocol : Form
    {
        public Scp scpMethod { set; get; }

        public SCP_Protocol(Scp currentMethod)
        {
            scpMethod = currentMethod;
        }
        public SCP_Protocol()
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
            Scp temp = new Scp(usernameBox.Text, passwdBox.Text, hostBox.Text, pathBox.Text, portBox.Text);

            scpMethod = temp;

            this.Close();
        }

        void displayMethod()
        {
            usernameBox.Text = scpMethod.user;
            passwdBox.Text = scpMethod.password;
            hostBox.Text = scpMethod.host;
            pathBox.Text = scpMethod.path;
            portBox.Text = scpMethod.port;

        }
    }
}
