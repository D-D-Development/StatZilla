using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using StatZilla_Services.Utility;

namespace StatZilla_Services.Services
{
    public class ftpSend
    {

        public static int Send(string host, string user, string pass, string filepath, string filename, Log ServiceLog)
        {
            var connectionInfo = new ConnectionInfo(host, user,  new PasswordAuthenticationMethod(user, pass));

            //filename = filename + ".txt";
            // Upload File
            using (var sftp = new SftpClient(connectionInfo))
            {

                sftp.Connect();

                using (var uplfileStream = System.IO.File.OpenRead(filepath))
                {
                    sftp.UploadFile(uplfileStream, filename, true);
                }
                sftp.Disconnect();
            }
            return 0;
        }



    }
}
