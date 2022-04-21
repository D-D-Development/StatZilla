using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
namespace StatZilla.Services
{
    public class ftpSend
    {
        private static string host;
        private static string user;
        private static string pass;

        public ftpSend(string getHost, string getUser, string getPass)
        {
            host = getHost;
            user = getUser;
            pass = getPass;
        }

        public int Send()
        {
            var connectionInfo = new ConnectionInfo(host, user, new PasswordAuthenticationMethod(user, pass));

            //filename = filename + ".txt";
            // Upload File
            using (var sftp = new SftpClient(connectionInfo))
            {

                sftp.Connect();
                
                using (var uplfileStream = System.IO.File.OpenRead("ftptest.txt"))
                {
                    sftp.UploadFile(uplfileStream, "ftptest.txt", true);
                }
                sftp.Disconnect();
            }
            return 0;
        }



    }
}
