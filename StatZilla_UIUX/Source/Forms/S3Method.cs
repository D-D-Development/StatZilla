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
        public S3Bucket newS3Buckets;
        public MethodSelect backToMethodSelect;

        public S3_Protocol()
        {
            InitializeComponent();
        }      
        
        public S3_Protocol(MethodSelect prevForm)
        {
            InitializeComponent();
            backToMethodSelect = prevForm;
        }
       
        private void S3Method_Load(object sender, EventArgs e)
        {

        }

        private void awsProfileLabel_Click(object sender, EventArgs e)
        {

        }

        private void addMethod_Click(object sender, EventArgs e)
        {
            S3Bucket temp = new S3Bucket(clientBox.Text, bucketBox.Text, profileNameBox.Text, pathBox.Text, secretKeyBox.Text, accessKeyBox.Text);
            
            newS3Buckets = temp;
            // Close Both Previous Method
            backToMethodSelect.Close();
            this.Close();
        }
    }
}
