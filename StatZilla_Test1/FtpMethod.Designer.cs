
namespace StatZilla_Test1
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pswdLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.hostPathLabel = new System.Windows.Forms.Label();
            this.hostDestinationPath = new System.Windows.Forms.TextBox();
            this.addNewMethodButton = new System.Windows.Forms.Button();
            this.returnToSelectMethodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(105, 65);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(180, 48);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // pswdLabel
            // 
            this.pswdLabel.AutoSize = true;
            this.pswdLabel.Location = new System.Drawing.Point(105, 241);
            this.pswdLabel.Name = "pswdLabel";
            this.pswdLabel.Size = new System.Drawing.Size(168, 48);
            this.pswdLabel.TabIndex = 1;
            this.pswdLabel.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(110, 120);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PlaceholderText = "enter your user name ";
            this.usernameBox.Size = new System.Drawing.Size(650, 55);
            this.usernameBox.TabIndex = 2;
            // 
            // passwdBox
            // 
            this.passwdBox.Location = new System.Drawing.Point(110, 300);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.PasswordChar = '*';
            this.passwdBox.PlaceholderText = "enter your password";
            this.passwdBox.Size = new System.Drawing.Size(650, 55);
            this.passwdBox.TabIndex = 3;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(110, 510);
            this.hostBox.Name = "hostBox";
            this.hostBox.PlaceholderText = " enter website’s URL or IP address here";
            this.hostBox.Size = new System.Drawing.Size(650, 55);
            this.hostBox.TabIndex = 4;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(106, 452);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(94, 48);
            this.hostLabel.TabIndex = 5;
            this.hostLabel.Text = "Host";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(9, 984);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // hostPathLabel
            // 
            this.hostPathLabel.AutoSize = true;
            this.hostPathLabel.Location = new System.Drawing.Point(105, 593);
            this.hostPathLabel.Name = "hostPathLabel";
            this.hostPathLabel.Size = new System.Drawing.Size(89, 48);
            this.hostPathLabel.TabIndex = 7;
            this.hostPathLabel.Text = "Path";
            // 
            // hostDestinationPath
            // 
            this.hostDestinationPath.Location = new System.Drawing.Point(110, 653);
            this.hostDestinationPath.Name = "hostDestinationPath";
            this.hostDestinationPath.PlaceholderText = "destination path directory (e.g: /remote/directory)";
            this.hostDestinationPath.Size = new System.Drawing.Size(1274, 55);
            this.hostDestinationPath.TabIndex = 8;
            // 
            // addNewMethodButton
            // 
            this.addNewMethodButton.Location = new System.Drawing.Point(1078, 794);
            this.addNewMethodButton.Name = "addNewMethodButton";
            this.addNewMethodButton.Size = new System.Drawing.Size(309, 69);
            this.addNewMethodButton.TabIndex = 9;
            this.addNewMethodButton.Text = "Add Method";
            this.addNewMethodButton.UseVisualStyleBackColor = true;
            this.addNewMethodButton.Click += new System.EventHandler(this.addNewMethodButton_Click);
            // 
            // returnToSelectMethodButton
            // 
            this.returnToSelectMethodButton.Location = new System.Drawing.Point(105, 794);
            this.returnToSelectMethodButton.Name = "returnToSelectMethodButton";
            this.returnToSelectMethodButton.Size = new System.Drawing.Size(225, 69);
            this.returnToSelectMethodButton.TabIndex = 10;
            this.returnToSelectMethodButton.Text = "Back";
            this.returnToSelectMethodButton.UseVisualStyleBackColor = true;
            // 
            // FtpProtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 984);
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
            this.Name = "FtpProtocol";
            this.Text = "FTP Protocol";
            this.Load += new System.EventHandler(this.FtpProtocol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label pswdLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label hostPathLabel;
        private System.Windows.Forms.TextBox hostDestinationPath;
        private System.Windows.Forms.Button addNewMethodButton;
        private System.Windows.Forms.Button returnToSelectMethodButton;
    }
}