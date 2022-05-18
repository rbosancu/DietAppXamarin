using DietApp.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DietApp.Models
{
    internal class MicDejun
    {
        public List<Aliment> alimente = new List<Aliment>();

        public MicDejun()
        {

            alimente = DataRetriever.getBreakfastAliments();
            //JObject o1 = JObject.Parse(File.ReadAllText(this.path));
            //alimente.Add(new Aliment
            //{
            //    Nume = "Iaurt grecesc",
            //    Greutate = 100,
            //    Calorii = 48,
            //    Carbohidrati = 4,
            //    Proteine = 9,
            //});

            //alimente.Add(new Aliment
            //{
            //    Nume = "Fulgi de Secara",
            //    Greutate = 100,
            //    Calorii = 333,
            //    Carbohidrati = 58,
            //    Proteine = 12,
            //});

            //alimente.Add(new Aliment
            //{
            //    Nume = "Nectarine",
            //    Greutate = 100,
            //    Calorii = 44,
            //    Carbohidrati = 11,
            //    Proteine = 1,
            //});

            //alimente.Add(new Aliment
            //{
            //    Nume = "Mere rosii",
            //    Greutate = 100,
            //    Calorii = 24,
            //    Carbohidrati = 14,
            //    Proteine = 0,
            //});
        }
    }
}
