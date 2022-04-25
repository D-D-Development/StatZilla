using System;
using Topshelf;
using StatZilla_Services.Utility;
using System.IO;

namespace StatZilla_Services
{
    class Program
    {
        public static Log Log;
        public static string directory, logFilePath;
        static Stream logFileStream;
        static DateTime RunDateTime = DateTime.Now;
        static void Main(string[] args)
        {
            Program.Setup();
            Log.WriteLine(Log.Type.INFO, "StatZilla Service Setup Finished");
            var exitCode = HostFactory.Run(x =>
            {

                x.StartAutomatically(); // Start the service automatically

                x.EnableServiceRecovery(rc =>
                {
                    rc.RestartService(1); // restart the service after 1 minute
                });

                x.Service<StatZillaService>(s =>
                {

                    s.ConstructUsing(statzilla => new StatZillaService());
                    s.WhenStarted(statzilla => statzilla.Start(Log));
                    s.WhenStopped(statzilla => statzilla.Stop());

                });

                x.RunAsLocalSystem();
                x.SetServiceName("StatZillaService");
                x.SetDisplayName("StatZilla Service");
                x.SetDescription("This Service Runs along the StatZilla UI," +
                    " It monitors the UI output to manage its own behavior" +
                    " and monitors configured file for updates to begin upload process to various methods.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;

        }
        static void Setup()
        {
            // Setting up log directory
            var logPath = Path.Combine("output/log", $"{RunDateTime.ToString("yyyy-MM-dd")}");
            directory = "C:\\ProgramData\\StatZilla\\StatZilla";
            if (!Directory.Exists(Path.Combine(directory, logPath)))
            {
                Directory.CreateDirectory(Path.Combine(directory, logPath));
            }
            logFilePath = Path.Combine(Path.Combine(directory, logPath), $"{RunDateTime.ToString("yyyy-MM-dd")}-Service.log");
            logFileStream = File.Open(logFilePath, FileMode.Append, FileAccess.Write);
            Log = new Log(logFileStream, Console.OpenStandardOutput());


        }
    }
}
