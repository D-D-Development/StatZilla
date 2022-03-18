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
        public int Type { get; set; }

        public MethodSelect()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(textBox_Validator())
            {

                this.Name = DomainNicknameBox.Text;
                this.Type =  FileTypeComboBox.SelectedIndex;
      
                this.Close();
            }
           
        }

        private bool textBox_Validator()
        {
            // Check if text box empty 
            if (DomainNicknameBox.Text == "" || FileTypeComboBox.SelectedItem == null)
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
    }
}
