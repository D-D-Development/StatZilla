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
    public enum MethodType
    {
        FTP,
        SCP,
        S3,
    }
    public partial class MainPage : Form
    {
        /// <summary>
        /// Declares local Log for the Main page
        /// Declares Dictionaries for all methods
        /// Declares File Selector
        /// Declares selected file Path and Name
        /// </summary>
        #region global variables

        public List<Models.Ftp> ftps;
        Dictionary<string, Ftp> ftpTable;
        Dictionary<string, Scp> scpTable;
        Dictionary<string, S3Bucket> s3Buckets;
        public Log Formlog;
        OpenFileDialog fileSelector;
        string filePath, fileName;

        #endregion

        public MainPage(Log log)
        {
            Setup(log);
            InitializeComponent();
           
        }
        /// <summary>
        /// Quick setup funtion.
        /// Initializes required dictionaries and other global variables. 
        /// </summary>
        private void Setup(Log log)
        {
            // Add new initializations here!!

            ftpTable = new Dictionary<string, Ftp>();
            scpTable = new Dictionary<string, Scp>();
            s3Buckets = new Dictionary<string, S3Bucket>();
            ftps = new List<Models.Ftp>();
            fileSelector = new OpenFileDialog();
            Formlog = log;
        }
        /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPage_Load(object sender, EventArgs e)
        {
            resizeListViewColumns();
            
        }
        /// <summary>
        /// 
        /// </summary>
        public void MyrefeshMethod()
        {
 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(masterSwitchButton.Checked == true)
            {
                addMethodButton.Enabled = true;
                sendMethodButton.Enabled = true;
                listviewTransferList.Enabled = true;
                browseButton.Enabled = true;
                selectorBox.Enabled = true;
                playButton.Enabled = true;
                stopButton.Enabled = true;
                lockButton.Enabled = true;
            }
            else if(masterSwitchButton.Checked == false)
            {
                addMethodButton.Enabled = false;
                sendMethodButton.Enabled = false;
                listviewTransferList.Enabled = false;
                browseButton.Enabled = false;
                selectorBox.Enabled = false;
                playButton.Enabled = false;
                stopButton.Enabled = false;
                lockButton.Enabled = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterClickedLV(object sender, PreviewKeyDownEventArgs e)
        {   
            // If a session is selected and the key "Enter" is pressed, get the item's type to search in the list else do nothing
            if (e.KeyCode == Keys.Enter && listviewTransferList.SelectedItems.Count > 0)
            {
                string searchedItemType = "";
                searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
                editSession(searchedItemType);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileTransferList(object sender, EventArgs e)
        {
            // Get the currently selected item in the transfer list
            string searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
            editSession(searchedItemType);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        private void editSession(string type)
        {
            /// Look up the item in the list of ftps and open the a form with its value in the 
            if (type == "FTP")
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

                // Update list view
                
            }
            else if (type == "SCP")
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
            else if (type == "S3")
            {
                // Find the selected item values using as a key the session name  
                var itemName = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString();
                var selected = s3Buckets[itemName];

                S3_Protocol editS3 = new S3_Protocol();

                //updateS3Table(scpTable[itemName], editS3.newS3Buckets);
                editS3.ShowDialog();
                // Update list view 
                
            }

            // Find values of the item 
            // var selectedItem = ftpTable[searchedItem];

            // Open form to edit the selection
            //  updateFTPMethod(selectedItem);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="newItem"></param>
        private void updateFTPTable(string item, Ftp newItem)
        {
            // Replace ftp element with new edited values 
            ftpTable[item] = newItem;
            //ftpTable.Add(newItem.ftpDomain, newItem);
        }
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private MethodType createNewMethod()
        {
       

            MethodType currentType = MethodType.FTP;

            // Open a new Form to insert new FTP method variables 
            MethodSelect newMethod = new MethodSelect();
            newMethod.ShowDialog();

            string index = newMethod.Type;
            string sessionName = newMethod.Name.ToString();

            if (index == "FTP") {
                FtpProtocol newFtpMethod = new FtpProtocol();
                newFtpMethod.ShowDialog();

           
                //StatZilla.Source.methodAdd.passTextBox.Text;
                Ftp newFtp = newFtpMethod.ftpMethod;
                {
                    // Initialize Session values
                    newFtp.sessionName = sessionName;
                    newFtp.sessionFilename = fileName;
                    newFtp.sessionType = MethodType.FTP;
                    newFtp.sessionStatus = false;
                    newFtp.sessionLastUpdate = 0;
                    // Add new ftp method to the list of ftps then store the key in a dictionary 
                    // Key is used to find values of the item 
                    ftpTable.Add(newFtp.sessionName, newFtp);
                    addToList(newFtp.sessionName, newFtp.sessionFilename, "FTP", "OFF", "Now");
                    //JSON function will go here
                    //ftps.Add(newFtp);
                }
            }
            else if (index == "SCP") {
                SCP_Protocol newScpMethod = new SCP_Protocol();
                newScpMethod.ShowDialog();

                // Add newly created SCP method to the list
                {
                    Scp newSCP = newScpMethod.scpMethod;
                    {
                        newSCP.sessionName = sessionName;
                        newSCP.sessionFilename = fileName;
                        newSCP.sessionType = MethodType.SCP;
                        newSCP.sessionStatus = false;
                        newSCP.sessionLastUpdate = 0;
                    }

                    //ftpTable.Add(sessionName, newFtp);
                    addToList(newSCP.sessionName, newSCP.sessionFilename, "SCP", "OFF", "Now");
                }
                //JSON function will go here
            }
            else if (index == "S3") {
                S3_Protocol newS3Method = new S3_Protocol();
                newS3Method.ShowDialog();

                // Add newly created S3 method to the list 
                {
                    S3Bucket newS3 = newS3Method.newS3Buckets;
                    {
                        newS3.sessionName = sessionName;
                        newS3.sessionFilename = fileName;
                        newS3.sessionType = MethodType.S3;
                        newS3.sessionStatus = false;
                        newS3.sessionLastUpdate = 0;
                    }
                    addToList(newS3.sessionName, newS3.sessionFilename, "S3", "OFF", "Now");
                }
            }

            return currentType;
        }
        /// <summary>
        /// 
        /// </summary>
        private void resizeListViewColumns() {
            // Auto resize column
            this.listviewTransferList.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listviewTransferList.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionName"></param>
        /// <param name="fileName"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="lastUpdated"></param>
        private void addToList(string sessionName, string fileName, string type, string status, string lastUpdated)
        {
            // Create an array of containing information about session to add a new row in the list of sessions 
            string[] row = { sessionName, fileName, type, status, lastUpdated };

            ListViewItem item = new ListViewItem(row);

            // Add the new row to the list
            listviewTransferList.Items.Add(item);
            resizeListViewColumns();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session_name"></param>
        /// <param name="file_name"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="lastUpdate"></param>
        private void updateItemList(string session_name, string file_name, string type, string status, string lastUpdate)
        {
            // Replace the selected row value by new value entered 
            listviewTransferList.SelectedItems[0].SubItems[0].Text = session_name;
            listviewTransferList.SelectedItems[0].SubItems[1].Text = file_name;
            listviewTransferList.SelectedItems[0].SubItems[2].Text = type;
            listviewTransferList.SelectedItems[0].SubItems[3].Text = status;
            listviewTransferList.SelectedItems[0].SubItems[4].Text = lastUpdate;
        }
        /// <summary>
        /// 
        /// </summary>
        private void removeItem()
        {
            if (MessageBox.Show("Are you sure you want to delete this? ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                listviewTransferList.Items.RemoveAt(listviewTransferList.SelectedIndices[0]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectorBox_TextChanged(object sender, EventArgs e)
        {
            //fileSelectorValidator();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool fileSelectorValidator()
        {
            string checkFIle = selectorBox.Text.ToString();

            if (selectorBox.Text == "")
                return false;
            
            if (File.Exists(checkFIle))       
                return true;
            
            return false;
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browserClick(object sender, EventArgs e)
        {
            if(selectorBox.Enabled == false)
                MessageBox.Show("Unlock File Selector before proceeding.");
            else
                selectFile();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectorBox_Enter(object sender, EventArgs e)
        {
            if (!fileSelectorValidator())
                MessageBox.Show("Select a valid File.");
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectorBox_Validating(object sender, CancelEventArgs e)
        {
            fileSelectorValidator();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lockButton_Click(object sender, EventArgs e)
        {
            if(selectorBox.Enabled == false)
            {
 
                selectorBox.Enabled = true;
            }
            else if(selectorBox.Enabled == true)
            {
         
                selectorBox.Enabled = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
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
