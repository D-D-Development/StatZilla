
namespace StatZilla.Forms
{
    partial class S3_Protocol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S3_Protocol));
            this.clientLabel = new System.Windows.Forms.Label();
            this.bucketLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.bucketBox = new System.Windows.Forms.TextBox();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.awsProfileLabel = new System.Windows.Forms.Label();
            this.awsAccessKeyLabel = new System.Windows.Forms.Label();
            this.secretLabel = new System.Windows.Forms.Label();
            this.profileNameBox = new System.Windows.Forms.TextBox();
            this.accessKeyBox = new System.Windows.Forms.TextBox();
            this.secretKeyBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.addMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(32, 15);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(41, 15);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Client:";
            // 
            // bucketLabel
            // 
            this.bucketLabel.AutoSize = true;
            this.bucketLabel.Location = new System.Drawing.Point(32, 55);
            this.bucketLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.bucketLabel.Name = "bucketLabel";
            this.bucketLabel.Size = new System.Drawing.Size(81, 15);
            this.bucketLabel.TabIndex = 1;
            this.bucketLabel.Text = "Bucket Name:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(28, 133);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(97, 15);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Destination Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(32, 105);
            this.pathBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(386, 23);
            this.pathBox.TabIndex = 3;
            // 
            // bucketBox
            // 
            this.bucketBox.Location = new System.Drawing.Point(32, 69);
            this.bucketBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.bucketBox.Name = "bucketBox";
            this.bucketBox.Size = new System.Drawing.Size(386, 23);
            this.bucketBox.TabIndex = 4;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(32, 31);
            this.clientBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(386, 23);
            this.clientBox.TabIndex = 5;
            // 
            // awsProfileLabel
            // 
            this.awsProfileLabel.AutoSize = true;
            this.awsProfileLabel.Location = new System.Drawing.Point(32, 89);
            this.awsProfileLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.awsProfileLabel.Name = "awsProfileLabel";
            this.awsProfileLabel.Size = new System.Drawing.Size(79, 15);
            this.awsProfileLabel.TabIndex = 6;
            this.awsProfileLabel.Text = "Profile Name:";
            this.awsProfileLabel.Click += new System.EventHandler(this.awsProfileLabel_Click);
            // 
            // awsAccessKeyLabel
            // 
            this.awsAccessKeyLabel.AutoSize = true;
            this.awsAccessKeyLabel.Location = new System.Drawing.Point(32, 173);
            this.awsAccessKeyLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.awsAccessKeyLabel.Name = "awsAccessKeyLabel";
            this.awsAccessKeyLabel.Size = new System.Drawing.Size(68, 15);
            this.awsAccessKeyLabel.TabIndex = 7;
            this.awsAccessKeyLabel.Text = "Access Key:";
            // 
            // secretLabel
            // 
            this.secretLabel.AutoSize = true;
            this.secretLabel.Location = new System.Drawing.Point(32, 212);
            this.secretLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(64, 15);
            this.secretLabel.TabIndex = 8;
            this.secretLabel.Text = "Secret Key:";
            // 
            // profileNameBox
            // 
            this.profileNameBox.Location = new System.Drawing.Point(32, 149);
            this.profileNameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(386, 23);
            this.profileNameBox.TabIndex = 9;
            // 
            // accessKeyBox
            // 
            this.accessKeyBox.Location = new System.Drawing.Point(32, 189);
            this.accessKeyBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.accessKeyBox.Name = "accessKeyBox";
            this.accessKeyBox.Size = new System.Drawing.Size(386, 23);
            this.accessKeyBox.TabIndex = 10;
            // 
            // secretKeyBox
            // 
            this.secretKeyBox.Location = new System.Drawing.Point(32, 229);
            this.secretKeyBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.secretKeyBox.Name = "secretKeyBox";
            this.secretKeyBox.Size = new System.Drawing.Size(386, 23);
            this.secretKeyBox.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Location = new System.Drawing.Point(32, 273);
            this.backButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(78, 22);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // addMethod
            // 
            this.addMethod.BackColor = System.Drawing.Color.Gold;
            this.addMethod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addMethod.Location = new System.Drawing.Point(290, 273);
            this.addMethod.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addMethod.Name = "addMethod";
            this.addMethod.Size = new System.Drawing.Size(126, 22);
            this.addMethod.TabIndex = 13;
            this.addMethod.Text = "Add New Session";
            this.addMethod.UseVisualStyleBackColor = false;
            this.addMethod.Click += new System.EventHandler(this.addMethod_Click);
            // 
            // S3_Protocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(475, 327);
            this.Controls.Add(this.addMethod);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.secretKeyBox);
            this.Controls.Add(this.accessKeyBox);
            this.Controls.Add(this.profileNameBox);
            this.Controls.Add(this.secretLabel);
            this.Controls.Add(this.awsAccessKeyLabel);
            this.Controls.Add(this.awsProfileLabel);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.bucketBox);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.bucketLabel);
            this.Controls.Add(this.clientLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "S3_Protocol";
            this.Text = "S3 Method";
            this.Load += new System.EventHandler(this.S3Method_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label bucketLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox bucketBox;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.Label awsProfileLabel;
        private System.Windows.Forms.Label awsAccessKeyLabel;
        private System.Windows.Forms.Label secretLabel;
        private System.Windows.Forms.TextBox profileNameBox;
        private System.Windows.Forms.TextBox accessKeyBox;
        private System.Windows.Forms.TextBox secretKeyBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addMethod;
    }
}