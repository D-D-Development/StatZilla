using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatZilla.Models;
using StatZilla.Services;
using StatZilla.Utility;

namespace StatZilla.Forms
{
    public partial class MainPage : Form
    {
        #region Initializing and Setup

        /// <summary>
        /// Declares local Log for the Main page
        /// Declares Dictionaries for all methods
        /// Declares File Selector
        /// Declares selected file Path and Name
        /// </summary>
        #region global variables

        GodModel MasterModel;
        public Log Formlog;
        OpenFileDialog fileSelector;
        string directory;
        string JsonFilePath, JsonFileName;

        #endregion

        public MainPage(Log log, GodModel Initial_Master)
        {
            
            InitializeComponent();
            Setup(log, Initial_Master);
        }
        /// <summary>
        /// Quick setup funtion.
        /// Initializes required dictionaries and other global variables. 
        /// </summary>
        private void Setup(Log log, GodModel Initial_Master)
        {
            // Add new initializations here!!S
            MasterModel = new GodModel();
            MasterModel = Initial_Master;
            fileSelector = new OpenFileDialog();
            Formlog = log;
            JsonFilePath = ConfigurationManager.AppSettings["Json-Path"];
            JsonFileName = ConfigurationManager.AppSettings["Json-File"];
            directory = System.IO.Directory.GetParent(Application.CommonAppDataPath).ToString();

            Ftp temp = new();
            Ftp temp2 = new();
            Scp Temp3 = new();
            S3Bucket Temp5 = new();

            // TEST DATA
            temp.IsActive = false;
            temp.sessionName = "TEST 1";
            temp.sessionFilename = "fileTest.txt";
            temp.sessionType = "FTP";
            temp.sessionStatus = false;
            temp.User = "tester1";
            temp.Pass = "abcd1234";
            temp.FtpDomain = "MY DOMAIN";
            temp.DomainDestinationPath = "Desktop";

            temp2.User = "gfef";
            temp2.IsActive = false;
            temp2.Pass = "fesf";
            temp2.sessionFilename = "Nothing.txt";
            Temp3.IsActive = true;
            Temp3.Password = "tesfg";
            Temp5.isActive = true;
            Temp5.sessionName = "test";
            MasterModel.ftpDict.Add(temp.sessionName, temp);
            MasterModel.ftpDict.Add("trsvrdasfg", temp);
            MasterModel.ftpDict.Add("trsvrdafd", temp);
            MasterModel.ftpDict.Add("trsvrdagh", temp);
            MasterModel.ftpDict.Add("trsvrdag", temp2);
            MasterModel.ftpDict.Add("trsvrdga", temp2);

            AddToList(temp.sessionName, temp.sessionFilename, temp.sessionType, ONorOFF(temp.sessionStatus), "Not Started");
            //write_json();

        }
        #endregion

        #region JSON Handling
        /// <summary>
        /// This function converts the MasterModel into a json string.
        /// </summary>
        private void Write_json()
        {
            try
            {
                string file = Path.Combine(Path.Combine(directory, JsonFilePath), JsonFileName);
                var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(MasterModel);
                File.WriteAllText(file, jsonString);
            }
            catch(Exception ex)
            {
                Formlog.WriteLine(Log.Type.ERROR, ex.Message);
            }
        }

        #endregion

