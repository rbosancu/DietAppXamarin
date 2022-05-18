using System;
using System.Collections.Generic;
using System.Text;

namespace DietApp.Models
{
    internal class Aliment
    {
        public string Nume { get; set; }
        public int Greutate { get; set; }
        public int Calorii { get; set; }
        public int Carbohidrati { get; set; }
        public int Proteine { get; set; }

        public string arataNumeleBulangiule ()
        {
            return Nume;
        }

    }
}
