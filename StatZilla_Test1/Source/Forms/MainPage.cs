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
    }
    public partial class MainPage : Form
    {
        public List<Models.Ftp> ftps = new List<Models.Ftp>();
        // Create Dictionary of all methods 
        Dictionary<string, Ftp> ftpTable = new Dictionary<string, Ftp>();
        Dictionary<string, Scp> scpTable = new Dictionary<string, Scp>();
        Dictionary<string, S3Bucket> s3Buckets = new Dictionary<string, S3Bucket>();

        public Log Formlog;
        OpenFileDialog fileSelector = new OpenFileDialog();
        string filePath, fileName;
  
        public MainPage(Log log)
        {
            Formlog = log;
            InitializeComponent();
            //SetMyButtonIcon();
        }
        private void SetMyButtonIcon()
        {
            // Assign an image to the button.
            playButton.Image = Image.FromFile("C:\\source\\My.ico");
            // Align the image and text on the button.
            playButton.ImageAlign = ContentAlignment.MiddleRight;
            playButton.TextAlign = ContentAlignment.MiddleLeft;
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
            resizeListViewColumns();
            
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
            string searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
         

            if (searchedItemType == "FTP")
            {
                // Find the selected item values using as a key the session name  
                var itemName = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString();
                var selected = ftpTable[itemName];

                // Open selected form with values from the Dictionary List
                FtpProtocol editFTP = new FtpProtocol(selected);
                editFTP.displayMethod();
                editFTP.ShowDialog();

                // Update list of FTP 
                updateFTPTable(itemName, editFTP.ftpMethod);
            }
            else if(searchedItemType == "SCP")
            {
                // Find the selected item values using as a key the session name  
                var itemName = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString();
                var selected = scpTable[itemName];

                // Open selected form with values from the Dictionary List
                SCP_Protocol editSCP = new SCP_Protocol();
                editSCP.ShowDialog();

                // Update list of FTP 
                    //updateSCPTable(scpTable[itemName], editSCP.scpMethod);
            }
            else if(searchedItemType == "S3")
            {
                // Find the selected item values using as a key the session name  
                var itemName = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString();
                var selected = s3Buckets[itemName];

                S3_Protocol editS3 = new S3_Protocol();

                //updateS3Table(scpTable[itemName], editS3.newS3Buckets);
                editS3.ShowDialog();
            }

            // Find values of the item 
            // var selectedItem = ftpTable[searchedItem];

            // Open form to edit the selection
            //  updateFTPMethod(selectedItem);
        }

        private void updateFTPMethod(Ftp item)
        {
            Formlog.WriteLine(Log.Type.INFO, "Updating FTP Method " + item.ftpDomain);
            //MethodSelect methodSelected = new MethodSelect();
            
            // Open the form
            //methodSelected.ShowDialog();

            // Call Selected method with 
            //createNewMethod();

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

        private void updateFTPTable(string item, Ftp newItem)
        {
            // Replace ftp element with new edited values 
            ftpTable[item] = newItem;
            //ftpTable.Add(newItem.ftpDomain, newItem);
        }

        private void addNewFTPMethod()
        {
            Formlog.WriteLine(Log.Type.INFO, "Next form Loading");
            //.Ftp newFtp = new Models.Ftp();

            // Create new method 
            createNewMethod();

            //newFtp.ftpdomain = newMethod.domainField;       //StatZilla.Source.methodAdd.domainTextBox.Text;
            //newFtp.user = newMethod.userNameField;          //StatZilla.Source.methodAdd.userTextBox.Text;
            //newFtp.pass = newMethod.pswField;
            //newFtp.filenamePath = filePath;//newMethod.fileNamePath;
        }

        private MethodType createNewMethod()
        {
       

            MethodType currentType = MethodType.FTP;

            // Open a new Form to insert new FTP method variables 
            MethodSelect newMethod = new MethodSelect();
            newMethod.ShowDialog();

            int index = newMethod.Type;
            string sessionName = newMethod.Name.ToString();

            if (index == 0) {
                FtpProtocol newFtpMethod = new FtpProtocol();
                newFtpMethod.ShowDialog();

                //StatZilla.Source.methodAdd.passTextBox.Text;
                Ftp newFtp = newFtpMethod.ftpMethod;
                {
                    // Add new ftp method to the list of ftps then store the key in a dictionary 
                    // Key is used to find values of the item 
                    ftpTable.Add(sessionName, newFtp);
                    addToList(sessionName,  fileName, "FTP", "OFF", "Now");
                    //JSON function will go here
                    //ftps.Add(newFtp);
                }
            }
            else if (index == 1) {
                SCP_Protocol newScpMethod = new SCP_Protocol();
                newScpMethod.ShowDialog();

                // Add newly created SCP method to the list
                {
                    Scp newSCP = newScpMethod.scpMethod;
                    //ftpTable.Add(sessionName, newFtp);
                    addToList(sessionName,  fileName, "SCP", "OFF", "Now");
                }
                //JSON function will go here
            }
            else if (index == 2) {
                S3_Protocol newS3Method = new S3_Protocol();
                newS3Method.ShowDialog();

                // Add newly created S3 method to the list 
                {
                    S3Bucket newS3 = newS3Method.newS3Buckets;
                    addToList(sessionName, fileName, "S3", "OFF", "Now");
                }
            }

            return currentType;
        }


        private void resizeListViewColumns() {
            // Auto resize column
            this.listviewTransferList.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listviewTransferList.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void addToList(string sessionName, string fileName, string type, string status, string lastUpdated)
        {
            // Create an array of containing information about session to add a new row in the list of sessions 
            string[] row = { sessionName, fileName, type, status, lastUpdated };

            ListViewItem item = new ListViewItem(row);

            // Add the new row to the list
            listviewTransferList.Items.Add(item);
            resizeListViewColumns();
            
        }

        private void updateItemList(string session_name, string file_name, string type, string status, string lastUpdate)
        {
            // Replace the selected row value by new value entered 
            listviewTransferList.SelectedItems[0].SubItems[0].Text = session_name;
            listviewTransferList.SelectedItems[0].SubItems[1].Text = file_name;
            listviewTransferList.SelectedItems[0].SubItems[2].Text = type;
            listviewTransferList.SelectedItems[0].SubItems[3].Text = status;
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
            if (!fileSelectorValidator())
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

                // Parse the file path for filename 
                string[] path = filePath.Split('\\');
                fileName = path[path.Length - 1];
            }
        }

    }


}
