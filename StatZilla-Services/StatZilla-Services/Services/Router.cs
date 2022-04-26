using StatZilla_Services.Models;
using StatZilla_Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatZilla_Services.Services
{
    class Router
    {
        ftpSend ftpSend = new();
        S3Send S3Send = new();

        public static void Send(GodModel model, Log ServiceLog)
        {
            foreach (var ftp in model.ftpDict)
            {
                if (ftp.Value.IsActive) ftpSend.Send(ftp.Value.FtpDomain, ftp.Value.User, ftp.Value.Pass, model.masterFilePath, ftp.Value.sessionFilename, ServiceLog);
                ServiceLog.WriteLine(Log.Type.INFO, $"StatZilla Service: Uploaded Sucessfully to: {ftp.Value.sessionName}");
            }
            foreach (var s3 in model.S3Dict)
            {
                if (s3.Value.isActive)
                {
                    if(S3Send.Send(s3.Value.accessKey, s3.Value.secretKey, model.masterFilePath, s3.Value.bucketName, s3.Value.destinationPath, s3.Value.sessionFilename, s3.Value.regEndpoint, ServiceLog));
                    ServiceLog.WriteLine(Log.Type.INFO, $"StatZilla Service: Uploaded Sucessfully to: {s3.Value.sessionName}");
                }
            }
        }
    }
}
