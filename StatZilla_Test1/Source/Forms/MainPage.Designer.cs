
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
            this.domainHeader = new System.Windows.Forms.ColumnHeader();
            this.userHeader = new System.Windows.Forms.ColumnHeader();
            this.filename = new System.Windows.Forms.ColumnHeader();
            this.filePathHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMethodButton
            // 
            this.addMethodButton.Enabled = false;
            this.addMethodButton.Location = new System.Drawing.Point(625, 67);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(70, 42);
            this.addMethodButton.TabIndex = 0;
            this.addMethodButton.Text = "Add Method";
            this.addMethodButton.UseVisualStyleBackColor = true;
            this.addMethodButton.Click += new System.EventHandler(this.addMethod_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.Location = new System.Drawing.Point(19, 11);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(129, 36);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Tag = "App Name";
            this.lblAppName.Text = "StatZilla";
            // 
            // currentMethodsLable
            // 
            this.currentMethodsLable.AutoSize = true;
            this.currentMethodsLable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentMethodsLable.Location = new System.Drawing.Point(22, 125);
            this.currentMethodsLable.Name = "currentMethodsLable";
            this.currentMethodsLable.Size = new System.Drawing.Size(123, 18);
            this.currentMethodsLable.TabIndex = 2;
            this.currentMethodsLable.Text = "Current Methods";
            // 
            // sendMethodButton
            // 
            this.sendMethodButton.Enabled = false;
            this.sendMethodButton.Location = new System.Drawing.Point(616, 290);
            this.sendMethodButton.Name = "sendMethodButton";
            this.sendMethodButton.Size = new System.Drawing.Size(70, 42);
            this.sendMethodButton.TabIndex = 3;
            this.sendMethodButton.Text = "Send";
            this.sendMethodButton.UseVisualStyleBackColor = true;
            this.sendMethodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // masterSwitchButton
            // 
            this.masterSwitchButton.Location = new System.Drawing.Point(286, 46);
            this.masterSwitchButton.Name = "masterSwitchButton";
            this.masterSwitchButton.Size = new System.Drawing.Size(114, 16);
            this.masterSwitchButton.TabIndex = 6;
            this.masterSwitchButton.Text = "Master Switch";
            this.masterSwitchButton.UseVisualStyleBackColor = true;
            this.masterSwitchButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listviewTransferList
            // 
            this.listviewTransferList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.domainHeader,
            this.userHeader,
            this.filename,
            this.filePathHeader,
            this.statusHeader});
            this.listviewTransferList.Enabled = false;
            this.listviewTransferList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listviewTransferList.FullRowSelect = true;
            this.listviewTransferList.HideSelection = false;
            this.listviewTransferList.Location = new System.Drawing.Point(22, 153);
            this.listviewTransferList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listviewTransferList.Name = "listviewTransferList";
            this.listviewTransferList.Size = new System.Drawing.Size(589, 133);
            this.listviewTransferList.TabIndex = 11;
            this.listviewTransferList.UseCompatibleStateImageBehavior = false;
            this.listviewTransferList.View = System.Windows.Forms.View.Details;
            this.listviewTransferList.DoubleClick += new System.EventHandler(this.fileTransferList);
            // 
            // domainHeader
            // 
            this.domainHeader.Text = "Domain";
            this.domainHeader.Width = 300;
            // 
            // userHeader
            // 
            this.userHeader.Text = "User";
            this.userHeader.Width = 200;
            // 
            // filename
            // 
            this.filename.Text = "File Name";
            this.filename.Width = 200;
            // 
            // filePathHeader
            // 
            this.filePathHeader.Text = "File Path";
            this.filePathHeader.Width = 250;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Last Updated";
            this.statusHeader.Width = 300;
            // 
            // nameLabel
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "nameLabel";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "File Selector";
            // 
            // selectorBox
            // 
            this.selectorBox.Enabled = false;
            this.selectorBox.Location = new System.Drawing.Point(22, 95);
            this.selectorBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.selectorBox.Name = "selectorBox";
            this.selectorBox.Size = new System.Drawing.Size(285, 23);
            this.selectorBox.TabIndex = 13;
            this.selectorBox.Validating += new System.ComponentModel.CancelEventHandler(this.selectorBox_Validating);
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(343, 95);
            this.browseButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 19);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browserClick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.listviewTransferList);
            this.Controls.Add(this.masterSwitchButton);
            this.Controls.Add(this.sendMethodButton);
            this.Controls.Add(this.currentMethodsLable);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.addMethodButton);
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
        private System.Windows.Forms.ColumnHeader domainHeader;
        private System.Windows.Forms.ColumnHeader userHeader;
        private System.Windows.Forms.ColumnHeader filePathHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectorBox;
        private System.Windows.Forms.Button browseButton;
    }
}

