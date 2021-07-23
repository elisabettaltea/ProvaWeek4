using System;
using System.Collections.Generic;

namespace Week4.Day5
{
    public class Menu
    {
        public static void Start()
        {
            bool quit = false;

            do
            {
                string comando = StampeConsole.StampaMenu(
                    "Esercitazione pratica - Week 4 - Squadra di Calcio",
                    new List<string> {
                        "[ 1 ] - Visualizza Rosa",
                        "[ 2 ] - Nuovo Calciatore",
                        "[ 3 ] - Vendi Calciatore",
                        "[ 4 ] - Gestisci squadra titolare",
                        "[ 5 ] - Statistiche squadra titolare",
                        "[ q ] - ESCI"
                    });

                switch (comando)
                {
                    case "1":
                        StampeConsole.TabellaRosa(DatiUtilizzati.Rosa);
                        break;
                    case "2":
                        SquadraManager.AggiungiCalciatore();
                        break;
                    case "3":
                        SquadraManager.VendiCalciatore();
                        break;
                    case "4":
                        SquadraManager.SquadraTitolare();
                        break;
                    case "5":
                        StampeConsole.TabellaTitolari(DatiUtilizzati.Titolari);
                        break;
                    case "q":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }

            } while (!quit);
        }
    }
}