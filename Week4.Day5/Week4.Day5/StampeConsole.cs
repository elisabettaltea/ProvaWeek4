using System;
using System.Collections.Generic;

namespace Week4.Day5
{
    internal class StampeConsole
    {
        public static string StampaMenu(string titolo, List<string> opzioniMenu)
        {
            Console.Clear();
            Console.WriteLine($"============= {titolo} =============");
            Console.WriteLine();

            foreach (var item in opzioniMenu)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.Write("> ");
            string comando = Console.ReadLine();
            Console.WriteLine();

            return comando;
        }

        public static T GetEnum<T>() where T : struct
        {
            string enumLegenda = "Ruolo [";
            foreach (var suit in Enum.GetValues(typeof(Categoria)))
            {
                enumLegenda += suit.ToString() + "/";
            }
            enumLegenda += "] > ";

            Console.Write(enumLegenda);
            var value = Console.ReadLine();

            Enum.TryParse<T>(value, true, out T result);

            return result;
        }

        public static string OttieniDati(string messaggio)
        {
            Console.Write(messaggio + ": ");
            var value = Console.ReadLine();
            return value;
        }

        public static void TabellaTitolari(List<Calciatore> titolari, bool mostraPrompt = true)
        {
            Console.Clear();
            Console.WriteLine("{0,-14}{1,-30}{2,-20}{3,-45}", "Numero Maglia", "Nome Calciatore", "Ruolo", "Statistiche");
            Console.WriteLine(new String('-', 100));
            foreach (var c in titolari)
            {
                string statistiche = string.Empty;

                if (c is Portiere)
                {
                    Portiere p = ((Portiere)c);
                    statistiche = $"[Gol subiti] {p.NumGolSubiti} [Rigori parati] {p.NumRigoriParati}";
                }

                if (c is Difensore)
                {
                    Difensore d = ((Difensore)c);
                    statistiche = $"[Contrasti riusciti] {d.NumContrastiRiusciti}";
                }

                if (c is Centrocampista)
                {
                    Centrocampista cc = ((Centrocampista)c);
                    statistiche = $"[Passaggi tentati] {cc.NumPassaggiTentati} [Passaggi riusciti] {cc.NumPassaggiRiusciti}";
                }

                if (c is Attaccante)
                {
                    Attaccante a = ((Attaccante)c);
                    statistiche = $"[Gol realizzati] {a.NumGolRealizzati}";
                }

                Console.WriteLine($"{c.NumeroMaglia,-14}{c.Nome,-30}{c.Ruolo,-20}{statistiche,-45}");
            }
            Console.WriteLine();

            if (mostraPrompt)
            {
                Console.WriteLine(">> Premi un tasto per tornare al menu");
                Console.ReadKey();
            }
        }

        public static void TabellaRosa(List<Calciatore> rosa, bool mostraPrompt = true)
        {
            Console.Clear();
            Console.WriteLine("{0,-10}{1,-40}{2, -10}{3, -20}", "ID", "Nome", "Numero di Maglia", "Ruolo");
            Console.WriteLine(new String('-', 95));
            int i = 1;
            foreach (var g in rosa)
            {
                Console.WriteLine($"{i,-10}{g.Nome,-40}{g.NumeroMaglia,-10}{g.Ruolo,-20}");
                i++;
            }
            Console.WriteLine();

            if (mostraPrompt)
            {
                Console.WriteLine(">> Premi un tasto per tornare al menu");
                Console.ReadKey();
            }
        }



    }
}