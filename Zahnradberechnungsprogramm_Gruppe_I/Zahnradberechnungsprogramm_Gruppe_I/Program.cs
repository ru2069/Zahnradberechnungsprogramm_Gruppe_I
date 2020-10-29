using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Zahnradberechnungsprogramm_Gruppe_I
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Kreiszahl = Math.PI;
            const double Kopfspielzahl = 0.167;
            const double normeingriffswinkel = 20 * Kreiszahl / 180;
            int verzahnungsArt;
            int innenAußen;

            //Begrüßung und Parametereingabe
            Console.WriteLine("Herzlich Willkommen zur pre-Alpha dieses Berechnungsprogramm zur Zahnraddimensionierung.");
            Console.WriteLine("Mit der Nutzung dieser Software erklären Sie sich, die AGB und die Datenschutzrichtlinie akzeptiert zu haben.");
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie nun Ihre grundlegenden Werte zur Berechnung ein.");
            Console.WriteLine("");

            Console.Write("Geben Sie die Zähnezahl ein: ");
            double zähnezahl = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie den Teilkreisdurchmesser [in mm] ein: ");
            double teilkreisdurchmesser = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie die Breite [in mm] ein: ");
            double breite = Convert.ToDouble(Console.ReadLine());

            Console.Write("Auf wie Stellen nach dem Komma sollen Ihre Werte gerundet werden?: ");
            int round = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //Berechnungsauswahl
            Console.WriteLine("Nun haben Sie die Möglichkeit zwischen geradeverzahnten oder schrägverzahnten Stirnrädern zu wählen.");
            Console.Write("Bitte geben Sie '1' für Geradverzahnung oder '2' für Schrägverzahnung ein: ");
            verzahnungsArt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Program prg = new Program();

            //Ausgabe Geradverzahnung allgemein
            if (verzahnungsArt == 1)
            {
                //Berechnungsauswahl in Geradverzahnung
                Console.WriteLine("Bitte wählen Sie zwischen Außen- oder Innenverzahnung.");
                Console.Write("Bitte geben Sie '1' für Außenverzahnung oder '2' für Innenverzahnung ein: ");
                innenAußen = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (innenAußen == 1)
                {
                    Console.WriteLine("Der Normeingriffswinkel wird mit 20° definiert.");
                    double modul = prg.Modul_m(teilkreisdurchmesser, zähnezahl);
                    Console.WriteLine("Das Modul                    m  = " + Math.Round(modul, round) + "mm");
                    double teilung = prg.Teilung_p(Kreiszahl, modul);
                    Console.WriteLine("Die Teilung                  p  = " + Math.Round(teilung, round) + "mm");
                    double kopfspiel = prg.Kopfspiel_c(modul, Kopfspielzahl);
                    Console.WriteLine("Das Kopfspiel                c  = " + Math.Round(kopfspiel, round) + "mm");
                    double außenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_daa(teilkreisdurchmesser, modul);
                    Console.WriteLine("Der Kopfkreisdurchmesser     da = " + Math.Round(außenKopfkreisdurchmesser, round) + "mm");
                    double außenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfa(teilkreisdurchmesser, modul, kopfspiel);
                    Console.WriteLine("Der Fußkreisdurchmesser      df = " + Math.Round(außenFußkreisdurchmesser, round) + "mm");
                    double zahnhöhe = prg.Zahnhöhe_h(modul, kopfspiel);
                    Console.WriteLine("Die Zahnhöhe                 h  = " + Math.Round(zahnhöhe, round) + "mm");
                    double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(modul);
                    Console.WriteLine("Die Zahnkopfhöhe             ha = " + Math.Round(zahnkopfhöhe, round) + "mm");
                    double zahnfüßhöhe = prg.Zahnfußhöhe_hf(modul, kopfspiel);
                    Console.WriteLine("Die Zahnfußhöhe              hf = " + Math.Round(zahnfüßhöhe, round) + "mm");
                    double grundkreisdurchmesser = prg.Grundkreisdurchmesser_db(teilkreisdurchmesser, normeingriffswinkel);
                    Console.WriteLine("Der Grundkreisdurchmesser    db = " + Math.Round(grundkreisdurchmesser, round) + "mm");
                    double volumen = prg.Volumen_v(außenKopfkreisdurchmesser, Kreiszahl, breite);
                    Console.WriteLine("Das Volumen                  V  ≈ " + Math.Round(volumen, round) + "mm^3");
                }
                else
                {
                    double modul = prg.Modul_m(teilkreisdurchmesser, zähnezahl);
                    Console.WriteLine("Das Modul                    m =  " + Math.Round(modul, round) + "mm");
                    double teilung = prg.Teilung_p(Kreiszahl, modul);
                    Console.WriteLine("Die Teilung                  p =  " + Math.Round(teilung, round) + "mm");
                    double kopfspiel = prg.Kopfspiel_c(modul, Kopfspielzahl);
                    Console.WriteLine("Das Kopfspiel                c =  " + Math.Round(kopfspiel, round) + "mm");
                    double innenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_dai(teilkreisdurchmesser, modul);
                    Console.WriteLine("Der Kopfkreisdurchmesser     da = " + Math.Round(innenKopfkreisdurchmesser, round) + "mm");
                    double innenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfi(teilkreisdurchmesser, modul, kopfspiel);
                    Console.WriteLine("Der Fußkreisdurchmesser      df = " + Math.Round(innenFußkreisdurchmesser, round) + "mm");
                    double zahnhöhe = prg.Zahnhöhe_h(modul, kopfspiel);
                    Console.WriteLine("Die Zahnhöhe                 h =  " + Math.Round(zahnhöhe, round) + "mm");
                    double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(modul);
                    Console.WriteLine("Die Zahnkopfhöhe             ha = " + Math.Round(zahnkopfhöhe, round) + "mm");
                    double zahnfüßhöhe = prg.Zahnfußhöhe_hf(modul, kopfspiel);
                    Console.WriteLine("Die Zahnfußhöhe              hf = " + Math.Round(zahnfüßhöhe, round) + "mm");
                }
            }

            //Ausgabe Schrägverzahnung
            else
            {
                Console.Write("Bitte geben Sie zusätzlich den Schrägungswinkel [in Grad] an: ");
                double degreeSchrägungswinkel = Convert.ToDouble(Console.ReadLine());
                double Schrägungswinkel = degreeSchrägungswinkel * Kreiszahl / 180;
                Console.WriteLine("");

                double stirnmodul = prg.stirnmodul_mt(teilkreisdurchmesser, zähnezahl);
                Console.WriteLine("Das Stirnmodul               mt = " + Math.Round(stirnmodul, round) + "mm");
                double normalmodul = prg.normalmodul_mn(stirnmodul, Schrägungswinkel);
                Console.WriteLine("Das Normalmodul              mn = " + Math.Round(normalmodul, round) + "mm");
                double kopfspiel = prg.schrägKopfspiel_c(normalmodul, Kopfspielzahl);
                Console.WriteLine("Das Kopfspiel                c  = " + Math.Round(kopfspiel, round) + "mm");
                double stirnteilung = prg.stirnteilung_pt(Kreiszahl, teilkreisdurchmesser, zähnezahl);
                Console.WriteLine("Die Stirnteilung             pt = " + Math.Round(stirnteilung, round) + "mm");
                double normalteilung = prg.normalteilung_pn(Kreiszahl, normalmodul);
                Console.WriteLine("Die Normalteilung            pn = " + Math.Round(normalteilung, round) + "mm");
                double kopfkreisdurchmesser = prg.kopfkreisdurchmesser_da(teilkreisdurchmesser, normalmodul);
                Console.WriteLine("Der Kopfkreisdurchmesser     da = " + Math.Round(kopfkreisdurchmesser, round) + "mm");
                double zahnhöhe = prg.schrägZahnhöhe_h(normalmodul, kopfspiel);
                Console.WriteLine("Die Zahnhöhe                 h  = " + Math.Round(zahnhöhe, round) + "mm");
                double zahnkopfhöhe = prg.schrägZahnkopfhöhe_ha(normalmodul);
                Console.WriteLine("Die Zahnkopfhöhe             ha = " + Math.Round(zahnkopfhöhe, round) + "mm");
                double zahnfußhöhe = prg.schrägZahnfußhöhe_hf(normalmodul, kopfspiel);
                Console.WriteLine("Die Zahnfußhöhe              hf = " + Math.Round(zahnfußhöhe, round) + "mm");
                double fußkreisdurchmesser = prg.schrägFußkreisdurchmesser_df(teilkreisdurchmesser, normalmodul, kopfspiel);
                Console.WriteLine("Der Fußkreisurchmesser       df = " + Math.Round(fußkreisdurchmesser, round) + "mm");
                double volumen = prg.schrägVolumen_v(kopfkreisdurchmesser, Kreiszahl, breite);
                Console.WriteLine("Das Volumen                  V  ≈ " + Math.Round(volumen, round) + "mm^3");

            }

            //Beendigung
            Console.WriteLine("");
            Console.WriteLine("Vielen dank für die Nutzung dieser Software!");
            Console.ReadKey();
        }

        //Methoden Geradverzahnung
        public double Modul_m(double teilkreisdurchmesser, double zähnezahl)
        {
            double m = teilkreisdurchmesser / zähnezahl;
            return m;
        }
        public double Teilung_p(double Kreiszahl, double modul)
        {
            double teilung = Kreiszahl * modul;
            return teilung;
        }
        public double Zahnkopfhöhe_ha(double modul)
        {
            double zahnkopfhöhe = modul;
            return zahnkopfhöhe;
        }
        public double Kopfspiel_c(double modul, double Kopfspielzahl)
        {
            double kopfspiel = Kopfspielzahl * modul;
            return kopfspiel;
        }
        public double Zahnfußhöhe_hf(double modul, double kopfspiel)
        {
            double zahnfußhöhe = modul + kopfspiel;
            return zahnfußhöhe;
        }
        public double Zahnhöhe_h(double modul, double kopfspiel)
        {
            double zahnhöhe = (2 * modul) + kopfspiel;
            return zahnhöhe;
        }
        public double Kopfkreisdurchmesser_daa(double teilkreisdurchmesser, double modul)
        {
            double außenKopfkreisdurchmesser = teilkreisdurchmesser + 2 * modul;
            return außenKopfkreisdurchmesser;
        }
        public double Fußkreisdurchmesser_dfa(double teilkreisdurchmesser, double modul, double kopfspiel)
        {
            double außenFußkreisdurchmesser = teilkreisdurchmesser - 2 * (modul + kopfspiel);
            return außenFußkreisdurchmesser;
        }
        public double Kopfkreisdurchmesser_dai(double teilkreisdurchmesser, double modul)
        {
            double innenKopfkreisdurchmesser = teilkreisdurchmesser - 2 * modul;
            return innenKopfkreisdurchmesser;
        }
        public double Fußkreisdurchmesser_dfi(double teilkreisdurchmesser, double modul, double kopfspiel)
        {
            double innenFußkreisdurchmesser = teilkreisdurchmesser + 2 * (modul + kopfspiel);
            return innenFußkreisdurchmesser;
        }
        public double Grundkreisdurchmesser_db(double teilkreisdurchmesser, double normeingriffswinkel)
        {
            double db = teilkreisdurchmesser * Math.Cos(normeingriffswinkel);
            return db;
        }
        public double Volumen_v(double außenKopfkreisdurchmesser, double Kreiszahl, double breite)
        {
            double v = Kreiszahl * Math.Pow((außenKopfkreisdurchmesser / 2), 2) * breite;
            return v;
        }

        //Methoden Schrägverzahnung
        public double stirnmodul_mt(double teilkreisdurchmesser, double zähnezahl)
        {
            double mt = teilkreisdurchmesser / zähnezahl;
            return mt;
        }
        public double normalmodul_mn(double stirnmodul, double Schrägungswinkel)
        {
            double mn = stirnmodul * Math.Cos(Schrägungswinkel);
            return mn;
        }
        public double normalteilung_pn(double kreiszahl, double normalmodul)
        {
            double pn = kreiszahl * normalmodul;
            return pn;
        }
        public double stirnteilung_pt(double kreiszahl, double teilkreidurchmesser, double zähnezahl)
        {
            double pt = (kreiszahl * teilkreidurchmesser) / zähnezahl;
            return pt;
        }
        public double kopfkreisdurchmesser_da(double teilkreisdurchmesser, double normalmodul)
        {
            double da = teilkreisdurchmesser + 2 * normalmodul;
            return da;
        }
        public double schrägKopfspiel_c(double normalmodul, double Kopfspielzahl)
        {
            double kopfspiel = Kopfspielzahl * normalmodul;
            return kopfspiel;
        }
        public double schrägZahnhöhe_h(double normalmodul, double kopfspiel)
        {
            double zahnhöhe = (2 * normalmodul) + kopfspiel;
            return zahnhöhe;
        }
        public double schrägZahnkopfhöhe_ha(double normalmodul)
        {
            double zahnkopfhöhe = normalmodul;
            return zahnkopfhöhe;
        }
        public double schrägZahnfußhöhe_hf(double normalmodul, double kopfspiel) 
        {
            double zahnfußhöhe = normalmodul + kopfspiel;
            return zahnfußhöhe;
        }
        public double schrägFußkreisdurchmesser_df(double teilkreisdurchmesser, double kopfspiel, double normalmodul)
        {
            double fußkreisdurchmesser = teilkreisdurchmesser + 2 * (normalmodul + kopfspiel);
            return fußkreisdurchmesser;
        }
        public double schrägVolumen_v(double kopfkreisdurchmesser, double Kreiszahl, double breite)
        {
            double v = Kreiszahl * Math.Pow((kopfkreisdurchmesser / 2), 2) * breite;
            return v;
        }
    }
}

