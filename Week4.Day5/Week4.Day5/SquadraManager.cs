using System;
using System.Collections.Generic;

namespace Week4.Day5
{
    internal class SquadraManager
    {
        public static void AggiungiCalciatore()
        {
            Console.Clear();
            Console.WriteLine("--- NUOVO CALCIATORE ---");

            string nome = StampeConsole.OttieniDati("Nome");

            int numeroMaglia;
            do
            {
                int.TryParse(StampeConsole.OttieniDati("Numero Di Maglia"), out numeroMaglia);
            } while (numeroMaglia <= 0);

            DateTime dataNascita;
            bool ancora;
            do
            {
                ancora = DateTime.TryParse(StampeConsole.OttieniDati("Data di Nascita"), out dataNascita);
            } while (ancora == false);

            bool continua = true;
            while (continua)
            {
                Categoria ruolo = StampeConsole.GetEnum<Categoria>();

                switch (ruolo)
                {
                    case Categoria.Portiere:
                        Calciatore nuovoPortiere = new Portiere();
                        nuovoPortiere.Nome = nome;
                        nuovoPortiere.NumeroMaglia = numeroMaglia;
                        nuovoPortiere.DataNascita = dataNascita;
                        nuovoPortiere.Ruolo = Categoria.Portiere;
                        int golSubiti;
                        do
                        {
                            int.TryParse(StampeConsole.OttieniDati("Gol Subiti"), out golSubiti);
                        } while (golSubiti < 0);
                        (nuovoPortiere as Portiere).NumGolSubiti = golSubiti;
                        int rigoriParati;
                        do
                        {
                            int.TryParse(StampeConsole.OttieniDati("Rigori Parati"), out rigoriParati);
                        } while (golSubiti < 0);
                        (nuovoPortiere as Portiere).NumRigoriParati = rigoriParati;
                        DatiUtilizzati.Rosa.Add(nuovoPortiere);
                        continua = false;
                        break;
                    case Categoria.Difensore:
                        Calciatore nuovoDifensore = new Difensore();
                        nuovoDifensore.Nome = nome;
                        nuovoDifensore.NumeroMaglia = numeroMaglia;
                        nuovoDifensore.DataNascita = dataNascita;
                        nuovoDifensore.Ruolo = Categoria.Difensore;
                        int contrasti;
                        do
                        {
                            int.TryParse(StampeConsole.OttieniDati("Contrasti"), out contrasti);
                        } while (contrasti < 0);
                        (nuovoDifensore as Difensore).NumContrastiRiusciti = contrasti;
                        DatiUtilizzati.Rosa.Add(nuovoDifensore);
                        continua = false;
                        break;
                    case Categoria.Centrocampista:
                        Calciatore nuovoCentrocampista = new Centrocampista();
                        nuovoCentrocampista.Nome = nome;
                        nuovoCentrocampista.NumeroMaglia = numeroMaglia;
                        nuovoCentrocampista.DataNascita = dataNascita;
                        nuovoCentrocampista.Ruolo = Categoria.Centrocampista;
                        int passaggi;
                        do
                        {
                            int.TryParse(StampeConsole.OttieniDati("Passaggi Tentati"), out passaggi);
                        } while (passaggi < 0);
                        (nuovoCentrocampista as Centrocampista).NumPassaggiTentati = passaggi;
                        int passaggiOK;
                        do
                        {
                            int.TryParse(StampeConsole.OttieniDati("Passaggi Riusciti"), out passaggiOK);
                        } while (passaggiOK < passaggi);
                        (nuovoCentrocampista as Centrocampista).NumPassaggiRiusciti = passaggiOK;
                        DatiUtilizzati.Rosa.Add(nuovoCentrocampista);
                        continua = false;
                        break;
                    case Categoria.Attaccante:
                        Calciatore nuovoAttaccante = new Attaccante();
                        nuovoAttaccante.Nome = nome;
                        nuovoAttaccante.NumeroMaglia = numeroMaglia;
                        nuovoAttaccante.DataNascita = dataNascita;
                        nuovoAttaccante.Ruolo = Categoria.Attaccante;
                        int gol;
                        do
                        {
                            int.TryParse(StampeConsole.OttieniDati("Gol Realizzati"), out gol);
                        } while (gol < 0);
                        (nuovoAttaccante as Attaccante).NumGolRealizzati = gol;
                        DatiUtilizzati.Rosa.Add(nuovoAttaccante);
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        continua = true;
                        break;
                };
            };

        }

        public static void VendiCalciatore()
        {
            StampeConsole.TabellaRosa(DatiUtilizzati.Rosa, false);

            int id;
            do
            {
                int.TryParse(StampeConsole.OttieniDati("ID Calciatore"), out id);
            } while (id < 1 || id > DatiUtilizzati.Rosa.Count);

            DatiUtilizzati.Rosa.RemoveAt(id - 1);              
        }

        public static void SquadraTitolare()
        {
            Console.Clear();

            //portiere
            foreach(Calciatore c in DatiUtilizzati.Rosa)
            {
                if (c.Ruolo == Categoria.Portiere)
                    Console.WriteLine($"{c.Nome}");
            }

            string nome = StampeConsole.OttieniDati("Nome Portiere");

            foreach (var c in DatiUtilizzati.Rosa)
                if (c.Nome == nome)
                    DatiUtilizzati.Titolari.Add(c);

            //4difensori
            Console.WriteLine();
            foreach (Calciatore c in DatiUtilizzati.Rosa)
            {
                if (c.Ruolo == Categoria.Difensore)
                    Console.WriteLine($"{c.Nome}");
            }

            for(int j = 0; j < 4; j++)
            {
                nome = StampeConsole.OttieniDati("Nome Difensore");

                foreach (var c in DatiUtilizzati.Rosa)
                    if (c.Nome == nome)
                        DatiUtilizzati.Titolari.Add(c);
            }

            //4centrocampisti
            Console.WriteLine();
            foreach (Calciatore c in DatiUtilizzati.Rosa)
            {
                if (c.Ruolo == Categoria.Centrocampista)
                    Console.WriteLine($"{c.Nome}");
            }

            for (int j = 0; j < 4; j++)
            {
                nome = StampeConsole.OttieniDati("Nome Centrocampista");

                foreach (var c in DatiUtilizzati.Rosa)
                    if (c.Nome == nome)
                        DatiUtilizzati.Titolari.Add(c);
            }

            //2attaccanti
            Console.WriteLine();
            foreach (Calciatore c in DatiUtilizzati.Rosa)
            {
                if (c.Ruolo == Categoria.Attaccante)
                    Console.WriteLine($"{c.Nome}");
            }

            for (int j = 0; j < 2; j++)
            {
                nome = StampeConsole.OttieniDati("Nome Attaccante");

                foreach (var c in DatiUtilizzati.Rosa)
                    if (c.Nome == nome)
                        DatiUtilizzati.Titolari.Add(c);
            }

        }

    }
}