        #region BUTTONS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMethod_Button(object sender, EventArgs e)
        {

            try
            {
                if (FileSelectorValidator(MasterModel.masterFilePath))
                {
                    AddNewFTPMethod();
                    MyrefeshMethod();
                }
                else
                {
                    MessageBox.Show("Please. Select a valid file");
                }
            }
            catch (Exception ex)
            {
                Formlog.WriteLine(Log.Type.ERROR, ex.Message);
            }
        }
   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Button(object sender, EventArgs e)
        {
            if(listviewTransferList.SelectedItems.Count > 0)
            {
                var currentSession = this.listviewTransferList.SelectedItems;
                if (MasterModel.masterFilePath == "" || !FileSelectorValidator(MasterModel.masterFilePath)) 
                {
                    PrintFileErrorMessage("","");
                }
                else if(currentSession[0].SubItems[3].Text == "OFF")
                {
                    // Change status of current Item in the Master Model
                    // Find the selected item values using as a key the session name  
                    // Get the session type to know which dictionary to find the session
                    var searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
                    EditStatus(searchedItemType, true);
                    // Update the time session started last
                    EditStartTime(searchedItemType);
                    // Log Session Started
                    Formlog.WriteLine(Log.Type.INFO, $"Session {listviewTransferList.SelectedItems[0].SubItems[0].Text} started");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Button(object sender, EventArgs e)
        {
            if (listviewTransferList.SelectedItems.Count > 0)
            {
                var currentSession = this.listviewTransferList.SelectedItems;
                if (currentSession[0].SubItems[3].Text == "ON")
                {
                    // Change status of current Item in the Master Model
                    // Find the selected item values using as a key the session name  
                    // Get the session type to know which dictionary to find the session
                    var searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
                    EditStatus(searchedItemType, false);
                    // Log Session stop
                    Formlog.WriteLine(Log.Type.INFO, $"Session {listviewTransferList.SelectedItems[0].SubItems[0].Text} stopped");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> ///REMOVE THIS!
        private void REmoveThisButton(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Models.Ftp> f in MasterModel.ftpDict)
            {
                try
                {
                    Formlog.WriteLine(Log.Type.INFO, "Initalizing Ftp");
                    ftpSend send = new(f.Value.FtpDomain, f.Value.User, f.Value.Pass);
                    send.Send();
                }
                catch (Exception ex)
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
        private void LockIcon_Button(object sender, EventArgs e)
        {
            if (selectorBox.Enabled == false)
            {
                selectorBox.Enabled = true;
            }
            else if (selectorBox.Enabled == true)
            {
                selectorBox.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileBrowser_Button(object sender, EventArgs e)
        {
            if (selectorBox.Enabled == false)
                MessageBox.Show("Unlock file selector before proceeding.");
            else
                SelectFile();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Write_json();
            MessageBox.Show("StatZilla : Config successfully svaed. ");
            Formlog.WriteLine(Log.Type.INFO, "Configuration Saved");
        }


        #endregion

        #region FTP

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="newItem"></param>
        private void UpdateFTPTable(string item, Ftp newItem)
        {
            // Replace ftp element with new edited values 
            MasterModel.ftpDict[item] = newItem;
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddNewFTPMethod()
        {
            // Create new method 
            CreateNewMethod();
        }
        #endregion

        #region SCP
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="newItem"></param>
        private void UpdateSCPTable(string item, Scp newItem)
        {
            // Replace ftp element with new edited values 
            MasterModel.SCPDict[item] = newItem;
        }
        #endregion

        #region S3Buckets
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="newItem"></param>
        private void UpdateS3Table(string item, S3Bucket newItem)
        {
            // Replace ftp element with new edited values 
            MasterModel.S3Dict[item] = newItem;
        }
        #endregion

        #region ObjStore
        #endregion

        #region Reload Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPage_Load(object sender, EventArgs e)
        {
            ResizeListViewColumns();
            
        }
        /// <summary>
        /// 
        /// </summary>
        public static void MyrefeshMethod()
        {
 
        }
        #endregion

        #region Create New Method Module

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void CreateNewMethod()
        {
            // Open a new Form to insert new FTP method variables 
            MethodSelect newMethod = new();
            newMethod.ShowDialog();

            string transfterMethod = newMethod.Type;
            string sessionName = newMethod.Name.ToString();
            string sessionStartTime = "Not Started";

            if ( transfterMethod == "FTP") {
                // Create a new instance of the FTP method
                Ftp newFtp = newMethod.FtpForm.ftpMethod;//newFtpMethod.ftpMethod;
                {
                    // Initialize Session values
                    newFtp.sessionName = sessionName;
                    newFtp.sessionType = transfterMethod;
                    newFtp.sessionStatus = false;
                    newFtp.sessionLastUpdate = DateTime.Now;
                    // Add new ftp method to the list of ftps then store the key in a dictionary 
                    // Key is used to find values of the item 
                    MasterModel.ftpDict.Add(newFtp.sessionName, newFtp);
                    AddToList(newFtp.sessionName, newFtp.sessionFilename, newFtp.sessionType, ONorOFF(newFtp.sessionStatus), sessionStartTime);
                    Formlog.WriteLine(Log.Type.INFO, "FTP Session < " + newFtp.sessionName + " > Added");
                    //JSON function will go here
                    //ftps.Add(newFtp);
                }
            }
            else if (transfterMethod == "SCP") {
                // Add newly created SCP method to the list
                {
                    Scp newSCP = newMethod.ScpForm.scpMethod;
                    {
                        newSCP.sessionName = sessionName;
                        newSCP.sessionType = transfterMethod;
                        newSCP.sessionStatus = false;
                        newSCP.sessionLastUpdate = DateTime.Now;
                    }
                    MasterModel.SCPDict.Add(newSCP.sessionName, newSCP);
                    AddToList(newSCP.sessionName, newSCP.sessionFilename, newSCP.sessionType, ONorOFF(newSCP.sessionStatus), sessionStartTime);
                    Formlog.WriteLine(Log.Type.INFO, "SCP Session < " + newSCP.sessionName + " > Added");
                }
                //JSON function will go here
            }
            else if (transfterMethod == "S3") {
                // Create a new instance of the S3 method
                S3Bucket newS3 = newMethod.s3Form.newS3Buckets;
                {
                    newS3.sessionName = sessionName;
                    newS3.sessionType = transfterMethod;
                    newS3.sessionStatus = false;
                    newS3.sessionLastUpdate = DateTime.Now;
                }
                MasterModel.S3Dict.Add(newS3.sessionName, newS3);
                AddToList(newS3.sessionName, newS3.sessionFilename, newS3.sessionType, ONorOFF(newS3.sessionStatus), sessionStartTime);
                Formlog.WriteLine(Log.Type.INFO, "S3 Session < " + newS3.sessionName + " > Added");
            }
        }

        #endregion

        #region List View Properties


        static string ONorOFF(bool status)
        {
            if (status) return "ON";
            else return "OFF";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        private void EditSession(string type)
        {
            try {
                // Find the selected item values using as a key the session name  
                var currentSession = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString();

                /// Look up the item in the list of ftps and open the a form with its value in the 
                if (type == "FTP")
                {
                    var selected = MasterModel.ftpDict[currentSession];
                    // Open selected form with values from the Dictionary List
                    FtpProtocol editFTP = new(selected);

                    Ftp updatedFTP = editFTP.ftpMethod;

                    // Update list of FTP 
                    UpdateFTPTable(currentSession, updatedFTP);
                    
                    UpdateItemList(updatedFTP.sessionName, updatedFTP.sessionFilename, updatedFTP.sessionType, ONorOFF(updatedFTP.sessionStatus));

                   // Formlog.WriteLine(Log.Type.INFO, "FTP Session < " + updatedFTP.sessionName + " > Edited");

                }
                else if (type == "SCP")
                {
                    var selected = MasterModel.SCPDict[currentSession];

                    // Open selected form with values from the Dictionary List
                    SCP_Protocol editSCP = new(selected);

                    Scp updatedSCP = editSCP.scpMethod;

                    // Update list of SCP 
                    UpdateSCPTable(currentSession, updatedSCP);
                    
                    UpdateItemList(updatedSCP.sessionName, updatedSCP.sessionFilename, updatedSCP.sessionType, ONorOFF(updatedSCP.sessionStatus));

                    //Formlog.WriteLine(Log.Type.INFO, "SCP Session < " + updatedSCP.sessionName + " > Edited");
                }
                else if (type == "S3")
                {
                    var selected = MasterModel.S3Dict[currentSession];

                    S3_Protocol editS3 = new(selected);

                    S3Bucket updatedS3 = editS3.newS3Buckets;
                    // Update list view 
                    UpdateS3Table(currentSession, updatedS3);
                    
                    UpdateItemList(updatedS3.sessionName, updatedS3.sessionFilename, updatedS3.sessionType, ONorOFF(updatedS3.sessionStatus));

                    //Formlog.WriteLine(Log.Type.INFO, "S3 Session < " + updatedS3.sessionName + " > Edited");
                }
            }
            catch (Exception ex)
            {
                Formlog.WriteLine(Log.Type.ERROR, ex.Message);
            }
        }

        private void EditStartTime(string type)
        {
            try
            {
                // Find the selected item values using as a key the session name  
                var currentSession = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString();

                // Look up the item in the list of ftps and open the a form with its value in the 
                if (type == "FTP")
                {
                    var selected = MasterModel.ftpDict[currentSession];
                    // Update status of current session
                    MasterModel.ftpDict[currentSession].sessionLastUpdate = DateTime.Now;
                    // Update status view in the list table
                    listviewTransferList.SelectedItems[0].SubItems[4].Text = MasterModel.ftpDict[currentSession].sessionLastUpdate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (type == "SCP")
                {
                    var selected = MasterModel.SCPDict[currentSession];
                    // Update status of current session
                    MasterModel.SCPDict[currentSession].sessionLastUpdate = DateTime.Now;
                    // Update status view in the list table
                    listviewTransferList.SelectedItems[0].SubItems[4].Text = MasterModel.SCPDict[currentSession].sessionLastUpdate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (type == "S3")
                {
                    var selected = MasterModel.S3Dict[currentSession];
                    // Update status of current session
                    MasterModel.S3Dict[currentSession].sessionLastUpdate = DateTime.Now;
                    // Update status view in the list table
                    listviewTransferList.SelectedItems[0].SubItems[4].Text = MasterModel.S3Dict[currentSession].sessionLastUpdate.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            catch (Exception ex)
            {
                Formlog.WriteLine(Log.Type.ERROR, ex.Message);
            }
        }

        private void EditStatus(string type, bool status)
        {
            try
            {
                // Find the selected item values using as a key the session name  
                var currentSession = listviewTransferList.SelectedItems[0].SubItems[0].Text.ToString();

                /// Look up the item in the list of ftps and open the a form with its value in the 
                if (type == "FTP")
                {
                    // Update status of current session
                    MasterModel.ftpDict[currentSession].sessionStatus = status;
                    // Update status view in the list table
                    listviewTransferList.SelectedItems[0].SubItems[3].Text = ONorOFF(status);
                }
                else if (type == "SCP")
                {
                    // Update status of current session
                    MasterModel.SCPDict[currentSession].sessionStatus = status;
                    // Update status view in the list table
                    listviewTransferList.SelectedItems[0].SubItems[3].Text = ONorOFF(status);
                }
                else if (type == "S3")
                {
                    // Update status of current session
                    MasterModel.S3Dict[currentSession].sessionStatus = status;
                    // Update status view in the list table
                    listviewTransferList.SelectedItems[0].SubItems[3].Text = ONorOFF(status);
                }
            }
            catch (Exception ex)
            {
                Formlog.WriteLine(Log.Type.ERROR, ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResizeListViewColumns()
        {
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
        private void AddToList(string sessionName, string fileName, string type, string status, string lastUpdated)
        {
            // Create an array of containing information about session to add a new row in the list of sessions 
            string[] row = { sessionName, fileName, type, status, lastUpdated };

            ListViewItem item = new(row);

            // Add the new row to the list
            listviewTransferList.Items.Add(item);
            ResizeListViewColumns();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session_name"></param>
        /// <param name="file_name"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="lastUpdate"></param>
        private void UpdateItemList(string session_name, string file_name, string type, string status)
        {
            // Replace the selected row value by new value entered 
            listviewTransferList.SelectedItems[0].SubItems[0].Text = session_name;
            listviewTransferList.SelectedItems[0].SubItems[1].Text = file_name;
            listviewTransferList.SelectedItems[0].SubItems[2].Text = type;
            listviewTransferList.SelectedItems[0].SubItems[3].Text = status;
        }
        /// <summary>
        /// 
        /// </summary>
        private void RemoveItem(string type)
        {
            var sessionToDelete = listviewTransferList.SelectedItems[0].SubItems[0].Text;
            if (MessageBox.Show("Are you sure you want to delete *"+ sessionToDelete + "* ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // Update List view 
                listviewTransferList.Items.RemoveAt(listviewTransferList.SelectedIndices[0]);
                // Updade Dictionaries
                if (type == "FTP")
                    MasterModel.ftpDict.Remove(sessionToDelete);
                else if (type == "SCP")
                    MasterModel.SCPDict.Remove(sessionToDelete);
                else if (type == "S3")
                    MasterModel.S3Dict.Remove(sessionToDelete);
            }   
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterClickedLV(object sender, PreviewKeyDownEventArgs e)
        {
            // If a session is selected and the key "Enter" is pressed, get the item's type to search in the list else do nothing
            if (e.KeyCode == Keys.Enter && listviewTransferList.SelectedItems.Count > 0)
            {
                string searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
                EditSession(searchedItemType);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileTransferList(object sender, EventArgs e)
        {
            // Get the currently selected item in the transfer list
            string searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
            EditSession(searchedItemType);
        }

        private void ListviewTransferList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if(listviewTransferList.SelectedItems.Count > 0)
                {
                    string searchedItemType = listviewTransferList.SelectedItems[0].SubItems[2].Text.ToString();
                    RemoveItem(searchedItemType);
                }
            }
        }
        #endregion

        #region Master Switch
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (masterSwitchButton.Checked == true)
            {
                
                MasterModel.IsMasterActive = true;
                addMethodButton.Enabled = true;
                listviewTransferList.Enabled = true;
                browseButton.Enabled = true;
                selectorBox.Enabled = true;
                playButton.Enabled = true;
                stopButton.Enabled = true;
                lockButton.Enabled = true;
                saveButton.Enabled = true;
            }
            else if (masterSwitchButton.Checked == false)
            {
                MasterModel.IsMasterActive = false;
                addMethodButton.Enabled = false;
                listviewTransferList.Enabled = false;
                browseButton.Enabled = false;
                selectorBox.Enabled = false;
                playButton.Enabled = false;
                stopButton.Enabled = false;
                lockButton.Enabled = false;
                saveButton.Enabled = false;
            }
        }
        #endregion

        #region File Browser
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool FileSelectorValidator(string filepath)
        {
            if (File.Exists(filepath))
                return true;

            if (selectorBox.Text == "")
            {
                PrintFileErrorMessage("No file Selected", "Empty Selector Box");
            }

            PrintFileErrorMessage("", "");
            return false;
           
        }

        static void PrintFileErrorMessage(string message, string title)
        {
            if (message == "")
                message = "Please select a valid file before proceeding.";

            if (title == "")
                title = "No valid file selected";

            MessageBox.Show(message,title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectorBox_Enter(object sender, EventArgs e)
        {
            if (!FileSelectorValidator(MasterModel.masterFilePath))
                MessageBox.Show("Select a valid File.");
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectorBox_Validating(object sender, CancelEventArgs e)
        {
            FileSelectorValidator(MasterModel.masterFilePath);
        }


        /// <summary>
        /// 
        /// </summary>
        private void SelectFile()
        {
            if(fileSelector.ShowDialog() == DialogResult.OK)
            {
                // Check whether the file exist or not
                if (FileSelectorValidator(fileSelector.FileName))
                {
                    selectorBox.Text = fileSelector.FileName;
                    MasterModel.masterFilePath = fileSelector.FileName;
                    // Parse the file path for filename 
                    //string[] path = MasterModel.masterFilePath.Split('\\');
                    CreateFileWatcher();
                }
                else
                {
                    PrintFileErrorMessage("","");
                }
                
            }
        }

        public void CreateFileWatcher()
        {
            FileSystemWatcher watcher = new();

            watcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(MasterModel.masterFilePath),
                Filter = Path.GetFileName(MasterModel.masterFilePath),
                /* Watch for changes in LastWrite times, and the renaming of files or directories. */
                NotifyFilter = NotifyFilters.LastWrite
            };
            watcher.Changed += OnChanged;
            //watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        private void SelectorBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
               FileSelectorValidator(sender.ToString());
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            // If notified changed not equal to specified one exit function
            if (e.ChangeType != WatcherChangeTypes.Changed)
                return;
            try {
                FileInfo file = new(MasterModel.masterFilePath);
                var lastModified = file.LastWriteTime;
                // List view Item are updated one at the time, So Call BegingUpdate to ensure
                // The list is painted only once, rather than as each list item is updated
                listviewTransferList.BeginUpdate();
                // Update FTP List 
                foreach (var ftp in MasterModel.ftpDict)
                {
                    if (ftp.Value.sessionStatus)
                    {
                        // If the current FTP session is active update last time the master file was modified
                        ftp.Value.sessionLastUpdate = lastModified;
                    }
                }
                // Update SCP List
                foreach (var scp in MasterModel.SCPDict)
                {
                    if (scp.Value.sessionStatus)
                    {
                        // If the current scp session is active update last time the master file was modified
                    }
                }
                // Update S3 List 
                foreach (var s3 in MasterModel.ftpDict)
                {
                    if (s3.Value.sessionStatus)
                    {
                        // If the current s3 session is active update last time the master file was modified
                    }
                }
                listviewTransferList.EndUpdate();
            }
            catch(Exception ex)
            {
                Formlog.WriteLine(Log.Type.ERROR, ex.Message);
            }
        }
        #endregion
    }


}
