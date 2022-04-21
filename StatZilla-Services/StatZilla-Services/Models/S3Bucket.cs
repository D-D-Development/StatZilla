using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatZilla_Services.Models
{

    public class S3Bucket: Session
    {
        public bool isActive { get; set; }
        public string client { get; set; }
        public string bucketName { get; set; }
        public string destinationPath { get; set; }

        public string profileName { get; set; }
        public string secretKey { get; set; }
        public string accessKey { get; set; }

        public S3Bucket() { }
        public S3Bucket(string cL, string bucket, string profile, string path, string secret, string access)
        {
            client = cL;
            bucketName = bucket;
            profileName = profile;
            destinationPath = path;
            secretKey = secret;
            accessKey = access;

        }
    }

}
