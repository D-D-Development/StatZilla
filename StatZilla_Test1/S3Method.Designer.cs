
namespace StatZilla_Test1
{
    partial class S3Method
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.clientLabel.Location = new System.Drawing.Point(40, 38);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(60, 25);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Client:";
            // 
            // bucketLabel
            // 
            this.bucketLabel.AutoSize = true;
            this.bucketLabel.Location = new System.Drawing.Point(40, 73);
            this.bucketLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bucketLabel.Name = "bucketLabel";
            this.bucketLabel.Size = new System.Drawing.Size(120, 25);
            this.bucketLabel.TabIndex = 1;
            this.bucketLabel.Text = "Bucket Name:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(40, 186);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(145, 25);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Destination Path:";
            this.pathLabel.Click += new System.EventHandler(this.pathLabel_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(189, 148);
            this.pathBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(360, 31);
            this.pathBox.TabIndex = 3;
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // bucketBox
            // 
            this.bucketBox.Location = new System.Drawing.Point(189, 70);
            this.bucketBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bucketBox.Name = "bucketBox";
            this.bucketBox.Size = new System.Drawing.Size(165, 31);
            this.bucketBox.TabIndex = 4;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(189, 35);
            this.clientBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(165, 31);
            this.clientBox.TabIndex = 5;
            // 
            // awsProfileLabel
            // 
            this.awsProfileLabel.AutoSize = true;
            this.awsProfileLabel.Location = new System.Drawing.Point(40, 151);
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
            this.awsAccessKeyLabel.Location = new System.Drawing.Point(40, 221);
            this.awsAccessKeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.awsAccessKeyLabel.Name = "awsAccessKeyLabel";
            this.awsAccessKeyLabel.Size = new System.Drawing.Size(102, 25);
            this.awsAccessKeyLabel.TabIndex = 7;
            this.awsAccessKeyLabel.Text = "Access Key:";
            this.awsAccessKeyLabel.Click += new System.EventHandler(this.awsAccessKeyLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Secret Key:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // profileNameBox
            // 
            this.profileNameBox.Location = new System.Drawing.Point(189, 183);
            this.profileNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(360, 31);
            this.profileNameBox.TabIndex = 9;
            this.profileNameBox.TextChanged += new System.EventHandler(this.profileNameBox_TextChanged);
            // 
            // accessKeyBox
            // 
            this.accessKeyBox.Location = new System.Drawing.Point(189, 218);
            this.accessKeyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accessKeyBox.Name = "accessKeyBox";
            this.accessKeyBox.Size = new System.Drawing.Size(360, 31);
            this.accessKeyBox.TabIndex = 10;
            this.accessKeyBox.TextChanged += new System.EventHandler(this.accessKeyBox_TextChanged);
            // 
            // secretKeyBox
            // 
            this.secretKeyBox.Location = new System.Drawing.Point(189, 253);
            this.secretKeyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secretKeyBox.Name = "secretKeyBox";
            this.secretKeyBox.Size = new System.Drawing.Size(360, 31);
            this.secretKeyBox.TabIndex = 11;
            this.secretKeyBox.TextChanged += new System.EventHandler(this.secretKeyBox_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(19, 371);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 36);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // addMethod
            // 
            this.addMethod.Location = new System.Drawing.Point(469, 371);
            this.addMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addMethod.Name = "addMethod";
            this.addMethod.Size = new System.Drawing.Size(137, 36);
            this.addMethod.TabIndex = 13;
            this.addMethod.Text = "Add Method";
            this.addMethod.UseVisualStyleBackColor = true;
            // 
            // S3Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 547);
            this.Controls.Add(this.addMethod);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.secretKeyBox);
            this.Controls.Add(this.accessKeyBox);
            this.Controls.Add(this.profileNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.awsAccessKeyLabel);
            this.Controls.Add(this.awsProfileLabel);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.bucketBox);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.bucketLabel);
            this.Controls.Add(this.clientLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "S3Method";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profileNameBox;
        private System.Windows.Forms.TextBox accessKeyBox;
        private System.Windows.Forms.TextBox secretKeyBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addMethod;
    }
}