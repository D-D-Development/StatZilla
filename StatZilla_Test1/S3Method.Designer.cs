
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
            this.clientLabel.Location = new System.Drawing.Point(61, 62);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(111, 48);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Client";
            // 
            // bucketLabel
            // 
            this.bucketLabel.AutoSize = true;
            this.bucketLabel.Location = new System.Drawing.Point(61, 172);
            this.bucketLabel.Name = "bucketLabel";
            this.bucketLabel.Size = new System.Drawing.Size(232, 48);
            this.bucketLabel.TabIndex = 1;
            this.bucketLabel.Text = "Bucket Name";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(61, 281);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(279, 48);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Destination Path";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(62, 332);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(1192, 55);
            this.pathBox.TabIndex = 3;
            // 
            // bucketBox
            // 
            this.bucketBox.Location = new System.Drawing.Point(62, 223);
            this.bucketBox.Name = "bucketBox";
            this.bucketBox.Size = new System.Drawing.Size(701, 55);
            this.bucketBox.TabIndex = 4;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(61, 114);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(702, 55);
            this.clientBox.TabIndex = 5;
            // 
            // awsProfileLabel
            // 
            this.awsProfileLabel.AutoSize = true;
            this.awsProfileLabel.Location = new System.Drawing.Point(62, 442);
            this.awsProfileLabel.Name = "awsProfileLabel";
            this.awsProfileLabel.Size = new System.Drawing.Size(227, 48);
            this.awsProfileLabel.TabIndex = 6;
            this.awsProfileLabel.Text = "Profile Name";
            // 
            // awsAccessKeyLabel
            // 
            this.awsAccessKeyLabel.AutoSize = true;
            this.awsAccessKeyLabel.Location = new System.Drawing.Point(62, 551);
            this.awsAccessKeyLabel.Name = "awsAccessKeyLabel";
            this.awsAccessKeyLabel.Size = new System.Drawing.Size(193, 48);
            this.awsAccessKeyLabel.TabIndex = 7;
            this.awsAccessKeyLabel.Text = "Access Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Secret Key";
            // 
            // profileNameBox
            // 
            this.profileNameBox.Location = new System.Drawing.Point(62, 493);
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(701, 55);
            this.profileNameBox.TabIndex = 9;
            // 
            // accessKeyBox
            // 
            this.accessKeyBox.Location = new System.Drawing.Point(62, 603);
            this.accessKeyBox.Name = "accessKeyBox";
            this.accessKeyBox.Size = new System.Drawing.Size(701, 55);
            this.accessKeyBox.TabIndex = 10;
            // 
            // secretKeyBox
            // 
            this.secretKeyBox.Location = new System.Drawing.Point(61, 713);
            this.secretKeyBox.Name = "secretKeyBox";
            this.secretKeyBox.Size = new System.Drawing.Size(702, 55);
            this.secretKeyBox.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(62, 886);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(225, 69);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // addMethod
            // 
            this.addMethod.Location = new System.Drawing.Point(979, 885);
            this.addMethod.Name = "addMethod";
            this.addMethod.Size = new System.Drawing.Size(274, 69);
            this.addMethod.TabIndex = 13;
            this.addMethod.Text = "Add Method";
            this.addMethod.UseVisualStyleBackColor = true;
            // 
            // S3Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 1052);
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