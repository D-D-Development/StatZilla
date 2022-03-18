using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatZilla.Models;
using StatZilla.Services;
using StatZilla.Utility;

namespace StatZilla.Forms
{
    enum MethodType
    {
        FTP,
        SCP,
        S3,
        OBJECT
    }
    public partial class MainPage : Form
    {
        public List<Models.Ftp> ftps = new List<Models.Ftp>();
        // Create Dictionary.
        Dictionary<string, Models.Ftp> ftpTable = new Dictionary<string, Models.Ftp>();
        public Log Formlog;
        OpenFileDialog fileSelector = new OpenFileDialog();
        string filePath, fileName;
  
        public MainPage(Log log)
        {
            Formlog = log;
            InitializeComponent();
        }

        private void addMethod_Click(object sender, EventArgs e)
        {
            if (fileSelectorValidator()) {
                try
                {
                    addNewFTPMethod();
                    MyrefeshMethod();
                }
                catch (Exception ex)
                {
                    Formlog.WriteLine(Log.Type.ERROR, ex.Message);
                }
            }
            else {
                MessageBox.Show("Please. Select a valid file");
            }
          
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
          
        }

        public void MyrefeshMethod()
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string, Models.Ftp> f in ftpTable)
            {
                try
                {
                    Formlog.WriteLine(Log.Type.INFO, "Initalizing Ftp");
                    ftpSend send = new ftpSend(f.Value.ftpDomain, f.Value.user, f.Value.pass);
                    send.Send();
                }
                catch(Exception ex)
                {
                    Formlog.WriteLine(Log.Type.ERROR, ex.Message);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(masterSwitchButton.Checked == true)
            {
                addMethodButton.Enabled = true;
                sendMethodButton.Enabled = true;
                listviewTransferList.Enabled = true;
                browseButton.Enabled = true;
                selectorBox.Enabled = true;
            }
            else if(masterSwitchButton.Checked == false)
            {
                addMethodButton.Enabled = false;
                sendMethodButton.Enabled = false;
                listviewTransferList.Enabled = false;
                browseButton.Enabled = false;
                selectorBox.Enabled = false;
            }
        }

        private void fileTransferList(object sender, EventArgs e)
        {
            /// Look up the item in the list of ftps and open the a form with its value in the 

            // Get the currently selected item in the transfer list
            string searchedItem = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString(); 

            // Find values of the item 
            var selectedItem = ftpTable[searchedItem];

            // Open form to edit the selection
            updateFTPMethod(selectedItem);

      
        }

        private void updateFTPMethod(Models.Ftp item)
        {
            Formlog.WriteLine(Log.Type.INFO, "Updating FTP Method " + item.ftpDomain);
            MethodSelect methodSelected = new MethodSelect();
            
            // Open the form
            methodSelected.ShowDialog();

            // Call Selected method with 
            createNewMethod(methodSelected);

            //// Hold updated ftp method 
            //Models.Ftp updated = new Models.Ftp();

            //updated.ftpDomain = currentMethod.;
            //updated.user = currentMethod.userNameField;
            //updated.name = currentMethod.Name;
            //updated.pass = currentMethod.pswField;

            // Update the list with new item
            //updateItemList(updated.ftpDomain, updated.user, fileName,filePath, "Now");

            // Update the Ftp table data set
            //updateFTPTable(item,updated);
        }

        private void updateFTPTable(Models.Ftp item, Models.Ftp newItem)
        {
            ftpTable.Remove(item.ftpDomain);

            ftpTable.Add(newItem.ftpDomain, newItem);
        }

        private void addNewFTPMethod()
        {
            Formlog.WriteLine(Log.Type.INFO, "Next form Loading");
            //.Ftp newFtp = new Models.Ftp();

            // Open a new Form to insert new FTP method variables 
            MethodSelect newMethod = new MethodSelect();


            newMethod.ShowDialog();

            // Create new method 
            createNewMethod(newMethod);

            //newFtp.ftpdomain = newMethod.domainField;       //StatZilla.Source.methodAdd.domainTextBox.Text;
            //newFtp.user = newMethod.userNameField;          //StatZilla.Source.methodAdd.userTextBox.Text;
            //newFtp.pass = newMethod.pswField;
            //newFtp.filenamePath = filePath;//newMethod.fileNamePath;

            string[] path = filePath.Split(',');
            fileName = path[path.Length - 1];


        }

        private MethodType createNewMethod(Forms.MethodSelect method)
        {
            int index = method.Type;

            MethodType currentType = MethodType.FTP;

            if (index == 0) {
                FtpProtocol newFtpMethod = new FtpProtocol();
                newFtpMethod.ShowDialog();

                //StatZilla.Source.methodAdd.passTextBox.Text;
                Ftp newFtp = newFtpMethod.ftpMethod;
                {
                    // Add new ftp method to the list of ftps then store the key in a dictionary 
                    // Key is used to find values of the item 
                    ftpTable.Add(newFtp.ftpDomain, newFtp);
                    addToList(newFtp.ftpDomain, newFtp.user, fileName, filePath, "Now");
                    //JSON function will go here
                    //ftps.Add(newFtp);
                }
            }
            else if (index == 1) {
                SCPMethod newScpMethod = new SCPMethod();
                newScpMethod.ShowDialog();

                //JSON function will go here
            }
            else if (index == 2) {
                S3Method newS3Method = new S3Method();
                newS3Method.ShowDialog();
                //JSON function will go here
            }

            return currentType;
        }

        private void addToList(string domainName, string userName, string fileName, string path, string lastUpdated)
        {
            string[] row = { domainName, userName, fileName, path, lastUpdated };

            ListViewItem item = new ListViewItem(row);

            listviewTransferList.Items.Add(item);
        }

        private void updateItemList(string domainName, string userName, string file, string path, string lastUpdate)
        {
            listviewTransferList.SelectedItems[0].SubItems[0].Text = domainName;
            listviewTransferList.SelectedItems[0].SubItems[1].Text = userName;
            listviewTransferList.SelectedItems[0].SubItems[2].Text = file;
            listviewTransferList.SelectedItems[0].SubItems[3].Text = path;
            listviewTransferList.SelectedItems[0].SubItems[4].Text = lastUpdate;
        }

        private void removeItem()
        {
            if (MessageBox.Show("Are you sure you want to delete this? ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                listviewTransferList.Items.RemoveAt(listviewTransferList.SelectedIndices[0]);
        }


        private void selectorBox_TextChanged(object sender, EventArgs e)
        {
            //fileSelectorValidator();
        }

        private bool fileSelectorValidator()
        {
            string checkFIle = selectorBox.Text.ToString();

            if (selectorBox.Text == "")
                return false;
            
            if (File.Exists(checkFIle))       
                return true;
            
            return false;
           
        }

        private void browserClick(object sender, EventArgs e)
        {
            selectFile();
        }

        private void selectorBox_Enter(object sender, EventArgs e)
        {
            if(!fileSelectorValidator())
                    MessageBox.Show("Select a valid File.");
        }

        private void selectorBox_Validating(object sender, CancelEventArgs e)
        {
            fileSelectorValidator();
        }

        private void selectFile()
        {
            if(fileSelector.ShowDialog() == DialogResult.OK)
            {
                selectorBox.Text = fileSelector.FileName;
                filePath = fileSelector.FileName;
            
            }
        }

    }


}
