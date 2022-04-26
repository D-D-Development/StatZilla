
namespace StatZilla.Forms
{
    partial class FtpProtocol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FtpProtocol));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pswdLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.hostPathLabel = new System.Windows.Forms.Label();
            this.hostDestinationPath = new System.Windows.Forms.TextBox();
            this.addNewMethodButton = new System.Windows.Forms.Button();
            this.returnToSelectMethodButton = new System.Windows.Forms.Button();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(32, 64);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // pswdLabel
            // 
            this.pswdLabel.AutoSize = true;
            this.pswdLabel.Location = new System.Drawing.Point(32, 106);
            this.pswdLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pswdLabel.Name = "pswdLabel";
            this.pswdLabel.Size = new System.Drawing.Size(60, 15);
            this.pswdLabel.TabIndex = 1;
            this.pswdLabel.Text = "Password:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(32, 80);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(456, 23);
            this.usernameBox.TabIndex = 2;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(32, 169);
            this.hostBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(456, 23);
            this.hostBox.TabIndex = 4;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(32, 152);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(35, 15);
            this.hostLabel.TabIndex = 5;
            this.hostLabel.Text = "Host:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 307);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // hostPathLabel
            // 
            this.hostPathLabel.AutoSize = true;
            this.hostPathLabel.Location = new System.Drawing.Point(32, 188);
            this.hostPathLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.hostPathLabel.Name = "hostPathLabel";
            this.hostPathLabel.Size = new System.Drawing.Size(34, 15);
            this.hostPathLabel.TabIndex = 7;
            this.hostPathLabel.Text = "Path:";
            // 
            // hostDestinationPath
            // 
            this.hostDestinationPath.Location = new System.Drawing.Point(32, 205);
            this.hostDestinationPath.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.hostDestinationPath.Name = "hostDestinationPath";
            this.hostDestinationPath.Size = new System.Drawing.Size(456, 23);
            this.hostDestinationPath.TabIndex = 8;
            // 
            // addNewMethodButton
            // 
            this.addNewMethodButton.BackColor = System.Drawing.Color.Gold;
            this.addNewMethodButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addNewMethodButton.Location = new System.Drawing.Point(360, 255);
            this.addNewMethodButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addNewMethodButton.Name = "addNewMethodButton";
            this.addNewMethodButton.Size = new System.Drawing.Size(126, 22);
            this.addNewMethodButton.TabIndex = 9;
            this.addNewMethodButton.Text = "Add New Session";
            this.addNewMethodButton.UseVisualStyleBackColor = false;
            this.addNewMethodButton.Click += new System.EventHandler(this.AddNewMethodButton_Click);
            // 
            // returnToSelectMethodButton
            // 
            this.returnToSelectMethodButton.BackColor = System.Drawing.Color.Gold;
            this.returnToSelectMethodButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.returnToSelectMethodButton.Location = new System.Drawing.Point(32, 255);
            this.returnToSelectMethodButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.returnToSelectMethodButton.Name = "returnToSelectMethodButton";
            this.returnToSelectMethodButton.Size = new System.Drawing.Size(88, 22);
            this.returnToSelectMethodButton.TabIndex = 10;
            this.returnToSelectMethodButton.Text = "Back";
            this.returnToSelectMethodButton.UseVisualStyleBackColor = false;
            this.returnToSelectMethodButton.Click += new System.EventHandler(this.ReturnToSelectMethodButton_Click);
            // 
            // passwdBox
            // 
            this.passwdBox.Location = new System.Drawing.Point(32, 122);
            this.passwdBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.PasswordChar = '*';
            this.passwdBox.Size = new System.Drawing.Size(456, 23);
            this.passwdBox.TabIndex = 3;
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(32, 44);
            this.filenameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(456, 23);
            this.filenameBox.TabIndex = 11;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(32, 28);
            this.filenameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(58, 15);
            this.filenameLabel.TabIndex = 12;
            this.filenameLabel.Text = "Filename:";
            // 
            // FtpProtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 307);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.returnToSelectMethodButton);
            this.Controls.Add(this.addNewMethodButton);
            this.Controls.Add(this.hostDestinationPath);
            this.Controls.Add(this.hostPathLabel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.passwdBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.pswdLabel);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FtpProtocol";
            this.Text = "FTP Protocol";
            this.Load += new System.EventHandler(this.FtpProtocol_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FtpProtocol_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label pswdLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label hostPathLabel;
        private System.Windows.Forms.TextBox hostDestinationPath;
        private System.Windows.Forms.Button addNewMethodButton;
        private System.Windows.Forms.Button returnToSelectMethodButton;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Label filenameLabel;
    }
}