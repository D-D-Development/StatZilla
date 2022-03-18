
namespace StatZilla_Test1
{
    partial class SCPMethod
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
            this.usernameLabel.Location = new System.Drawing.Point(85, 43);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(180, 48);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(85, 152);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(168, 48);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(85, 536);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(85, 48);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(85, 318);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(94, 48);
            this.hostLabel.TabIndex = 3;
            this.hostLabel.Text = "Host";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(85, 94);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(507, 55);
            this.usernameBox.TabIndex = 4;
            // 
            // passwdBox
            // 
            this.passwdBox.Location = new System.Drawing.Point(85, 203);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.Size = new System.Drawing.Size(507, 55);
            this.passwdBox.TabIndex = 5;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(85, 369);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(1045, 55);
            this.hostBox.TabIndex = 6;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(85, 587);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(180, 55);
            this.portBox.TabIndex = 7;
            // 
            // hostDirectoryLabel
            // 
            this.hostDirectoryLabel.AutoSize = true;
            this.hostDirectoryLabel.Location = new System.Drawing.Point(85, 427);
            this.hostDirectoryLabel.Name = "hostDirectoryLabel";
            this.hostDirectoryLabel.Size = new System.Drawing.Size(245, 48);
            this.hostDirectoryLabel.TabIndex = 8;
            this.hostDirectoryLabel.Text = "Directory Path";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(85, 478);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(1045, 55);
            this.pathBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(85, 703);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(225, 69);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addMethodButton
            // 
            this.addMethodButton.Location = new System.Drawing.Point(883, 703);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(246, 69);
            this.addMethodButton.TabIndex = 11;
            this.addMethodButton.Text = "Add Method";
            this.addMethodButton.UseVisualStyleBackColor = true;
            this.addMethodButton.Click += new System.EventHandler(this.addMethodButton_Click);
            // 
            // SCPMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 834);
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
            this.Name = "SCPMethod";
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