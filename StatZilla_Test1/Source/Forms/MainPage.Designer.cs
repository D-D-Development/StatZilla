
namespace StatZilla.Forms
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.addMethodButton = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.currentMethodsLable = new System.Windows.Forms.Label();
            this.sendMethodButton = new System.Windows.Forms.Button();
            this.masterSwitchButton = new System.Windows.Forms.CheckBox();
            this.listviewTransferList = new System.Windows.Forms.ListView();
            this.sessionName = new System.Windows.Forms.ColumnHeader();
            this.filename = new System.Windows.Forms.ColumnHeader();
            this.methodTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.timeHistoryHeader = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMethodButton
            // 
            this.addMethodButton.BackColor = System.Drawing.Color.Gold;
            this.addMethodButton.Enabled = false;
            this.addMethodButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addMethodButton.Location = new System.Drawing.Point(64, 913);
            this.addMethodButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(250, 100);
            this.addMethodButton.TabIndex = 0;
            this.addMethodButton.Text = "Add Method";
            this.addMethodButton.UseVisualStyleBackColor = false;
            this.addMethodButton.Click += new System.EventHandler(this.addMethod_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.Location = new System.Drawing.Point(54, 35);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(391, 107);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Tag = "App Name";
            this.lblAppName.Text = "StatZilla";
            // 
            // currentMethodsLable
            // 
            this.currentMethodsLable.AutoSize = true;
            this.currentMethodsLable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentMethodsLable.Location = new System.Drawing.Point(64, 399);
            this.currentMethodsLable.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.currentMethodsLable.Name = "currentMethodsLable";
            this.currentMethodsLable.Size = new System.Drawing.Size(382, 55);
            this.currentMethodsLable.TabIndex = 2;
            this.currentMethodsLable.Text = "Current Methods";
            // 
            // sendMethodButton
            // 
            this.sendMethodButton.BackColor = System.Drawing.Color.Gold;
            this.sendMethodButton.Enabled = false;
            this.sendMethodButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sendMethodButton.Location = new System.Drawing.Point(1336, 913);
            this.sendMethodButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.sendMethodButton.Name = "sendMethodButton";
            this.sendMethodButton.Size = new System.Drawing.Size(250, 100);
            this.sendMethodButton.TabIndex = 3;
            this.sendMethodButton.Text = "Send";
            this.sendMethodButton.UseVisualStyleBackColor = false;
            this.sendMethodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // masterSwitchButton
            // 
            this.masterSwitchButton.Location = new System.Drawing.Point(600, 150);
            this.masterSwitchButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.masterSwitchButton.Name = "masterSwitchButton";
            this.masterSwitchButton.Size = new System.Drawing.Size(326, 52);
            this.masterSwitchButton.TabIndex = 6;
            this.masterSwitchButton.Text = "Master Switch";
            this.masterSwitchButton.UseVisualStyleBackColor = true;
            this.masterSwitchButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listviewTransferList
            // 
            this.listviewTransferList.AllowColumnReorder = true;
            this.listviewTransferList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sessionName,
            this.filename,
            this.methodTypeHeader,
            this.statusHeader,
            this.timeHistoryHeader});
            this.listviewTransferList.Enabled = false;
            this.listviewTransferList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listviewTransferList.FullRowSelect = true;
            this.listviewTransferList.HideSelection = false;
            this.listviewTransferList.Location = new System.Drawing.Point(64, 480);
            this.listviewTransferList.Margin = new System.Windows.Forms.Padding(6);
            this.listviewTransferList.Name = "listviewTransferList";
            this.listviewTransferList.Size = new System.Drawing.Size(1522, 417);
            this.listviewTransferList.TabIndex = 11;
            this.listviewTransferList.UseCompatibleStateImageBehavior = false;
            this.listviewTransferList.View = System.Windows.Forms.View.Details;
            this.listviewTransferList.DoubleClick += new System.EventHandler(this.fileTransferList);
            this.listviewTransferList.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.enterClickedLV);
            // 
            // sessionName
            // 
            this.sessionName.Text = "Session";
            this.sessionName.Width = 200;
            // 
            // filename
            // 
            this.filename.Text = "File Name";
            this.filename.Width = 200;
            // 
            // methodTypeHeader
            // 
            this.methodTypeHeader.Text = "Type";
            this.methodTypeHeader.Width = 2;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 150;
            // 
            // timeHistoryHeader
            // 
            this.timeHistoryHeader.Text = "Last Updated";
            this.timeHistoryHeader.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "File Selector";
            // 
            // selectorBox
            // 
            this.selectorBox.Enabled = false;
            this.selectorBox.Location = new System.Drawing.Point(64, 311);
            this.selectorBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectorBox.Name = "selectorBox";
            this.selectorBox.Size = new System.Drawing.Size(1074, 55);
            this.selectorBox.TabIndex = 13;
            this.selectorBox.Validating += new System.ComponentModel.CancelEventHandler(this.selectorBox_Validating);
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(1224, 311);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(200, 55);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browserClick);
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(1438, 399);
            this.playButton.Margin = new System.Windows.Forms.Padding(4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(70, 67);
            this.playButton.TabIndex = 15;
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(1516, 399);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(70, 67);
            this.stopButton.TabIndex = 16;
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // lockButton
            // 
            this.lockButton.Enabled = false;
            this.lockButton.Image = global::StatZilla.Properties.Resources.Lock_Lock_icon;
            this.lockButton.Location = new System.Drawing.Point(1146, 311);
            this.lockButton.Margin = new System.Windows.Forms.Padding(4);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(70, 55);
            this.lockButton.TabIndex = 18;
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lockButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1050);
            this.Controls.Add(this.lockButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.listviewTransferList);
            this.Controls.Add(this.masterSwitchButton);
            this.Controls.Add(this.sendMethodButton);
            this.Controls.Add(this.currentMethodsLable);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.addMethodButton);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "MainPage";
            this.Text = "StatZilla 1.0";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMethodButton;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label currentMethodsLable;
        private System.Windows.Forms.Button sendMethodButton;
        private System.Windows.Forms.CheckBox masterSwitchButton;
        private System.Windows.Forms.ListView listviewTransferList;
        private System.Windows.Forms.ColumnHeader sessionName;
        private System.Windows.Forms.ColumnHeader methodTypeHeader;
        private System.Windows.Forms.ColumnHeader timeHistoryHeader;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectorBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button lockButton;
    }
}

