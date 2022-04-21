namespace StatZilla.Models
{

    public class S3Bucket: Session
    {
        public bool isActive { get; set; }
        private string client { get; set; }
        private string bucketName { get; set; }
        private string destinationPath { get; set; }

        private string profileName { get; set; }
        private string secretKey { get; set; }
        private string accessKey { get; set; }

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
