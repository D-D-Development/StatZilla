﻿
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
            this.clientLabel.Location = new System.Drawing.Point(45, 25);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(60, 25);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Client:";
            // 
            // bucketLabel
            // 
            this.bucketLabel.AutoSize = true;
            this.bucketLabel.Location = new System.Drawing.Point(45, 92);
            this.bucketLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bucketLabel.Name = "bucketLabel";
            this.bucketLabel.Size = new System.Drawing.Size(120, 25);
            this.bucketLabel.TabIndex = 1;
            this.bucketLabel.Text = "Bucket Name:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(40, 221);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(145, 25);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Destination Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(45, 175);
            this.pathBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(550, 31);
            this.pathBox.TabIndex = 3;
            // 
            // bucketBox
            // 
            this.bucketBox.Location = new System.Drawing.Point(45, 115);
            this.bucketBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bucketBox.Name = "bucketBox";
            this.bucketBox.Size = new System.Drawing.Size(550, 31);
            this.bucketBox.TabIndex = 4;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(45, 52);
            this.clientBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(550, 31);
            this.clientBox.TabIndex = 5;
            // 
            // awsProfileLabel
            // 
            this.awsProfileLabel.AutoSize = true;
            this.awsProfileLabel.Location = new System.Drawing.Point(45, 148);
            this.awsProfileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.awsProfileLabel.Name = "awsProfileLabel";
            this.awsProfileLabel.Size = new System.Drawing.Size(118, 25);
            this.awsProfileLabel.TabIndex = 6;
            this.awsProfileLabel.Text = "Profile Name:";
            this.awsProfileLabel.Click += new System.EventHandler(this.awsProfileLabel_Click);
            // 
            // awsAccessKeyLabel
            // 
            this.awsAccessKeyLabel.AutoSize = true;
            this.awsAccessKeyLabel.Location = new System.Drawing.Point(45, 288);
            this.awsAccessKeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.awsAccessKeyLabel.Name = "awsAccessKeyLabel";
            this.awsAccessKeyLabel.Size = new System.Drawing.Size(102, 25);
            this.awsAccessKeyLabel.TabIndex = 7;
            this.awsAccessKeyLabel.Text = "Access Key:";
            // 
            // secretLabel
            // 
            this.secretLabel.AutoSize = true;
            this.secretLabel.Location = new System.Drawing.Point(45, 354);
            this.secretLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(97, 25);
            this.secretLabel.TabIndex = 8;
            this.secretLabel.Text = "Secret Key:";
            // 
            // profileNameBox
            // 
            this.profileNameBox.Location = new System.Drawing.Point(45, 248);
            this.profileNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(550, 31);
            this.profileNameBox.TabIndex = 9;
            // 
            // accessKeyBox
            // 
            this.accessKeyBox.Location = new System.Drawing.Point(45, 315);
            this.accessKeyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accessKeyBox.Name = "accessKeyBox";
            this.accessKeyBox.Size = new System.Drawing.Size(550, 31);
            this.accessKeyBox.TabIndex = 10;
            // 
            // secretKeyBox
            // 
            this.secretKeyBox.Location = new System.Drawing.Point(45, 381);
            this.secretKeyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secretKeyBox.Name = "secretKeyBox";
            this.secretKeyBox.Size = new System.Drawing.Size(550, 31);
            this.secretKeyBox.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Location = new System.Drawing.Point(45, 455);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 36);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // addMethod
            // 
            this.addMethod.BackColor = System.Drawing.Color.Gold;
            this.addMethod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addMethod.Location = new System.Drawing.Point(415, 455);
            this.addMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addMethod.Name = "addMethod";
            this.addMethod.Size = new System.Drawing.Size(180, 36);
            this.addMethod.TabIndex = 13;
            this.addMethod.Text = "Add New Session";
            this.addMethod.UseVisualStyleBackColor = false;
            this.addMethod.Click += new System.EventHandler(this.addMethod_Click);
            // 
            // S3_Protocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(678, 545);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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