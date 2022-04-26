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
        ftpSend ftpSend;
        S3Send S3Send;

        public void Send(GodModel model, Log ServiceLog)
        {
            foreach (var ftp in model.ftpDict)
            {
                if (ftp.Value.isActive) ftpSend.Send(ftp.Value.ftpDomain, ftp.Value.user, ftp.Value.pass, model.masterFilePath, ftp.Value.sessionFilename, ServiceLog);
            }
            foreach (var s3 in model.S3Dict)
            {
                if (s3.Value.isActive) S3Send.Send(s3.Value.accessKey, s3.Value.secretKey, model.masterFilePath, s3.Value.bucketName, s3.Value.destinationPath, s3.Value.sessionFilename, ServiceLog);
            }
        }
    }
}
