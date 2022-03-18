using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatZilla.Models;
using StatZilla.Utility;
using StatZilla.Forms;
namespace StatZilla
{
    static class Program
    {
        // This is a test Comment
        public static Log Log;
        static string logFilePath;
        static Stream logFileStream;
        static DateTime RunDateTime = DateTime.Now;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.Setup();
            Log.WriteLine(Log.Type.INFO, "Program Setup Complete");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage(Log));
            //logFileStream.Close();
            //System.Diagnostics.Process.Start(logFilePath);



        }


        static void Setup()
        {
            // Setting up log directory
            var logPath = ConfigurationManager.AppSettings["log"];
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            var logFormat = ConfigurationManager.AppSettings["log-format"];
            logFilePath = Path.Combine(logPath, $"{RunDateTime.ToString(logFormat)}.log");
            logFileStream = File.Open(logFilePath, FileMode.Append, FileAccess.Write);
            Log = new Log(logFileStream, Console.OpenStandardOutput());



        }
       
    }
}
