using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_Zahnradrechner_Gruppe_I
{
     public class Berechnungen
    {
        public double Teilkreisdurchmesser_d(double modul, double zähnezahl)
        {
            double d = modul * zähnezahl;
            return d;
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
        public double Kopfkreisdurchmesser_daa(double d, double modul)
        {
            double außenKopfkreisdurchmesser = d + 2 * modul;
            return außenKopfkreisdurchmesser;
        }
        public double Fußkreisdurchmesser_dfa(double d, double modul, double kopfspiel)
        {
            double außenFußkreisdurchmesser = d - 2 * (modul + kopfspiel);
            return außenFußkreisdurchmesser;
        }
        public double Kopfkreisdurchmesser_dai(double d, double modul)
        {
            double innenKopfkreisdurchmesser = d - 2 * modul;
            return innenKopfkreisdurchmesser;
        }
        public double Fußkreisdurchmesser_dfi(double d, double modul, double kopfspiel)
        {
            double innenFußkreisdurchmesser = d + 2 * (modul + kopfspiel);
            return innenFußkreisdurchmesser;
        }
        public double Grundkreisdurchmesser_db(double d, double normeingriffswinkel)
        {
            double db = d * Math.Cos(normeingriffswinkel);
            return db;
        }
        public double Volumen_vg(double außenKopfkreisdurchmesser, double Kreiszahl, double breite)
        {
            double vg = (Kreiszahl * Math.Pow((außenKopfkreisdurchmesser / 2), 2) * breite) / 1000;
            return vg;
        }
        public double masse_mg(double material, double vg)
        {
            double mg = material * vg;
            return mg;
        }

        //Methoden Schrägverzahnung
        public double stirnmodul_mt(double d, double zähnezahl)
        {
            double mt = d / zähnezahl;
            return mt;
        }
        public double normalmodul_mn(double stirnmodul, double schr)
        {
            double mn = stirnmodul * Math.Cos(schr);
            return mn;
        }
        public double normalteilung_pn(double kreiszahl, double normalmodul)
        {
            double pn = kreiszahl * normalmodul;
            return pn;
        }
        public double stirnteilung_pt(double kreiszahl, double d, double zähnezahl)
        {
            double pt = (kreiszahl * d) / zähnezahl;
            return pt;
        }
        public double kopfkreisdurchmesser_da(double d, double normalmodul)
        {
            double da = d + 2 * normalmodul;
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
        public double schrägFußkreisdurchmesser_df(double d, double kopfspiel, double normalmodul)
        {
            double fußkreisdurchmesser = d + 2 * (normalmodul + kopfspiel);
            return fußkreisdurchmesser;
        }
        public double schrägVolumen_vs(double d, double Kreiszahl, double breite)
        {
            double vs = (Kreiszahl * Math.Pow((d / 2), 2) * breite) / 1000;
            return vs;
        }
        public double schrägMasse_ms(double material, double vs)
        {
            double ms = material * vs;
            return ms;
        }
    }
}
