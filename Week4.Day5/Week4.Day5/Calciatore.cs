using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Day5
{
    public class Calciatore
    {
        public int NumeroMaglia { get; set; }
	    public string Nome { get; set; }
	    public DateTime DataNascita { get; set; }

        public Categoria Ruolo { get; set; }

    }

    public class Portiere : Calciatore
    {
        public int NumGolSubiti { get; set; }
        public int NumRigoriParati { get; set; }
    }

    public class Difensore : Calciatore
    {
        public int NumContrastiRiusciti { get; set; }
    }

    public class Centrocampista : Calciatore
    {
        public int NumPassaggiTentati { get; set; }
        public int NumPassaggiRiusciti { get; set; }
    }

    public class Attaccante : Calciatore
    {
        public int NumGolRealizzati { get; set; }
    }
}
