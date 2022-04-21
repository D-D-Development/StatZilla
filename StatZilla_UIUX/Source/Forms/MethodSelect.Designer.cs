
namespace StatZilla.Forms
{
    partial class MethodSelect
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
            this.nextButton = new System.Windows.Forms.Button();
            this.DomainNicknameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Typelabel2 = new System.Windows.Forms.Label();
            this.ftpRadioButton = new System.Windows.Forms.RadioButton();
            this.s3radioButton = new System.Windows.Forms.RadioButton();
            this.scpRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Gold;
            this.nextButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nextButton.Location = new System.Drawing.Point(900, 518);
            this.nextButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(214, 75);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // DomainNicknameBox
            // 
            this.DomainNicknameBox.Location = new System.Drawing.Point(142, 157);
            this.DomainNicknameBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.DomainNicknameBox.Name = "DomainNicknameBox";
            this.DomainNicknameBox.Size = new System.Drawing.Size(968, 55);
            this.DomainNicknameBox.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(142, 100);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(243, 48);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Session Name";
            // 
            // Typelabel2
            // 
            this.Typelabel2.AutoSize = true;
            this.Typelabel2.Location = new System.Drawing.Point(142, 246);
            this.Typelabel2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Typelabel2.Name = "Typelabel2";
            this.Typelabel2.Size = new System.Drawing.Size(94, 48);
            this.Typelabel2.TabIndex = 16;
            this.Typelabel2.Text = "Type";
            // 
            // ftpRadioButton
            // 
            this.ftpRadioButton.AutoSize = true;
            this.ftpRadioButton.Location = new System.Drawing.Point(146, 328);
            this.ftpRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ftpRadioButton.Name = "ftpRadioButton";
            this.ftpRadioButton.Size = new System.Drawing.Size(121, 52);
            this.ftpRadioButton.TabIndex = 17;
            this.ftpRadioButton.TabStop = true;
            this.ftpRadioButton.Text = "FTP";
            this.ftpRadioButton.UseVisualStyleBackColor = true;
            // 
            // s3radioButton
            // 
            this.s3radioButton.AutoSize = true;
            this.s3radioButton.Location = new System.Drawing.Point(352, 328);
            this.s3radioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.s3radioButton.Name = "s3radioButton";
            this.s3radioButton.Size = new System.Drawing.Size(102, 52);
            this.s3radioButton.TabIndex = 18;
            this.s3radioButton.TabStop = true;
            this.s3radioButton.Text = "S3";
            this.s3radioButton.UseVisualStyleBackColor = true;
            // 
            // scpRadioButton
            // 
            this.scpRadioButton.AutoSize = true;
            this.scpRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scpRadioButton.Location = new System.Drawing.Point(564, 328);
            this.scpRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scpRadioButton.Name = "scpRadioButton";
            this.scpRadioButton.Size = new System.Drawing.Size(125, 52);
            this.scpRadioButton.TabIndex = 19;
            this.scpRadioButton.TabStop = true;
            this.scpRadioButton.Text = "SCP";
            this.scpRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(146, 522);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 69);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MethodSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scpRadioButton);
            this.Controls.Add(this.s3radioButton);
            this.Controls.Add(this.ftpRadioButton);
            this.Controls.Add(this.Typelabel2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.DomainNicknameBox);
            this.Controls.Add(this.nextButton);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MethodSelect";
            this.Text = "Select Method";
            this.Load += new System.EventHandler(this.MethodSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label Typelabel2;
        private System.Windows.Forms.TextBox DomainNicknameBox;
        private System.Windows.Forms.Label nameLabel;


        #endregion

        private System.Windows.Forms.RadioButton ftpRadioButton;
        private System.Windows.Forms.RadioButton s3radioButton;
        private System.Windows.Forms.RadioButton scpRadioButton;
        private System.Windows.Forms.Button button1;
    }
}