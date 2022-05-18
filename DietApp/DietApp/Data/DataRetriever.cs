using DietApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DietApp.Data
{
    internal class DataRetriever
    {
        public static string url = "https://autodb.work/alimente.json";

        public static string GetData ()
        {
            using (var w = new System.Net.WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string    
                try
                {
                    Console.WriteLine("Started downloading data");
                    json_data = w.DownloadString(url);
                    Console.WriteLine("Completed downloading");
                }
                catch (Exception)
                {
                }
                return json_data;   
            }
            
            return "Nu am vrut sa merg";
        }

        public static List<Aliment> getBreakfastAliments ()
        {
            List<Aliment> aliments = new List<Aliment>();

            string json = GetData ();

            JObject data = JObject.Parse(json);
            foreach (var item in data["mic_dejun"])
            {
                Aliment aliment = new Aliment();

                aliment.Nume = item["nume"].ToString();
                aliment.Greutate = int.Parse(item["greutate"].ToString());
                aliment.Calorii = int.Parse(item["calorii"].ToString());
                aliment.Carbohidrati = int.Parse(item["carbohidrati"].ToString());
                aliment.Proteine = int.Parse(item["proteine"].ToString());

                aliments.Add(aliment);
            }



            return aliments;
        }
    }
}
