using System.Collections.Generic;



namespace StatZilla_Services.Models
{
    public class GodModel
    {
        public bool IsMasterActive { get; set; }
        public string masterFilePath;
        public Dictionary<string,Ftp> ftpDict = new Dictionary<string, Ftp>();
        public Dictionary<string, Scp> SCPDict = new Dictionary<string, Scp>();
        public Dictionary<string, S3Bucket> S3Dict = new Dictionary<string, S3Bucket>();
        public Dictionary<string, ObjStore> ObjDict = new Dictionary<string, ObjStore>();
      

        public GodModel()
        {
          
        }
    }
}
