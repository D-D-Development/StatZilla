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
        public Scp scpMethod = new();
        public MethodSelect backToMethodSelect;

        public SCP_Protocol()
        {
            InitializeComponent();
        }

        public SCP_Protocol(Scp currentMethod)
        {
            scpMethod = currentMethod;
            InitializeComponent();
            this.DisplayMethod();
            this.ShowDialog();
        }

        public SCP_Protocol(MethodSelect prevForm)
        {
            InitializeComponent();
            backToMethodSelect = prevForm;
        }

        private void SCPMethod_Load(object sender, EventArgs e)
        {

        }

        private void AddMethodButton_Click(object sender, EventArgs e)
        {
            ConfirmConfig();
        }

        private void ConfirmConfig()
        {
            if (TextBox_Validator())
            {
                // Save values in the FTP class
                SetSCPConfiguration(filenameBox.Text, usernameBox.Text, passwdBox.Text, hostBox.Text, pathBox.Text);

                // If Select Method Form open close it, if not do nothing 
                if (backToMethodSelect != null)
                {
                    backToMethodSelect.Close();
                }
                this.Close();

            }
        }
        private void SetSCPConfiguration(string filename, string user, string pass, string host, string dest)
        {
            scpMethod.User = user;
            scpMethod.Password = pass;
            scpMethod.Host = host;
            scpMethod.Path = dest;
            scpMethod.sessionFilename = filename;
        }
        private bool TextBox_Validator()
        {
            // Check if text box empty 
            if (filenameBox.Text == "" || usernameBox.Text == "" || passwdBox.Text == "" || pathBox.Text == "" || hostBox.Text == "" )
            {
                MessageBox.Show("Please do not leave any text box empty");
                // Log error
                return false;
            }
            return true;
        }
        public void DisplayMethod()
        {
            usernameBox.Text = scpMethod.User;
            passwdBox.Text = scpMethod.Password;
            hostBox.Text = scpMethod.Host;
            pathBox.Text = scpMethod.Path;

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (backToMethodSelect != null)
            {
                this.Dispose();
                backToMethodSelect.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
