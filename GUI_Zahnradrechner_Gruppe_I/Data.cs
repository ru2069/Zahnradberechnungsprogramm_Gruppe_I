using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_Zahnradrechner_Gruppe_I
{
    public class Data
    {
        double modul;
        double zähnezahl;
        double kreiszahl;
        double kopfspielzahl;
        double normeingriffswinkel;
        double breite;
        double material;
        double schr;

        public double getModul()
        {
            return modul;
        }

        public void setModul(double modul)
        {
            this.modul = modul;
        }

        public double getZähnezahl()
        {
            return zähnezahl;
        }

        public void setZähnezahl(double zähnezahl)
        {
            this.zähnezahl = zähnezahl;
        }

        public double getKreiszahl()
        {
            return kreiszahl;
        }

        public void setKreiszahl(double kreiszahl)
        {
            this.kreiszahl = kreiszahl;
        }

        public double getKopfspielzahl()
        {
            return kopfspielzahl;
        }

        public void setKopfspielzahl(double kopfspielzahl)
        {
            this.kopfspielzahl = kopfspielzahl;
        }

        public double getNormeingriffswinkel()
        {
            return normeingriffswinkel;
        }

        public void setNormeingriffswinkel(double normeingriffswinkel)
        {
            this.normeingriffswinkel = normeingriffswinkel;
        }

        public double getBreite()
        {
            return breite;
        }

        public void setBreite(double breite)
        {
            this.breite = breite;
        }
        public double getMaterial()
        {
            return material;
        }

        public void setMaterial(double material)
        {
            this.material = material;
        }

        public double getSchrägungswinkel()
        {
            return schr;
        }

        public void setSchrägungswinkel(double schr)
        {
            this.schr = schr;
        }
    }
}
