using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatZilla.Models;

namespace StatZilla.Forms
{
    public partial class S3_Protocol : Form
    {
        public S3Bucket newS3Buckets = new();
        public MethodSelect backToMethodSelect;

        public S3_Protocol()
        {
            InitializeComponent();
        }

        // Passing the Selector Method Form instance as a parameter to the constructor of FTP Method to be able to return to the previous page
        public S3_Protocol(S3Bucket currentMethod)
        {
            newS3Buckets = currentMethod;
            InitializeComponent();
            this.DisplayMethod();
            this.ShowDialog();
        }
        // Save Method Select Form In case user return to that function for change
        public S3_Protocol(MethodSelect prevForm)
        {
            InitializeComponent();
            backToMethodSelect = prevForm;
        }
        
        private void S3Method_Load(object sender, EventArgs e)
        {

        }

        private void AddMethod_Click(object sender, EventArgs e)
        {
            ConfirmConfig();
        }

        private bool TextBox_Validator()
        {
            // Check if text box empty 
            if (filenameBox.Text == "" || bucketBox.Text == "" || pathBox.Text == "" || secretKeyBox.Text == "" || accessKeyBox.Text == "" || regionAWSDropDown.Text == "")
            {
                MessageBox.Show("Please do not leave any text box empty");
                // Log error
                return false;
            }
            return true;
        }

        private void ConfirmConfig()
        {
            if (TextBox_Validator())
            {
                // Save values in the FTP class
                SetS3Configuration(filenameBox.Text, bucketBox.Text, pathBox.Text, secretKeyBox.Text, accessKeyBox.Text, regionAWSDropDown.Text);

                // If Select Method Form open close it, if not do nothing 
                if (backToMethodSelect != null) 
                { 
                    backToMethodSelect.Close(); 
                }
                this.Close();

            }
        }
        private void SetS3Configuration(string filename, string bucket, string path, string secretkey, string accessKey, string region)
        {
            newS3Buckets.sessionFilename = filename;
            newS3Buckets.bucketName = bucket;
            newS3Buckets.destinationPath = path;
            newS3Buckets.secretKey = secretkey;
            newS3Buckets.accessKey = accessKey;
            newS3Buckets.regEndpoint = region;
        }

        public void DisplayMethod()
        {
            filenameBox.Text = newS3Buckets.sessionFilename;
            bucketBox.Text = newS3Buckets.bucketName;
            pathBox.Text = newS3Buckets.destinationPath;
            secretKeyBox.Text = newS3Buckets.secretKey;
            accessKeyBox.Text = newS3Buckets.accessKey;
            regionAWSDropDown.Text = newS3Buckets.regEndpoint;
        }

        private void S3Protocol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ConfirmConfig();
        }

        private void RegionAWSDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (backToMethodSelect != null)
            {
                this.Dispose();
                backToMethodSelect.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
