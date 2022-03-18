using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatZilla_Test1.Models;

namespace StatZilla_Test1
{
    public partial class FtpProtocol : Form
    {
       Ftp ftpMethod { set; get;  }
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
                this.ftpMethod.user = usernameBox.Text;
                this.ftpMethod.pass = passwdBox.Text;
                this.ftpMethod.ftpDomain = hostBox.Text;
                this.ftpMethod.domainDestinatoonPath = hostDestinationPath.Text;

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

    }
}
