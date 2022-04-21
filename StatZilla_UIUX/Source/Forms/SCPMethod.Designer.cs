
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
            this.Port = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.hostDirectoryLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.addMethodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(32, 17);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(32, 52);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(32, 167);
            this.Port.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(32, 15);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port:";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(32, 98);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(35, 15);
            this.hostLabel.TabIndex = 3;
            this.hostLabel.Text = "Host:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(32, 33);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(371, 23);
            this.usernameBox.TabIndex = 4;
            // 
            // passwdBox
            // 
            this.passwdBox.Location = new System.Drawing.Point(32, 68);
            this.passwdBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.Size = new System.Drawing.Size(371, 23);
            this.passwdBox.TabIndex = 5;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(32, 113);
            this.hostBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(371, 23);
            this.hostBox.TabIndex = 6;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(32, 182);
            this.portBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(66, 23);
            this.portBox.TabIndex = 7;
            // 
            // hostDirectoryLabel
            // 
            this.hostDirectoryLabel.AutoSize = true;
            this.hostDirectoryLabel.Location = new System.Drawing.Point(32, 134);
            this.hostDirectoryLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.hostDirectoryLabel.Name = "hostDirectoryLabel";
            this.hostDirectoryLabel.Size = new System.Drawing.Size(85, 15);
            this.hostDirectoryLabel.TabIndex = 8;
            this.hostDirectoryLabel.Text = "Directory Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(32, 149);
            this.pathBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(371, 23);
            this.pathBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Location = new System.Drawing.Point(32, 229);
            this.backButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 22);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addMethodButton
            // 
            this.addMethodButton.BackColor = System.Drawing.Color.Gold;
            this.addMethodButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addMethodButton.Location = new System.Drawing.Point(275, 229);
            this.addMethodButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(126, 22);
            this.addMethodButton.TabIndex = 11;
            this.addMethodButton.Text = "Add New Session";
            this.addMethodButton.UseVisualStyleBackColor = false;
            this.addMethodButton.Click += new System.EventHandler(this.addMethodButton_Click);
            // 
            // SCP_Protocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 260);
            this.Controls.Add(this.addMethodButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.hostDirectoryLabel);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.passwdBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label hostDirectoryLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addMethodButton;
    }
}