using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Day5
{
    public class Squadra
    {
        public string Nome { get; private set; }
        public DateTime DataFondazione { get; private set; }
        public string CampionatoDisputato { get; private set; }
        public string NomePresidente { get; private set; }
        public string NomeAllenatore { get; private set; }
        public List<Calciatore> Rosa { get; set; }

        public Squadra()
        {
            Nome = "SquadraBetta";
            DataFondazione = new DateTime(2021,07,23);
            CampionatoDisputato = "SerieA";
            NomePresidente = "Eli Altea";
            NomeAllenatore = "Betta Altea";
        }
    }
}
