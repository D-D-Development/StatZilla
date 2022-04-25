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
        static string jsonPath;
        static string jsonFile;
        static Stream logFileStream;
        static string directory;
        static GodModel intial_Master;
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
            Application.Run(new MainPage(Log, intial_Master));
            //logFileStream.Close();
            //System.Diagnostics.Process.Start(logFilePath);



        }
        static void ReadCurrentSettings()
        {
            GodModel tempModel = new GodModel();
            string json = "";
            string jsoninitialPath = Path.Combine(Path.Combine(directory, jsonPath), jsonFile);
            using (StreamReader r = new StreamReader(jsoninitialPath))
            {
                json = r.ReadToEnd();
                r.Close();
                r.Dispose();
            }
            if (json != "")
            {
                tempModel = Newtonsoft.Json.JsonConvert.DeserializeObject<GodModel>(json);
                
            }

            intial_Master = tempModel;
        }


        static void Setup()
        {
            // Setting up log directory
            var logPath = Path.Combine(ConfigurationManager.AppSettings["log"], $"{RunDateTime.ToString("yyyy-MM-dd")}");
            directory = System.IO.Directory.GetParent(Application.CommonAppDataPath).ToString();
            if (!Directory.Exists(Path.Combine(directory,logPath)))
            {
                Directory.CreateDirectory(Path.Combine(directory, logPath));
            }
            var logFormat = ConfigurationManager.AppSettings["log-format"];
            logFilePath = Path.Combine(Path.Combine(directory, logPath), $"{RunDateTime.ToString(logFormat)}-UI.log");
            logFileStream = File.Open(logFilePath, FileMode.Append, FileAccess.Write);
            Log = new Log(logFileStream, Console.OpenStandardOutput());

            //setting up Json directory
             jsonPath = ConfigurationManager.AppSettings["Json-Path"];
             jsonFile = ConfigurationManager.AppSettings["Json-File"];
            if (!Directory.Exists(Path.Combine(directory, jsonPath)))
            {
                Directory.CreateDirectory(Path.Combine(directory, jsonPath));
            }
            if(!File.Exists(Path.Combine(Path.Combine(directory, jsonPath), jsonFile)))
            {
                File.Create(Path.Combine(Path.Combine(directory, jsonPath), jsonFile));
            }

            ReadCurrentSettings();
        }
       
    }
}
