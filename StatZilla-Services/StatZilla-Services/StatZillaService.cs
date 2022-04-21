using StatZilla_Services.Models;
using StatZilla_Services.Services;
using System;
using System.IO;


namespace StatZilla_Services
{
    public class StatZillaService
    {
        Router uploader;
        GodModel master;
        string jsonpath = $"output\\json";
        string masterfilepath = "";
        FileSystemWatcher watcherJson;
        FileSystemWatcher watcherF2S; // File 2 Send;


        public StatZillaService()
        {
            if (File.Exists(jsonpath+ "\\currsetting.json"))
            {
                master = readJson();
            }

            else
            {
                Directory.CreateDirectory(jsonpath);
                File.Create(jsonpath+ "\\currsetting.json");
            }
            
        }

        public void Start()
        {
            WatchAndUpdate_JSON();
            watcherJson.EnableRaisingEvents = true;
        }
        public void Stop()
        {

        }

        private GodModel readJson()
        {
            GodModel tempModel = new GodModel();
            string json = "";
            using (StreamReader r = new StreamReader(jsonpath + "\\currsetting.json"))
            {
                json = r.ReadToEnd();
                r.Close();
                r.Dispose();
            }
           if(json != "")
            {
                tempModel = Newtonsoft.Json.JsonConvert.DeserializeObject<GodModel>(json);
                masterfilepath = tempModel.masterFilePath;
            }

            return tempModel;



        }

        private void WatchAndUpdate_JSON()
        {
            watcherJson = new FileSystemWatcher(Directory.GetCurrentDirectory() + "\\" + jsonpath);
            watcherJson.NotifyFilter = NotifyFilters.LastWrite;
            watcherJson.Changed += OnChanged_Json;
            watcherJson.Error += OnError;
            watcherJson.Filter = "*.json";
        }
        private void WatchAndSend_F2S()
        {
            watcherF2S = new FileSystemWatcher();
            watcherF2S.Path = Path.GetDirectoryName(masterfilepath);
            watcherF2S.Filter = Path.GetFileName(masterfilepath);
            watcherF2S.NotifyFilter = NotifyFilters.LastWrite;
            watcherF2S.Changed += OnChanged_F2S;
            watcherF2S.Error += OnError;
        }
        private  void OnChanged_Json(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            master = readJson();
 
        }
        private void OnChanged_F2S(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            if (master.IsMasterActive) uploader.Send(master);

        }


        private void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private  void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Stacktrace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }
    }
}
