using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungMustCanDo01
{
    class Program
    {
        // darf nicht verändert werden!
        static List<string> obstListe = new List<string>() { "Pflaume", "Honigmelone", "Birne", "Traube", "Limone", "Birne", "Pflaume", "Birne", "Mango", "Limone", "Mango", "Birne", "Dattel", "Mango", "Apfel", "Kirsche", "Kirsche", "Birne", "Limone", "Apfel", "Apfel", "Dattel", "Birne", "Traube", "Kirsche", "Erdbeere", "Feigen", "Birne", "Apfel", "Erdbeere", "Erdbeere", "Feigen", "Limone", "Apfel", "Birne", "Erdbeere", "Mango", "Mango", "Honigmelone", "Erdbeere", "Limone", "Zitrone", "Honigmelone", "Erdbeere", "Apfel", "Feigen", "Birne", "Traube", "Apfel", "Pflaume" };
        // darf nicht verändert werden!
        static string obstSchüssel = "Pflaumen;Apfel;Limonen;Brombeere;Brombeere;Apfel;Mango;Limone;Erdbeer;Apfel;Birnen;Wassermelone;Feigen;Apfel;Trauben;Birnen;Zitronen;Apfel;Birnen;Feigen;;;";

        // hier implementieren
        public static int summeZahlen(string line)
        {
            int summe = 0;
            string[] zeileSplitted = line.Split(' ');
            foreach (var item in zeileSplitted)
            {
                int itemInt = Convert.ToInt32(item);
                if (itemInt > 50)
                {
                    summe += itemInt;
                    
                }
            }
            return summe;
        }
        // diese Funktion soll die Datei uebung01 zeilenweise einlesen
        // in jeder Zeile stehen Zahlen durch ein Leerzeichen getrennt
        // alle Zahlen aller Zeilen die größer als 50 sind, sollen aufsummiert werden
        // die Funktion liefert dann diese Summe zurück
        internal static int DateiLesen()
        {
            // aktuelles Verzeichnis ist /bin/debug ... daher 2 Verzeichnisse hinauf
            StreamReader stream = new StreamReader(@"../../uebung01.csv");
            // solange nicht "end of stream" erreicht ist ... führe den folgenden Block aus
            while (stream.EndOfStream == false)
            {
                string line = stream.ReadLine();
            }
            // den stream am Ende des Lesens wieder schliessen!
            stream.Close();
            return 0;
        }

        // hier implementieren
        // Diese Funktion soll eine neue Liste an Obst zurückgeben.
        // Die Liste die übergeben wird enthält "Birne", die zurückgegebene Liste soll keine Birnen mehr enthalten.
        // Oder anders formuliert: Erstelle eine neue Liste, die alles bis auf "Birne" von der Originalliste enthält.
        static List<string> OhneBirnen = new List<string>();
        public static List<string> ListeOhneBirnen(List<string> obstListe)
        {
            foreach (var item in obstListe)
            {
                if (item != "Birne")
                {
                    OhneBirnen.Add(item);
                }
            }
            return obstListe;
        }


        // Implementiere eine Funktion: ObstKlein
        // diese Funktion bekommt einen string obst
        // wenn das obst ein Apfel, Birnen oder Brombere ist, dann gibt die Funktion das Obst als Mus zurück .. dh aus "Apfel" wird "Apfelmus"
        // für alle anderen Obstsorten werden Würfel zurückgegeben z.B. Feigenwürfel

        // Implementiere eine Funktion: MacheObstSalat
        // Diese Funktion bekommt einen String ObstSchüssel - der Obst durch ; getrennt enthält
        // Schreibt den Code der den übergebenen String nach ";" aufteilt und für jedes Obst die Funktion ObstKlein aufruft und das Ergebnis am 
        // Bildschirm ausgibt. Achtung das Ende der ObstSchüssel ist etwas, das ihr beachten müsst.


        // hier ObstKlein implementieren
        public static void ObstKlein(string obst)
        {
            if (obst == "Apfel" | obst == "Birne" | obst == "Brombeere")
            {
                Console.WriteLine($"{obst}mus");
            }
            else
            {
                Console.WriteLine($"{obst}würfel");
            }

        }
        
        // hier MacheObstSalat implementieren

        public static void MacheObstSalat(string obstSchüssel)
        {
            string[] Früchte = obstSchüssel.Split(';');
            foreach (var item in Früchte)
            {
                ObstKlein(item);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Summe 1: {DateiLesen()}"); // Summe 1: 11643
            Console.ReadKey();
            Console.WriteLine($"Liste ohne Birnen: {ListeOhneBirnen(obstListe).Count}"); // Liste ohne Birnen: 41
            Console.ReadKey();
            // MacheObstSalat(obstSchüssel);
            // PflaumenwürfelApfelmusLimonenwürfelBrombeerewürfelBrombeerewürfelApfelmusMangowürfelLimonewürfelErdbeerwürfelApfelmusBirnenmusWassermelonewürfelFeigenwürfelApfelmusTraubenwürfelBirnenmusZitronenwürfelApfelmusBirnenmusFeigenwürfel
            Console.ReadKey();
        }


    }
}
