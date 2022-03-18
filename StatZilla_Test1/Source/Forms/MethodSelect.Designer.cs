
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
            this.FileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DomainNicknameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Typelabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(372, 164);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // FileTypeComboBox
            // 
            this.FileTypeComboBox.FormattingEnabled = true;
            this.FileTypeComboBox.Items.AddRange(new object[] {
            "FTP",
            "S3",
            "SCP",
            "OBJ"});
            this.FileTypeComboBox.Location = new System.Drawing.Point(102, 105);
            this.FileTypeComboBox.Name = "FileTypeComboBox";
            this.FileTypeComboBox.Size = new System.Drawing.Size(283, 23);
            this.FileTypeComboBox.TabIndex = 13;
            this.FileTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // DomainNicknameBox
            // 
            this.DomainNicknameBox.Location = new System.Drawing.Point(102, 76);
            this.DomainNicknameBox.Name = "DomainNicknameBox";
            this.DomainNicknameBox.Size = new System.Drawing.Size(283, 23);
            this.DomainNicknameBox.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(31, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // Typelabel2
            // 
            this.Typelabel2.AutoSize = true;
            this.Typelabel2.Location = new System.Drawing.Point(31, 108);
            this.Typelabel2.Name = "Typelabel2";
            this.Typelabel2.Size = new System.Drawing.Size(31, 15);
            this.Typelabel2.TabIndex = 16;
            this.Typelabel2.Text = "Type";
            // 
            // MethodSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 210);
            this.Controls.Add(this.Typelabel2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.DomainNicknameBox);
            this.Controls.Add(this.FileTypeComboBox);
            this.Controls.Add(this.nextButton);
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
        private System.Windows.Forms.ComboBox FileTypeComboBox;
        private System.Windows.Forms.TextBox DomainNicknameBox;
        private System.Windows.Forms.Label nameLabel;
        

        #endregion
    }
}