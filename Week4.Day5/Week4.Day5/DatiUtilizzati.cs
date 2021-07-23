using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Day5
{
    public static class DatiUtilizzati
    {
        public static List<Calciatore> Titolari = new List<Calciatore>();

        public static List<Calciatore> Rosa = new List<Calciatore>
        {
            new Portiere
            {
                Nome = "Portiere1",
                NumeroMaglia = 1,
                DataNascita = new DateTime(1999,10,16),
                Ruolo = Categoria.Portiere,
                NumGolSubiti = 10,
                NumRigoriParati = 33
            },
            new Portiere
            {
                Nome = "Portiere2",
                NumeroMaglia = 2,
                DataNascita = new DateTime(1995,11,15),
                Ruolo = Categoria.Portiere,
                NumGolSubiti = 16,
                NumRigoriParati = 23
            },
            new Difensore
            {
                Nome = "Difensore1",
                NumeroMaglia = 5,
                DataNascita = new DateTime(1998,10,11),
                Ruolo = Categoria.Difensore,
                NumContrastiRiusciti = 43
            },
            new Difensore
            {
                Nome = "Difensore2",
                NumeroMaglia = 6,
                DataNascita = new DateTime(1997,11,11),
                Ruolo = Categoria.Difensore,
                NumContrastiRiusciti = 33
            },
            new Difensore
            {
                Nome = "Difensore3",
                NumeroMaglia = 7,
                DataNascita = new DateTime(1998,09,08),
                Ruolo = Categoria.Difensore,
                NumContrastiRiusciti = 48
            },
            new Difensore
            {
                Nome = "Difensore4",
                NumeroMaglia = 8,
                DataNascita = new DateTime(1996,10,11),
                Ruolo = Categoria.Difensore,
                NumContrastiRiusciti = 27
            },
            new Difensore
            {
                Nome = "Difensore5",
                NumeroMaglia = 9,
                DataNascita = new DateTime(2000,02,18),
                Ruolo = Categoria.Difensore,
                NumContrastiRiusciti = 18
            },
            new Difensore
            {
                Nome = "Difensore6",
                NumeroMaglia = 10,
                DataNascita = new DateTime(2001,02,14),
                Ruolo = Categoria.Difensore,
                NumContrastiRiusciti = 21
            },
            new Centrocampista
            {
                Nome = "Centrocampista1",
                NumeroMaglia = 12,
                DataNascita = new DateTime(1993,10,11),
                Ruolo = Categoria.Centrocampista,
                NumPassaggiTentati = 45,
                NumPassaggiRiusciti = 44
            },
            new Centrocampista
            {
                Nome = "Centrocampista2",
                NumeroMaglia = 14,
                DataNascita = new DateTime(1999,01,12),
                Ruolo = Categoria.Centrocampista,
                NumPassaggiTentati = 55,
                NumPassaggiRiusciti = 33
            },
            new Centrocampista
            {
                Nome = "Centrocampista3",
                NumeroMaglia = 17,
                DataNascita = new DateTime(1989,10,19),
                Ruolo = Categoria.Centrocampista,
                NumPassaggiTentati = 55,
                NumPassaggiRiusciti = 44
            },
            new Centrocampista
            {
                Nome = "Centrocampista4",
                NumeroMaglia = 19,
                DataNascita = new DateTime(1988,03,14),
                Ruolo = Categoria.Centrocampista,
                NumPassaggiTentati = 25,
                NumPassaggiRiusciti = 14
            },
            new Centrocampista
            {
                Nome = "Centrocampista5",
                NumeroMaglia = 21,
                DataNascita = new DateTime(1999,10,17),
                Ruolo = Categoria.Centrocampista,
                NumPassaggiTentati = 45,
                NumPassaggiRiusciti = 44
            },
            new Centrocampista
            {
                Nome = "Centrocampista6",
                NumeroMaglia = 23,
                DataNascita = new DateTime(1994,08,14),
                Ruolo = Categoria.Centrocampista,
                NumPassaggiTentati = 67,
                NumPassaggiRiusciti = 60
            },
            new Attaccante
            {
                Nome = "Attaccante1",
                NumeroMaglia = 14,
                DataNascita = new DateTime(1998,09,18),
                Ruolo = Categoria.Attaccante,
                NumGolRealizzati = 23
            },
            new Attaccante
            {
                Nome = "Attaccante2",
                NumeroMaglia = 18,
                DataNascita = new DateTime(1993,11,02),
                Ruolo = Categoria.Attaccante,
                NumGolRealizzati = 14
            },
            new Attaccante
            {
                Nome = "Attaccante3",
                NumeroMaglia = 24,
                DataNascita = new DateTime(2000,04,11),
                Ruolo = Categoria.Attaccante,
                NumGolRealizzati = 18
            },
            new Attaccante
            {
                Nome = "Attaccante4",
                NumeroMaglia = 28,
                DataNascita = new DateTime(2001,12,30),
                Ruolo = Categoria.Attaccante,
                NumGolRealizzati = 21
            },
        };
    }
}
