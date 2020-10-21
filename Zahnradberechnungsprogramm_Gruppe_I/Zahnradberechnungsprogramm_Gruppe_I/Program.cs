﻿using System;
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
            double Kopfspiel = 0.167;

            //Begrüßung und Parametereingabe
            Console.WriteLine("Herzlich Willkommen zur pre-Alpha dieses Berechnungsprogramm zur Zahnraddimensionierung.");
            Console.WriteLine("Bitte geben Sie nun Ihre grundlegenden Werte [Angaben in mm] zur Berechnung ein.");
            Console.WriteLine("");

            Console.Write("Geben Sie die Zähnezahl ein: ");
            double zähnezahl = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie den Teilkreisdurchmesser ein: ");
            double teilkreisdurchmesser = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie die Breite ein: ");
            double breite = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            //Berechnungsauswahl
            Console.WriteLine("Nun haben Sie die Möglichkeit zwischen geradeverzahnten oder schrägverzahnten Stirnrädern zu wählen.");
            Console.Write("Bitte geben Sie '1' für Geradverzahnung oder '2' für Schrägverzahnung ein: ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Program prg = new Program();
            
            //Ausgabe Geradverzahnung allgemein
            if (a == 1)
            {
                //Berechnungsauswahl in Geradverzahnung
                Console.WriteLine("Bitte wählen Sie zwischen Außen- oder Innenverzahnung.");
                Console.Write("Bitte geben Sie '1' für Außenverzahnung oder '2' für Innenverzahnung ein: ");
                int b;
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (b == 1)
                {
                    double modul = prg.Modul_m(teilkreisdurchmesser, zähnezahl);
                    Console.WriteLine("Das Modul            m = " + modul + "mm");
                    double teilung = prg.Teilung_p(Kreiszahl, modul);
                    Console.WriteLine("Die Teilung p = " + teilung + "mm");
                }
                else
                {
                    double modul = prg.Modul_m(teilkreisdurchmesser, zähnezahl);
                    Console.WriteLine("Das TEST            m = " + modul + "mm");
                    double teilung = prg.Teilung_p(Kreiszahl, modul);
                    Console.WriteLine("Die Teilung p = " + teilung + "mm");
                }
            }

            //Ausgabe Schrägverzahnung
            else
            {
                Console.WriteLine("jbvhjdn");
            }

            Console.ReadKey();
        }

        public double Modul_m(double teilkreisdurchmesser, double zähnezahl)
        {
            double modul = teilkreisdurchmesser / zähnezahl;
            return modul;
        }

        public double Teilung_p(double Kreiszahl, double modul)
        {
            double teilung = Kreiszahl * modul;
            return teilung;
        }
<<<<<<< HEAD
        public double Zahnkopfhöhe_ha(double modul)
        {
            double zahnkopfhöhe = modul;
            return zahnkopfhöhe;
        }
        public double Zahnfußhöhe_hf(double modul, double Kopfspiel)
        {
            double zahnfußhöhe = modul + Kopfspiel;
            return zahnfußhöhe;
        }
        public double Zahnhöhe_h(double modul, double Kopfspiel)
        {
            double zahnhöhe = 2 * modul + Kopfspiel;
            return zahnhöhe;
        }
        public double Kopfkreisdurchmesser_daa(double teilkreisdurchmesser, double modul)
        {
            double daa = teilkreisdurchmesser + 2 * modul;
            return daa;
        }
        public double Fußkreisdurchmesser_dfa(double teilkreisdurchmesser, double modul, double Kopfspiel)
        {
            double dfa = teilkreisdurchmesser - 2 * (modul + Kopfspiel);
            return dfa;
        }
        public double Kopfkreisdurchmesser_dai(double teilkreisdurchmesser, double modul)
        {
            double dai = teilkreisdurchmesser - 2 * modul;
            return dai;
        }

=======
>>>>>>> 8d2c5146864fba3f2e423370dfd87183a3fba0f1
    }
}

