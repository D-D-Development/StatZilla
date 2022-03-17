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
using StatZilla_Test1.Models;

namespace StatZilla_Test1.Source
{

    public partial class MethodSelect : Form
    {
        public string Name { get; set; }
        public int Type { get; set; }

        public MethodSelect(Ftp currentItem)
        {
            InitializeComponent();
            if (currentItem.ftpdomain != null)
                displayMethod(currentItem);
        }

        

        private void methodAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(textBox_Validator())
            {

                this.Name = nameTextBox1.Text;
                this.Type = TypeComboBox.SelectedIndex;
      
                this.Close();
            }
           
        }

        

        public void displayMethod(Ftp item)
        {
            domain_textBox.Text = item.ftpdomain;
            user_name_textBox.Text = item.user;
            password_textBox.Text = item.pass;
            //selectorBox.Text = item.filenamePath;
            
        }

        private bool textBox_Validator()
        {
            // Check if text box empty 
            if (domain_textBox.Text == "" || user_name_textBox.Text == "" || password_textBox.Text == "")
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
    }
}
