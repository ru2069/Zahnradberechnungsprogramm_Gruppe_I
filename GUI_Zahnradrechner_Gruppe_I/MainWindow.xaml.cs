using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_Zahnradrechner_Gruppe_I
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //AUßENVERZAHNUNG
        public Data Btn_ClickAußen(object sender, RoutedEventArgs e)
        {
            Data dat = new Data();
            //If-Abfrage Radiobutton Gerade
            if (rdbtn_gerade.IsChecked == true)
            {
                //If-Abfragen Zahlcheck der Eingaben
                string zahlCheckModul = txb_modul_außen.Text;
                string zahlCheckZähnezahl = txb_zaehnezahl_außen.Text;
                string zahlCheckBreite = txb_breite_außen.Text;

                if (Eingabecheck(zahlCheckModul) == true)
                {
                    txb_modul_außen.Background = Brushes.White;

                    if (Eingabecheck(zahlCheckZähnezahl) == true)
                    {
                        txb_zaehnezahl_außen.Background = Brushes.White;

                        if (Eingabecheck(zahlCheckBreite) == true)
                        {
                            txb_breite_außen.Background = Brushes.White;
                            //BERECHNUNGEN
<<<<<<< HEAD
                            double m = Convert.ToDouble(txb_modul.Text);
                            dat.setModul(m);
                            double z = Convert.ToDouble(txb_zähnezahl.Text);
                            dat.setZähnezahl(z);
                            double b = Convert.ToDouble(txb_breite.Text);
                            dat.setBreite(b);
=======
                            double m = Convert.ToDouble(txb_modul_außen.Text);
                            double z = Convert.ToDouble(txb_zaehnezahl_außen.Text);
                            double b = Convert.ToDouble(txb_breite_außen.Text);
>>>>>>> 52b6f34703ac06195a417a218a529127424d9beb
                            //Hier Material einfügen
                            //Hier Rundung einfügen
                            //Variablen für Material anlegen mit zugeordneten Werten

                            //ÜBERGABE
                            BerechnungenGeradeAußen(dat);
                        }
                        else if (Eingabecheck(zahlCheckBreite) == false)
                        {
                            MessageBox.Show("Sie müssen eine Zahl als Breite eingeben!");
                            txb_breite_außen.Background = Brushes.OrangeRed;
                        }
                    }
                    else if (Eingabecheck(zahlCheckZähnezahl) == false)
                    {
                        MessageBox.Show("Sie müssen eine Zahl als Zähnezahl eingeben!");
                        txb_zaehnezahl_außen.Background = Brushes.OrangeRed;
                    }
                }
                else if (Eingabecheck(zahlCheckModul) == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl als Modul eingeben!");
                    txb_modul_außen.Background = Brushes.OrangeRed;
                }
            }
            //If-Abfrage Radiobutton Schräg
            else if (rdbtn_schräg.IsChecked == true)
            {
                //If-Abfragen Zahlcheck der Eingaben
                string zahlCheckModul = txb_modul_außen.Text;
                string zahlCheckZähnezahl = txb_zaehnezahl_außen.Text;
                string zahlCheckBreite = txb_breite_außen.Text;
                string zahlCheckSchrägungswinkel = txb_schraegungswinkel.Text;

                if (Eingabecheck(zahlCheckModul) == true)
                {
                    txb_modul_außen.Background = Brushes.White;

                    if (Eingabecheck(zahlCheckZähnezahl) == true)
                    {
                        txb_zaehnezahl_außen.Background = Brushes.White;
                        if (Eingabecheck(zahlCheckBreite) == true)
                        {
                            txb_breite_außen.Background = Brushes.White;
                            if (Eingabecheck(zahlCheckSchrägungswinkel) == true)
                            {
                                txb_schraegungswinkel.Background = Brushes.White;

                                //BERECHNUNGEN
<<<<<<< HEAD
                                double m = Convert.ToDouble(txb_modul.Text);
                                dat.setModul(m);
                                double z = Convert.ToDouble(txb_zähnezahl.Text);
                                dat.setZähnezahl(z);
                                double b = Convert.ToDouble(txb_breite.Text);

=======
                                double m = Convert.ToDouble(txb_modul_außen.Text);
                                double z = Convert.ToDouble(txb_zaehnezahl_außen.Text);
                                double b = Convert.ToDouble(txb_breite_außen.Text);
>>>>>>> 52b6f34703ac06195a417a218a529127424d9beb
                                double schr = Convert.ToDouble(txb_schraegungswinkel.Text);

                                //Hier Material einfügen
                                //Hier Rundung einfügen
                                //Variablen für Material anlegen mit zugeordneten Werten

                                //ÜBERGABE
                                BerechnungenSchrägAußen(m, z, b, schr);
                            }
                            else if (Eingabecheck(zahlCheckSchrägungswinkel) == false)
                            {
                                MessageBox.Show("Sie müssen eine Zahl als Schrägungswinkel eingeben!");
                                txb_schraegungswinkel.Background = Brushes.OrangeRed;
                            }
                        }
                        else if (Eingabecheck(zahlCheckBreite) == false)
                        {
                            MessageBox.Show("Sie müssen eine Zahl als Breite eingeben!");
                            txb_breite_außen.Background = Brushes.OrangeRed;
                        }
                    }
                    else if (Eingabecheck(zahlCheckZähnezahl) == false)
                    {
                        MessageBox.Show("Sie müssen eine Zahl als Zähnezahl eingeben!");
                        txb_zaehnezahl_außen.Background = Brushes.OrangeRed;
                    }
                }
                else if (Eingabecheck(zahlCheckModul) == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl als Modul eingeben!");
                    txb_modul_außen.Background = Brushes.OrangeRed;
                }
            }
            return dat;
        }


        //INNENVERZAHNUNG
        public void Btn_ClickInnen(object sender, RoutedEventArgs e)
        {
            //If-Abfragen Zahlcheck der Eingaben
            string zahlCheckModul = txb_modul_innen.Text;
            string zahlCheckZähnezahl = txb_zaehnezahl_innen.Text;
            string zahlCheckBreite = txb_breite_innen.Text;

            if (Eingabecheck(zahlCheckModul) == true)
            {
                txb_modul_innen.Background = Brushes.White;

                if (Eingabecheck(zahlCheckZähnezahl) == true)
                {
                    txb_zaehnezahl_innen.Background = Brushes.White;

                    if (Eingabecheck(zahlCheckBreite) == true)
                    {
                        txb_breite_innen.Background = Brushes.White;

                        //BERECHNUNGEN

                        double m = Convert.ToDouble(txb_modul_innen.Text);
                        double z = Convert.ToDouble(txb_zaehnezahl_innen.Text);
                        double b = Convert.ToDouble(txb_breite_innen.Text);
                        const double dichteVergütungsstahl = 7.84;      //C35/C45
                        const double dichteNichtrostenderStahl = 7.0;   //X12CrNiS188
                        const double dichteKunststoff = 1.41;           //POM
                        const double dichteGusseisen = 7.2;             //GG
                        const double dichteMessing = 8.5;               //CuZn

                        double material = Convert.ToDouble(cmb_materialwahl.SelectedIndex);
                        //switch Abfrage für Material
                        switch (material)
                        {
                            case 1:
                                material = dichteVergütungsstahl;
                                break;

                            case 2:
                                material = dichteNichtrostenderStahl;
                                break;

                            case 3:
                                material = dichteKunststoff;
                                break;

                            case 4:
                                material = dichteGusseisen;
                                break;

                            case 5:
                                material = dichteMessing;
                                break;

                        }

                        //Hier Material einfügen
                        //Hier Rundung einfügen
                        //Variablen für Material anlegen mit zugeordneten Werten

                        //ÜBERGABE
                        BerechnungenGeradeInnen(m, z, b);
                    }
                    else if (Eingabecheck(zahlCheckBreite) == false)
                    {
                        MessageBox.Show("Sie müssen eine Zahl als Breite eingeben!");
                        txb_breite_innen.Background = Brushes.OrangeRed;
                    }
                }
                else if (Eingabecheck(zahlCheckZähnezahl) == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl als Zähnezahl eingeben!");
                    txb_zaehnezahl_innen.Background = Brushes.OrangeRed;
                }
            }
            else if (Eingabecheck(zahlCheckModul) == false)
            {
                MessageBox.Show("Sie müssen eine Zahl als Modul eingeben!");
                txb_modul_innen.Background = Brushes.OrangeRed;
            }
        }



        //Zahlcheck
        private bool Eingabecheck(string zahlCheck)
        {
            try
            {
                double eingabeZahl = double.Parse(zahlCheck);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }



        //Berechnungen //MÜSSEN ERWEITERT WERDEN
        private Data BerechnungenGeradeAußen(Data dat)
        {
            //If-Abfragen Korrekte Eingaben
            if (dat.getZähnezahl() % 1 == 0 && dat.getZähnezahl() >= 2 && dat.getModul() > 0 && dat.getBreite() > 0)
            {

                Berechnungen prg = new Berechnungen();
<<<<<<< HEAD
                txb_breite.Background = Brushes.White;
                txb_zähnezahl.Background = Brushes.White;
                txb_modul.Background = Brushes.White;
                //BERECHNUNGEN HIER EINFÜGEN
                
                double d = prg.Teilkreisdurchmesser_d(dat.getModul(), dat.getZähnezahl());
                txb_teilkreisdurchmesser.Text = Convert.ToString(Math.Round(d));
                double teilung = prg.Teilung_p(dat.getKreiszahl(), dat.getModul());
=======

                txb_breite_außen.Background = Brushes.White;
                txb_zaehnezahl_außen.Background = Brushes.White;
                txb_modul_außen.Background = Brushes.White;
                //BERECHNUNGEN HIER EINFÜGEN
                
                double modul = Convert.ToDouble(txb_modul_außen.Text);
                double zaehnezahl = Convert.ToDouble(txb_zaehnezahl_außen.Text);
                double breite = Convert.ToDouble(txb_breite_außen.Text);
                const double Kopfspielzahl = 0.167;
                const double normeingriffswinkel = 20 * Math.PI / 180;

          

                double d = prg.Teilkreisdurchmesser_d(modul, zaehnezahl);
                txb_teilkreisdurchmesser.Text = Convert.ToString(Math.Round(d));
                double teilung = prg.Teilung_p(Math.PI, modul);
>>>>>>> 52b6f34703ac06195a417a218a529127424d9beb
                txb_teilung.Text = Convert.ToString(Math.Round(teilung));
                double kopfspiel = prg.Kopfspiel_c(dat.getModul(), dat.getKopfspielzahl());
                txb_kopfspiel.Text = Convert.ToString(kopfspiel);
                double außenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_daa(d, dat.getModul());
                txb_kopfkreisdurchmesser.Text = Convert.ToString(außenKopfkreisdurchmesser);
                double außenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfa(d, dat.getModul(), kopfspiel);
                txb_fußkreisdurchmesser.Text = Convert.ToString(außenFußkreisdurchmesser);
                double zahnhöhe = prg.Zahnhöhe_h(dat.getModul(), kopfspiel);
                txb_zahnhoehe.Text = Convert.ToString(zahnhöhe);
                double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(dat.getModul());
                txb_zahnkopfhoehe.Text = Convert.ToString(zahnkopfhöhe);
                double zahnfüßhöhe = prg.Zahnfußhöhe_hf(dat.getModul(), kopfspiel);
                txb_zahnfußhoehe.Text = Convert.ToString(zahnfüßhöhe);
                double grundkreisdurchmesser = prg.Grundkreisdurchmesser_db(d, dat.getNormeingriffswinkel());
                txb_grundkreisdurchmesser.Text = Convert.ToString(grundkreisdurchmesser);
<<<<<<< HEAD
                double volumen = prg.Volumen_vg(außenKopfkreisdurchmesser, dat.getKreiszahl(), dat.getBreite());
                txb_volumen.Text = Convert.ToString(volumen);
                double masse = prg.masse_mg(dat.getMaterial(), volumen);
                txb_masse.Text = Convert.ToString(masse);
=======
                double volumen = prg.Volumen_v(außenKopfkreisdurchmesser, Math.PI, breite);
                txb_volumen.Text = Convert.ToString(volumen);

                // double masse = prg.masse_m(material, volumen);
                // txb_masse.Text = Convert.ToString(masse); 
>>>>>>> 52b6f34703ac06195a417a218a529127424d9beb
                // teilkreisdurchmesser.Content = d;
            }

            // Fehler: Falsche Werte
            else
            {
                if (dat.getZähnezahl() % 1 != 0 || dat.getZähnezahl() < 2)
                {
                    MessageBox.Show("Bitte eine ganzzahlige Zähnezahl über 2 eingeben!");
                    txb_zaehnezahl_außen.Background = Brushes.OrangeRed;
                }
                if (dat.getModul() <= 0)
                {
                    MessageBox.Show("Bitte Modul über 0 wählen!");
                    txb_modul_außen.Background = Brushes.OrangeRed;
                }
                if (dat.getBreite() <= 0)
                {
                    MessageBox.Show("Bitte Breite über 0 wählen!");
                    txb_breite_außen.Background = Brushes.OrangeRed;
                }
            }
            return dat;
        }

        private void BerechnungenSchrägAußen(double m, double z, double b, double schr)
        {
            //If-Abfragen Korrekte Eingaben
            if (z % 1 == 0 && z >= 2 && m > 0 && b > 0 && schr > 0 && schr < 90)
            {
                Berechnungen prg = new Berechnungen();

                txb_breite_außen.Background = Brushes.White;
                txb_zaehnezahl_außen.Background = Brushes.White;
                txb_modul_außen.Background = Brushes.White;
                txb_schraegungswinkel.Background = Brushes.White;


                //BERECHNUNGEN HIER EINFÜGEN
                double modul = Convert.ToDouble(txb_modul_außen.Text);
                double zaehnezahl = Convert.ToDouble(txb_zaehnezahl_außen.Text);
                double breite = Convert.ToDouble(txb_breite_außen.Text);
                const double Kopfspielzahl = 0.167;
                double schraegungswinkel = Convert.ToDouble(txb_schraegungswinkel.Text);

                double d = prg.Teilkreisdurchmesser_d(modul, zaehnezahl);
                txb_teilkreisdurchmesser.Text = Convert.ToString(d);
                double stirnmodul = prg.stirnmodul_mt(d, zaehnezahl);
                txb_stirnmodul.Text = Convert.ToString(stirnmodul);
                double normalmodul = prg.normalmodul_mn(stirnmodul, schraegungswinkel);
                //?
                double kopfspiel = prg.schrägKopfspiel_c(normalmodul, Kopfspielzahl);
                txb_kopfspiel.Text = Convert.ToString(kopfspiel);
                double stirnteilung = prg.stirnteilung_pt(Math.PI, d, zaehnezahl);
                txb_stirnteilung.Text = Convert.ToString(stirnteilung);
                double normalteilung = prg.normalteilung_pn(Math.PI, normalmodul);
                //?
                double kopfkreisdurchmesser = prg.kopfkreisdurchmesser_da(d, normalmodul);
                txb_kopfkreisdurchmesser.Text = Convert.ToString(kopfkreisdurchmesser);
                double zahnhöhe = prg.schrägZahnhöhe_h(normalmodul, kopfspiel);
                txb_zahnhoehe.Text = Convert.ToString(zahnhöhe);
                double zahnkopfhöhe = prg.schrägZahnkopfhöhe_ha(normalmodul);
                txb_zahnkopfhoehe.Text = Convert.ToString(zahnkopfhöhe);
                double zahnfußhöhe = prg.schrägZahnfußhöhe_hf(normalmodul, kopfspiel);
                txb_zahnfußhoehe.Text = Convert.ToString(zahnfußhöhe);
                double fußkreisdurchmesser = prg.schrägFußkreisdurchmesser_df(d, normalmodul, kopfspiel);
                txb_fußkreisdurchmesser.Text = Convert.ToString(fußkreisdurchmesser);
                double volumen = prg.schrägVolumen_v(kopfkreisdurchmesser, Math.PI, breite);
                txb_volumen.Text = Convert.ToString(volumen);

                // double masse = prg.schrägMasse_m(material, volumen);
                // txb_masse.Text = Convert.ToString(masse);
                // teilkreisdurchmesser.Content = d;
            }

            //Fehler: Falsch Werte
            else
            {
                if (z % 1 != 0 || z < 2)
                {
                    MessageBox.Show("Bitte eine ganzzahlige Zähnezahl über 2 eingeben!");
                    txb_zaehnezahl_außen.Background = Brushes.OrangeRed;
                }
                if (m <= 0)
                {
                    MessageBox.Show("Bitte Modul über 0 wählen!");
                    txb_modul_außen.Background = Brushes.OrangeRed;
                }
                if (b <= 0)
                {
                    MessageBox.Show("Bitte Breite über 0 wählen!");
                    txb_breite_außen.Background = Brushes.OrangeRed;
                }
                if (schr <= 0 || schr >= 90)
                {
                    MessageBox.Show("Bitte Schrägungswinkel größer 0° und kleiner 90° wählen!");
                    txb_schraegungswinkel.Background = Brushes.OrangeRed;
                }
            }
        }

        private void BerechnungenGeradeInnen(double m, double z, double b)
        {
            Berechnungen prg = new Berechnungen();

            //If-Abfragen Korrekte Eingaben
            if (z % 1 == 0 && z >= 2 && m > 0 && b > 0)
            {
                txb_breite_innen.Background = Brushes.White;
                txb_zaehnezahl_innen.Background = Brushes.White;
                txb_modul_innen.Background = Brushes.White;

                //BERECHNUNGEN HIER EINFÜGEN

                double modul = Convert.ToDouble(txb_modul_innen.Text);
                double zaehnezahl = Convert.ToDouble(txb_zaehnezahl_innen.Text);
                double breite = Convert.ToDouble(txb_breite_innen.Text);
                const double Kopfspielzahl = 0.167;

                double d = prg.Teilkreisdurchmesser_d(modul, zaehnezahl);
                txb_teilkreisdurchmesser1.Text = Convert.ToString(d);
                double teilung = prg.Teilung_p(Math.PI, modul);
                txb_teilung1.Text = Convert.ToString(teilung);
                double kopfspiel = prg.Kopfspiel_c(modul, Kopfspielzahl);
                txb_Kopfspiel.Text = Convert.ToString(kopfspiel);
                double innenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_dai(d, modul);
                txb_Kopfkreisdurchmesser.Text = Convert.ToString(innenKopfkreisdurchmesser);
                double innenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfi(d, modul, kopfspiel);
                txb_Fusskreisduchmesser.Text = Convert.ToString(innenFußkreisdurchmesser);
                double zahnhöhe = prg.Zahnhöhe_h(modul, kopfspiel);
                txb_zahnhoehe1.Text = Convert.ToString(zahnhöhe);
                double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(modul);
                txb_zahnkopfhoehe1.Text = Convert.ToString(zahnkopfhöhe);
                double zahnfüßhöhe = prg.Zahnfußhöhe_hf(modul, kopfspiel);
                txb_zahnfusshohe.Text = Convert.ToString(zahnfüßhöhe);
                // teilkreisdurchmesser.Content = d;
            }

            // Fehler: Falsche Werte
            else
            {
                if (z % 1 != 0 || z < 2)
                {
                    MessageBox.Show("Bitte eine ganzzahlige Zähnezahl über 2 eingeben!");
                    txb_zaehnezahl_innen.Background = Brushes.OrangeRed;
                }
                if (m <= 0)
                {
                    MessageBox.Show("Bitte Modul über 0 wählen!");
                    txb_modul_innen.Background = Brushes.OrangeRed;
                }
                if (b <= 0)
                {
                    MessageBox.Show("Bitte Breite über 0 wählen!");
                    txb_breite_innen.Background = Brushes.OrangeRed;
                }
            }
        }



        //Programm beenden
        private void btn_beenden_ClickAußen(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_beenden_ClickInnen(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

}





//Button der zu den Ergebnissen fürt
//Außenverzahnung Az = new Außenverzahnung();
//Az.geradverzahnungAußen();

//Schrägverzahnung Sz = new Schrägverzahnung();
//Sz.schrägverzahnungAußen();