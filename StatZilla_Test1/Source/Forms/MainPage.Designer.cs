
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
            this.SuspendLayout();
            // 
            // addMethodButton
            // 
            this.addMethodButton.Enabled = false;
            this.addMethodButton.Location = new System.Drawing.Point(939, 103);
            this.addMethodButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(100, 70);
            this.addMethodButton.TabIndex = 0;
            this.addMethodButton.Text = "Add Method";
            this.addMethodButton.UseVisualStyleBackColor = true;
            this.addMethodButton.Click += new System.EventHandler(this.addMethod_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.Location = new System.Drawing.Point(27, 18);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(195, 55);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Tag = "App Name";
            this.lblAppName.Text = "StatZilla";
            // 
            // currentMethodsLable
            // 
            this.currentMethodsLable.AutoSize = true;
            this.currentMethodsLable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentMethodsLable.Location = new System.Drawing.Point(32, 208);
            this.currentMethodsLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentMethodsLable.Name = "currentMethodsLable";
            this.currentMethodsLable.Size = new System.Drawing.Size(192, 27);
            this.currentMethodsLable.TabIndex = 2;
            this.currentMethodsLable.Text = "Current Methods";
            // 
            // sendMethodButton
            // 
            this.sendMethodButton.Enabled = false;
            this.sendMethodButton.Location = new System.Drawing.Point(939, 463);
            this.sendMethodButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendMethodButton.Name = "sendMethodButton";
            this.sendMethodButton.Size = new System.Drawing.Size(100, 70);
            this.sendMethodButton.TabIndex = 3;
            this.sendMethodButton.Text = "Send";
            this.sendMethodButton.UseVisualStyleBackColor = true;
            this.sendMethodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // masterSwitchButton
            // 
            this.masterSwitchButton.Location = new System.Drawing.Point(408, 77);
            this.masterSwitchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.masterSwitchButton.Name = "masterSwitchButton";
            this.masterSwitchButton.Size = new System.Drawing.Size(163, 27);
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
            this.listviewTransferList.Location = new System.Drawing.Point(32, 250);
            this.listviewTransferList.Name = "listviewTransferList";
            this.listviewTransferList.Size = new System.Drawing.Size(802, 219);
            this.listviewTransferList.TabIndex = 11;
            this.listviewTransferList.UseCompatibleStateImageBehavior = false;
            this.listviewTransferList.View = System.Windows.Forms.View.Details;
            this.listviewTransferList.DoubleClick += new System.EventHandler(this.fileTransferList);
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
            this.methodTypeHeader.Width = 100;
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
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "File Selector";
            // 
            // selectorBox
            // 
            this.selectorBox.Enabled = false;
            this.selectorBox.Location = new System.Drawing.Point(32, 162);
            this.selectorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectorBox.Name = "selectorBox";
            this.selectorBox.Size = new System.Drawing.Size(539, 31);
            this.selectorBox.TabIndex = 13;
            this.selectorBox.Validating += new System.ComponentModel.CancelEventHandler(this.selectorBox_Validating);
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(613, 158);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 35);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browserClick);
            // 
            // playButton
            // 
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(760, 158);
            this.playButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(35, 35);
            this.playButton.TabIndex = 15;
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(799, 158);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(35, 35);
            this.stopButton.TabIndex = 16;
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 547);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

