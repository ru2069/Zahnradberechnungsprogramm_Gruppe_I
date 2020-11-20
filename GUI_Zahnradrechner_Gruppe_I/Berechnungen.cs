using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_Zahnradrechner_Gruppe_I
{
    class Berechnungen
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
            double v = (Kreiszahl * Math.Pow((außenKopfkreisdurchmesser / 2), 2) * breite) / 1000;
            return v;
        }
        public double masse_m(double material, double Volumen_v)
        {
            double m = material * Volumen_v;
            return m;
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
            double v = (Kreiszahl * Math.Pow((kopfkreisdurchmesser / 2), 2) * breite) / 1000;
            return v;
        }
        public double schrägMasse_m(double material, double schrägVolumen_v)
        {
            double m = material * schrägVolumen_v;
            return m;
        }
    }
}
