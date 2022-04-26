
namespace StatZilla.Forms
{
    partial class SCP_Protocol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCP_Protocol));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.hostDirectoryLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.addMethodButton = new System.Windows.Forms.Button();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(92, 132);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(188, 48);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(92, 252);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(176, 48);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(92, 378);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(102, 48);
            this.hostLabel.TabIndex = 3;
            this.hostLabel.Text = "Host:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(92, 188);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(1052, 55);
            this.usernameBox.TabIndex = 4;
            // 
            // passwdBox
            // 
            this.passwdBox.Location = new System.Drawing.Point(92, 303);
            this.passwdBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.Size = new System.Drawing.Size(1052, 55);
            this.passwdBox.TabIndex = 5;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(92, 426);
            this.hostBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(1052, 55);
            this.hostBox.TabIndex = 6;
            // 
            // hostDirectoryLabel
            // 
            this.hostDirectoryLabel.AutoSize = true;
            this.hostDirectoryLabel.Location = new System.Drawing.Point(92, 493);
            this.hostDirectoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostDirectoryLabel.Name = "hostDirectoryLabel";
            this.hostDirectoryLabel.Size = new System.Drawing.Size(253, 48);
            this.hostDirectoryLabel.TabIndex = 8;
            this.hostDirectoryLabel.Text = "Directory Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(92, 541);
            this.pathBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(1052, 55);
            this.pathBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Location = new System.Drawing.Point(92, 733);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(252, 71);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addMethodButton
            // 
            this.addMethodButton.BackColor = System.Drawing.Color.Gold;
            this.addMethodButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addMethodButton.Location = new System.Drawing.Point(786, 733);
            this.addMethodButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(360, 71);
            this.addMethodButton.TabIndex = 11;
            this.addMethodButton.Text = "Add New Session";
            this.addMethodButton.UseVisualStyleBackColor = false;
            this.addMethodButton.Click += new System.EventHandler(this.AddMethodButton_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(92, 17);
            this.filenameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(171, 48);
            this.filenameLabel.TabIndex = 12;
            this.filenameLabel.Text = "Filename:";
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(92, 69);
            this.filenameBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(1052, 55);
            this.filenameBox.TabIndex = 13;
            // 
            // SCP_Protocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 831);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.addMethodButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.hostDirectoryLabel);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.passwdBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SCP_Protocol";
            this.Text = "SCP Protocol";
            this.Load += new System.EventHandler(this.SCPMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label hostDirectoryLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addMethodButton;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.TextBox filenameBox;
    }
}