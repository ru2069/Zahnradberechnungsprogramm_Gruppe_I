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
            double Kreiszahl = 3.141;
            double Kopfspielzahl = 0.167;
            double Schrägungswinkel = 19.5;
            int verzahnungsArt;
            int innenAußen;

            //Begrüßung und Parametereingabe
            Console.WriteLine("Herzlich Willkommen zur pre-Alpha dieses Berechnungsprogramm zur Zahnraddimensionierung.");
            Console.WriteLine("Bitte geben Sie nun Ihre grundlegenden Werte zur Berechnung ein.");
            Console.WriteLine("");

            Console.Write("Geben Sie die Zähnezahl ein: ");
            double zähnezahl = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie den Teilkreisdurchmesser [in mm] ein: ");
            double teilkreisdurchmesser = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie die Breite [in mm] ein: ");
            double breite = Convert.ToDouble(Console.ReadLine());
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
                    double modul = prg.Modul_m(teilkreisdurchmesser, zähnezahl);
                    Console.WriteLine("Das Modul                    m = " + modul + "mm");
                    double teilung = prg.Teilung_p(Kreiszahl, modul);
                    Console.WriteLine("Die Teilung                  p = " + teilung + "mm");
                    double Kopfspiel = prg.Kopfspiel_c(modul, Kopfspielzahl);
                    Console.WriteLine("Das Kopfspiel                c = " + Kopfspiel + "mm");
                    double außenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_daa(teilkreisdurchmesser, modul);
                    Console.WriteLine("Der Kopfkreisdurchmesser     da = " + außenKopfkreisdurchmesser + "mm");
                    double außenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfa(teilkreisdurchmesser, modul, Kopfspiel);
                    Console.WriteLine("Der Fußkreisdurchmesser      df = " + außenFußkreisdurchmesser + "mm");
                    double zahnhöhe = prg.Zahnhöhe_h(modul, Kopfspiel);
                    Console.WriteLine("Die Zahnhöhe                 h = " + zahnhöhe + "mm");
                    double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(modul);
                    Console.WriteLine("Die Zahnkopfhöhe             ha = " + zahnkopfhöhe + "mm");
                    double zahnfüßhöhe = prg.Zahnfußhöhe_hf(modul, Kopfspiel);
                    Console.WriteLine("Die Zahnfußhöhe              hf = " + zahnfüßhöhe + "mm");

                }
                else
                {
                    double modul = prg.Modul_m(teilkreisdurchmesser, zähnezahl);
                    Console.WriteLine("Das Modul                    m = " + modul + "mm");
                    double teilung = prg.Teilung_p(Kreiszahl, modul);
                    Console.WriteLine("Die Teilung                  p = " + teilung + "mm");
                    double Kopfspiel = prg.Kopfspiel_c(modul, Kopfspielzahl);
                    Console.WriteLine("Das Kopfspiel                c = " + Kopfspiel + "mm");
                    double innenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_dai(teilkreisdurchmesser, modul);
                    Console.WriteLine("Der Kopfkreisdurchmesser     da = " + innenKopfkreisdurchmesser + "mm");
                    double innenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfi(teilkreisdurchmesser, modul, Kopfspiel);
                    Console.WriteLine("Der Fußkreisdurchmesser      df = " + innenFußkreisdurchmesser + "mm");
                    double zahnhöhe = prg.Zahnhöhe_h(modul, Kopfspiel);
                    Console.WriteLine("Die Zahnhöhe                 h = " + zahnhöhe + "mm");
                    double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(modul);
                    Console.WriteLine("Die Zahnkopfhöhe             ha = " + zahnkopfhöhe + "mm");
                    double zahnfüßhöhe = prg.Zahnfußhöhe_hf(modul, Kopfspiel);
                    Console.WriteLine("Die Zahnfußhöhe              hf = " + zahnfüßhöhe + "mm");
                }
            }

            //Ausgabe Schrägverzahnung
            else
            {
                double stirnmodul = prg.stirnmodul_mt(teilkreisdurchmesser,zähnezahl);
                Console.WriteLine("Das Stirnmodul               mt = " + stirnmodul + "mm");
                double normalmodul = prg.normalmodul_mn(stirnmodul, Schrägungswinkel);
                Console.WriteLine("Das Normalmodul              mn = " + normalmodul + "mm");
                double Kopfspiel = prg.schrägKopfspiel_c(normalmodul, Kopfspielzahl);
                Console.WriteLine("Das Kopfspiel                c = " + Kopfspiel + "mm");
                double stirnteilung = prg.stirnteilung_pt(Kreiszahl, teilkreisdurchmesser, zähnezahl);
                Console.WriteLine("Die Stirnteilung             pt = " + stirnteilung + "mm");
                double normalteilung = prg.normalteilung_pn(Kreiszahl, normalmodul);
                Console.WriteLine("Die Normalteilung            pn = " + normalteilung + "mm");
                double kopfkreisdurchmesser = prg.kopfkreisdurchmesser_da(teilkreisdurchmesser, normalmodul);
                Console.WriteLine("Der Kopfkreisdurchmesser     da = " + kopfkreisdurchmesser + "mm");
                double zahnhöhe = prg.schrägZahnhöhe_h(normalmodul, Kopfspiel);
                Console.WriteLine("Die Zahnhöhe                 h = " + zahnhöhe + "mm");
            }
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
            double Kopfspiel = Kopfspielzahl * modul;
            return Kopfspiel;
        }
        public double Zahnfußhöhe_hf(double modul, double Kopfspiel)
        {
            double zahnfußhöhe = modul + Kopfspiel;
            return zahnfußhöhe;
        }
        public double Zahnhöhe_h(double modul, double Kopfspiel)
        {
            double zahnhöhe = (2 * modul) + Kopfspiel;
            return zahnhöhe;
        }
        public double Kopfkreisdurchmesser_daa(double teilkreisdurchmesser, double modul)
        {
            double außenKopfkreisdurchmesser = teilkreisdurchmesser + 2 * modul;
            return außenKopfkreisdurchmesser;
        }
        public double Fußkreisdurchmesser_dfa(double teilkreisdurchmesser, double modul, double Kopfspiel)
        {
            double außenFußkreisdurchmesser = teilkreisdurchmesser - 2 * (modul + Kopfspiel);
            return außenFußkreisdurchmesser;
        }
        public double Kopfkreisdurchmesser_dai(double teilkreisdurchmesser, double modul)
        {
            double innenKopfkreisdurchmesser = teilkreisdurchmesser - 2 * modul;
            return innenKopfkreisdurchmesser;
        }
        public double Fußkreisdurchmesser_dfi(double teilkreisdurchmesser,double modul, double Kopfspiel)
        {
            double innenFußkreisdurchmesser = teilkreisdurchmesser + 2 * (modul + Kopfspiel);
            return innenFußkreisdurchmesser;
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
            double Kopfspiel = Kopfspielzahl * normalmodul;
            return Kopfspiel;
        }
        public double schrägZahnhöhe_h(double normalmodul, double Kopfspiel)
        {
            double zahnhöhe = (2 * normalmodul) + Kopfspiel;
            return zahnhöhe;
        }
    }
}

