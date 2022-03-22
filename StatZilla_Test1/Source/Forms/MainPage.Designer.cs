
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
            this.addMethodButton = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.currentMethodsLable = new System.Windows.Forms.Label();
            this.sendMethodButton = new System.Windows.Forms.Button();
            this.masterSwitchButton = new System.Windows.Forms.CheckBox();
            this.listviewTransferList = new System.Windows.Forms.ListView();
            this.sessionName = new System.Windows.Forms.ColumnHeader();
            this.filename = new System.Windows.Forms.ColumnHeader();
            this.methodTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.timeHistoryHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMethodButton
            // 
            this.addMethodButton.Enabled = false;
            this.addMethodButton.Location = new System.Drawing.Point(1786, 214);
            this.addMethodButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(200, 134);
            this.addMethodButton.TabIndex = 0;
            this.addMethodButton.Text = "Add Method";
            this.addMethodButton.UseVisualStyleBackColor = true;
            this.addMethodButton.Click += new System.EventHandler(this.addMethod_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.Location = new System.Drawing.Point(54, 35);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
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
            this.currentMethodsLable.Location = new System.Drawing.Point(63, 400);
            this.currentMethodsLable.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.currentMethodsLable.Name = "currentMethodsLable";
            this.currentMethodsLable.Size = new System.Drawing.Size(382, 55);
            this.currentMethodsLable.TabIndex = 2;
            this.currentMethodsLable.Text = "Current Methods";
            // 
            // sendMethodButton
            // 
            this.sendMethodButton.Enabled = false;
            this.sendMethodButton.Location = new System.Drawing.Point(1760, 928);
            this.sendMethodButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.sendMethodButton.Name = "sendMethodButton";
            this.sendMethodButton.Size = new System.Drawing.Size(200, 134);
            this.sendMethodButton.TabIndex = 3;
            this.sendMethodButton.Text = "Send";
            this.sendMethodButton.UseVisualStyleBackColor = true;
            this.sendMethodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // masterSwitchButton
            // 
            this.masterSwitchButton.Location = new System.Drawing.Point(817, 147);
            this.masterSwitchButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.masterSwitchButton.Name = "masterSwitchButton";
            this.masterSwitchButton.Size = new System.Drawing.Size(326, 51);
            this.masterSwitchButton.TabIndex = 6;
            this.masterSwitchButton.Text = "Master Switch";
            this.masterSwitchButton.UseVisualStyleBackColor = true;
            this.masterSwitchButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listviewTransferList
            // 
            this.listviewTransferList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sessionName,
            this.filename,
            this.methodTypeHeader,
            this.timeHistoryHeader,
            this.statusHeader});
            this.listviewTransferList.Enabled = false;
            this.listviewTransferList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listviewTransferList.FullRowSelect = true;
            this.listviewTransferList.HideSelection = false;
            this.listviewTransferList.Location = new System.Drawing.Point(63, 490);
            this.listviewTransferList.Margin = new System.Windows.Forms.Padding(6);
            this.listviewTransferList.Name = "listviewTransferList";
            this.listviewTransferList.Size = new System.Drawing.Size(1675, 417);
            this.listviewTransferList.TabIndex = 11;
            this.listviewTransferList.UseCompatibleStateImageBehavior = false;
            this.listviewTransferList.View = System.Windows.Forms.View.Details;
            this.listviewTransferList.DoubleClick += new System.EventHandler(this.fileTransferList);
            // 
            // sessionName
            // 
            this.sessionName.Text = "Session";
            this.sessionName.Width = 300;
            // 
            // filename
            // 
            this.filename.DisplayIndex = 2;
            this.filename.Text = "File Name";
            this.filename.Width = 300;
            // 
            // methodTypeHeader
            // 
            this.methodTypeHeader.DisplayIndex = 1;
            this.methodTypeHeader.Text = "Type";
            this.methodTypeHeader.Width = 300;
            // 
            // timeHistoryHeader
            // 
            this.timeHistoryHeader.Text = "Last Updated";
            this.timeHistoryHeader.Width = 300;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "File Selector";
            // 
            // selectorBox
            // 
            this.selectorBox.Enabled = false;
            this.selectorBox.Location = new System.Drawing.Point(63, 304);
            this.selectorBox.Name = "selectorBox";
            this.selectorBox.Size = new System.Drawing.Size(807, 55);
            this.selectorBox.TabIndex = 13;
            this.selectorBox.Validating += new System.ComponentModel.CancelEventHandler(this.selectorBox_Validating);
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(980, 304);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(214, 61);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browserClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1562, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1658, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2103, 1066);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.listviewTransferList);
            this.Controls.Add(this.masterSwitchButton);
            this.Controls.Add(this.sendMethodButton);
            this.Controls.Add(this.currentMethodsLable);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.addMethodButton);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

