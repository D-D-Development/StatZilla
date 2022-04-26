
using Amazon;


namespace StatZilla.Models
{
    public class AWSRegionComboItem 
    {
        public int ID;
        public string Text;
    }

    public class S3Bucket: Session
    {
        public bool isActive;
        public string bucketName;
        public string destinationPath;
        public string secretKey;
        public string accessKey;
        public string regEndpoint;

        public S3Bucket() { }
        public S3Bucket( string file, string bucket,string path, string secret, string access, string region)
        {
            sessionFilename = file;
            bucketName = bucket;
            destinationPath = path;
            secretKey = secret;
            accessKey = access;
            regEndpoint = region;
        }
    }
}
