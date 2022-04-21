using StatZilla_Services.Models;
using System;
using System.IO;

namespace StatZilla_Services
{
    public class StatZillaService
    {
        GodModel master;
        public StatZillaService()
        {
            master = Newtonsoft.Json.JsonConvert.DeserializeObject<GodModel>(readJson());


        }

        public void Start()
        {

        }
        public void Stop()
        {

        }

        private string readJson()
        {
            string json = "";
            string path = "output/json/currsetting.json";
            using (StreamReader r = new StreamReader(path))
            {
                json = r.ReadToEnd();
            }

            Console.WriteLine(json);
            return json;
            
        }



    }
}
