using System.Collections.Generic;

namespace StatZilla.Models
{
    public class GodModel
    {
        public bool IsMasterActive { get; set; }
        public string masterFilePath;
        public Dictionary<string,Ftp> ftpDict;
        public Dictionary<string, Scp> SCPDict;
        public Dictionary<string, S3Bucket> S3Dict;
      
        public GodModel()
        {
            ftpDict = new Dictionary<string, Ftp>();
            SCPDict = new Dictionary<string, Scp>();
            S3Dict = new Dictionary<string, S3Bucket>();
        }
    }
}
