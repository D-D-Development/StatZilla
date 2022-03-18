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
        public Ftp ftpMethod {  get; set; }
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
                Ftp newFtp = new Ftp(hostBox.Text, usernameBox.Text, passwdBox.Text, hostDestinationPath.Text);
                // Save values in the FTP class

                ftpMethod = newFtp;

                //this.ftpMethod.user = usernameBox.Text;
                //this.ftpMethod.pass = passwdBox.Text;
               // this.ftpMethod.ftpDomain = hostBox.Text;
                //this.ftpMethod.domainDestinationPath = hostDestinationPath.Text;

                this.Close();
            }
        }

        private bool textBox_Validator()
        {
            // Check if text box empty 
            if (usernameBox.Text == "" || passwdBox.Text == "" || hostBox.Text == "" || hostPathLabel.Text == "")
            {
                MessageBox.Show("Please do not leave any text box empty");
                // Log error
                return false;
            }
            return true;
        }

        private void pswdLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hostPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void hostDestinationPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
