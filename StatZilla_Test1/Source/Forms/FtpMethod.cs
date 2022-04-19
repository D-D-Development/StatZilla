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
    public partial class FtpProtocol : Form
    {
        public Ftp ftpMethod { get; set; }

        public FtpProtocol(Ftp currentMethod)
        {
            ftpMethod = currentMethod;
            InitializeComponent();
        }

        public FtpProtocol()
        {
            InitializeComponent();
        }

        private void FtpProtocol_Load(object sender, EventArgs e)
        {

        }

        private void addNewMethodButton_Click(object sender, EventArgs e)
        {
            if (textBox_Validator())
            {
                // Save values in the FTP class
                setFTPConfiguration(filenameBox.Text, usernameBox.Text, passwdBox.Text, hostBox.Text, hostDestinationPath.Text);

                //this.ftpMethod.user = usernameBox.Text;
                //this.ftpMethod.pass = passwdBox.Text;
                // this.ftpMethod.ftpDomain = hostBox.Text;
                //this.ftpMethod.domainDestinationPath = hostDestinationPath.Text;

                this.Close();
            }
        }
        private void setFTPConfiguration(string filename, string user, string pass,string host, string dest)
        {
            ftpMethod.user = user;
            ftpMethod.pass = pass;
            ftpMethod.ftpDomain = host;
            ftpMethod.domainDestinationPath = dest;
            ftpMethod.sessionFilename = filename;

        }
        private bool textBox_Validator()
        {
            // Check if text box empty 
            if (usernameBox.Text == "" || passwdBox.Text == "" || hostBox.Text == "" || hostPathLabel.Text == "" || filenameBox.Text == "")
            {
                MessageBox.Show("Please do not leave any text box empty");
                // Log error
                return false;
            }
            return true;
        }

        public void displayMethod()
        {
            filenameBox.Text = ftpMethod.sessionFilename;
            usernameBox.Text = ftpMethod.user;
            passwdBox.Text = ftpMethod.pass;
            hostBox.Text = ftpMethod.ftpDomain;
            hostDestinationPath.Text = ftpMethod.domainDestinationPath;
        }
    }
}
