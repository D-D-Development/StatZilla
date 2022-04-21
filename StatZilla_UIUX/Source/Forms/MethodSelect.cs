using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;       // For SCP Transfer
using System.IO;
using StatZilla.Models;

namespace StatZilla.Forms
{
  

    public partial class MethodSelect : Form
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public FtpProtocol FtpForm;
        public SCP_Protocol ScpForm;
        public S3_Protocol s3Form;

        public MethodSelect()
        {
            InitializeComponent();
        }

        public MethodSelect(MethodSelect returnToForm)
        {
            InitializeComponent();
            returnToForm.Show();
        }

        private void changeForm()
        {
            this.Hide();

            if (ftpRadioButton.Checked == true) { FtpForm = new FtpProtocol(this);  FtpForm.ShowDialog(); }
               
            else if (s3radioButton.Checked == true) { s3Form = new S3_Protocol(this); s3Form.ShowDialog(); }
               
            else if (scpRadioButton.Checked == true) { ScpForm = new SCP_Protocol(this); ScpForm.ShowDialog(); }
              
            else
                MessageBox.Show("Please Select a transfer type.");
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(textBox_Validator())
            {
                this.Name = DomainNicknameBox.Text;
                this.Type = getType();
                
                changeForm();
            }
           
        }

        private string getType()
        {
            string currentType = "FTP";

            if (scpRadioButton.Checked == true)
                currentType = "SCP";
            else if (s3radioButton.Checked == true)
                currentType =  "S3";
            else if(ftpRadioButton.Checked == false)
                MessageBox.Show("Please Select a transfer type.");

            return currentType;
        }
        private bool textBox_Validator()
        {
            // Check if text box empty 
            if (DomainNicknameBox.Text == "" || getType() == null)
            {
                MessageBox.Show("Please do not leave any text box empty");
                // Log error
                return false;
            }

            return true;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MethodSelect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
