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
        public void Btn_ClickAußen(object sender, RoutedEventArgs e)
        {
            //If-Abfrage Radiobutton Gerade
            if (rdbtn_gerade.IsChecked == true)
            {
                //If-Abfragen Zahlcheck der Eingaben
                string zahlCheckModul = txb_modul.Text;
                string zahlCheckZähnezahl = txb_zähnezahl.Text;
                string zahlCheckBreite = txb_breite.Text;

                if (Eingabecheck(zahlCheckModul) == true)
                {
                    txb_modul.Background = Brushes.White;

                    if (Eingabecheck(zahlCheckZähnezahl) == true)
                    {
                        txb_zähnezahl.Background = Brushes.White;

                        if (Eingabecheck(zahlCheckBreite) == true)
                        {
                            txb_breite.Background = Brushes.White;
                            //BERECHNUNGEN
                            double m = Convert.ToDouble(txb_modul.Text);
                            double z = Convert.ToDouble(txb_zähnezahl.Text);
                            double b = Convert.ToDouble(txb_breite.Text);
                            //Hier Material einfügen
                            //Hier Rundung einfügen
                            //Variablen für Material anlegen mit zugeordneten Werten

                            //ÜBERGABE
                            BerechnungenGeradeAußen(m, z, b);
                        }
                        else if (Eingabecheck(zahlCheckBreite) == false)
                        {
                            MessageBox.Show("Sie müssen eine Zahl als Breite eingeben!");
                            txb_breite.Background = Brushes.OrangeRed;
                        }
                    }
                    else if (Eingabecheck(zahlCheckZähnezahl) == false)
                    {
                        MessageBox.Show("Sie müssen eine Zahl als Zähnezahl eingeben!");
                        txb_zähnezahl.Background = Brushes.OrangeRed;
                    }
                }
                else if (Eingabecheck(zahlCheckModul) == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl als Modul eingeben!");
                    txb_modul.Background = Brushes.OrangeRed;
                }
            }
            //If-Abfrage Radiobutton Schräg
            else if (rdbtn_schräg.IsChecked == true)
            {
                //If-Abfragen Zahlcheck der Eingaben
                string zahlCheckModul = txb_modul.Text;
                string zahlCheckZähnezahl = txb_zähnezahl.Text;
                string zahlCheckBreite = txb_breite.Text;
                string zahlCheckSchrägungswinkel = txb_schraegungswinkel.Text;

                if (Eingabecheck(zahlCheckModul) == true)
                {
                    txb_modul.Background = Brushes.White;

                    if (Eingabecheck(zahlCheckZähnezahl) == true)
                    {
                        txb_zähnezahl.Background = Brushes.White;
                        if (Eingabecheck(zahlCheckBreite) == true)
                        {
                            txb_breite.Background = Brushes.White;
                            if (Eingabecheck(zahlCheckSchrägungswinkel) == true)
                            {
                                txb_schraegungswinkel.Background = Brushes.White;

                                //BERECHNUNGEN
                                double m = Convert.ToDouble(txb_modul.Text);
                                double z = Convert.ToDouble(txb_zähnezahl.Text);
                                double b = Convert.ToDouble(txb_breite.Text);
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
                            txb_breite.Background = Brushes.OrangeRed;
                        }
                    }
                    else if (Eingabecheck(zahlCheckZähnezahl) == false)
                    {
                        MessageBox.Show("Sie müssen eine Zahl als Zähnezahl eingeben!");
                        txb_zähnezahl.Background = Brushes.OrangeRed;
                    }
                }
                else if (Eingabecheck(zahlCheckModul) == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl als Modul eingeben!");
                    txb_modul.Background = Brushes.OrangeRed;
                }
            }
        }


        //INNENVERZAHNUNG
        private void Btn_ClickInnen(object sender, RoutedEventArgs e)
        {
            //If-Abfragen Zahlcheck der Eingaben
            string zahlCheckModul = textbox_modul.Text;
            string zahlCheckZähnezahl = textbox_zähnezahl.Text;
            string zahlCheckBreite = textbox_breite.Text;

            if (Eingabecheck(zahlCheckModul) == true)
            {
                textbox_modul.Background = Brushes.White;

                if (Eingabecheck(zahlCheckZähnezahl) == true)
                {
                    textbox_zähnezahl.Background = Brushes.White;

                    if (Eingabecheck(zahlCheckBreite) == true)
                    {
                        textbox_breite.Background = Brushes.White;
                        //BERECHNUNGEN
                        double m = Convert.ToDouble(textbox_modul.Text);
                        double z = Convert.ToDouble(textbox_zähnezahl.Text);
                        double b = Convert.ToDouble(textbox_breite.Text);
                        //Hier Material einfügen
                        //Hier Rundung einfügen
                        //Variablen für Material anlegen mit zugeordneten Werten

                        //ÜBERGABE
                        BerechnungenGeradeInnen(m, z, b);
                    }
                    else if (Eingabecheck(zahlCheckBreite) == false)
                    {
                        MessageBox.Show("Sie müssen eine Zahl als Breite eingeben!");
                        textbox_breite.Background = Brushes.OrangeRed;
                    }
                }
                else if (Eingabecheck(zahlCheckZähnezahl) == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl als Zähnezahl eingeben!");
                    textbox_zähnezahl.Background = Brushes.OrangeRed;
                }
            }
            else if (Eingabecheck(zahlCheckModul) == false)
            {
                MessageBox.Show("Sie müssen eine Zahl als Modul eingeben!");
                textbox_modul.Background = Brushes.OrangeRed;
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
        private void BerechnungenGeradeAußen(double m, double z, double b)
        {
            //If-Abfragen Korrekte Eingaben
            if (z % 1 == 0 && z >= 2 && m > 0 && b > 0)
            {

                Berechnungen prg = new Berechnungen();

                txb_breite.Background = Brushes.White;
                txb_zähnezahl.Background = Brushes.White;
                txb_modul.Background = Brushes.White;
                //BERECHNUNGEN HIER EINFÜGEN
                
                double d = prg.Teilkreisdurchmesser_d(modul, zähnezahl);
                txb_teilkreisdurchmesser.Text = Convert.ToString(Math.Round(d));
                double teilung = prg.Teilung_p(Kreiszahl, modul);
                txb_teilung.Text = Convert.ToString(Math.Round(teilung));
                double kopfspiel = prg.Kopfspiel_c(modul, Kopfspielzahl);
                txb_kopfspiel.Text = Convert.ToString(kopfspiel);
                double außenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_daa(teilkreisdurchmesser, modul);
                
                double außenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfa(teilkreisdurchmesser, modul, kopfspiel);

                double zahnhöhe = prg.Zahnhöhe_h(modul, kopfspiel);

                double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(modul);

                double zahnfüßhöhe = prg.Zahnfußhöhe_hf(modul, kopfspiel);

                double grundkreisdurchmesser = prg.Grundkreisdurchmesser_db(teilkreisdurchmesser, normeingriffswinkel);

                double volumen = prg.Volumen_v(außenKopfkreisdurchmesser, Kreiszahl, breite);

                double masse = prg.masse_m(material, volumen);

                // teilkreisdurchmesser.Content = d;
            }

            // Fehler: Falsche Werte
            else
            {
                if (z % 1 != 0 || z < 2)
                {
                    MessageBox.Show("Bitte eine ganzzahlige Zähnezahl über 2 eingeben!");
                    txb_zähnezahl.Background = Brushes.OrangeRed;
                }
                if (m <= 0)
                {
                    MessageBox.Show("Bitte Modul über 0 wählen!");
                    txb_modul.Background = Brushes.OrangeRed;
                }
                if (b <= 0)
                {
                    MessageBox.Show("Bitte Breite über 0 wählen!");
                    txb_breite.Background = Brushes.OrangeRed;
                }
            }
        }

        private void BerechnungenSchrägAußen(double m, double z, double b, double schr)
        {
            //If-Abfragen Korrekte Eingaben
            if (z % 1 == 0 && z >= 2 && m > 0 && b > 0 && schr > 0 && schr < 90)
            {
                Berechnungen prg = new Berechnungen();

                txb_breite.Background = Brushes.White;
                txb_zähnezahl.Background = Brushes.White;
                txb_modul.Background = Brushes.White;
                txb_schraegungswinkel.Background = Brushes.White;


                //BERECHNUNGEN HIER EINFÜGEN
                double modul = prg.Teilkreisdurchmesser_d(modul, zähnezahl);

                double stirnmodul = prg.stirnmodul_mt(teilkreisdurchmesser, zähnezahl);

                double normalmodul = prg.normalmodul_mn(stirnmodul, Schrägungswinkel);

                double kopfspiel = prg.schrägKopfspiel_c(normalmodul, Kopfspielzahl);

                double stirnteilung = prg.stirnteilung_pt(Kreiszahl, teilkreisdurchmesser, zähnezahl);

                double normalteilung = prg.normalteilung_pn(Kreiszahl, normalmodul);

                double kopfkreisdurchmesser = prg.kopfkreisdurchmesser_da(teilkreisdurchmesser, normalmodul);

                double zahnhöhe = prg.schrägZahnhöhe_h(normalmodul, kopfspiel);

                double zahnkopfhöhe = prg.schrägZahnkopfhöhe_ha(normalmodul);

                double zahnfußhöhe = prg.schrägZahnfußhöhe_hf(normalmodul, kopfspiel);

                double fußkreisdurchmesser = prg.schrägFußkreisdurchmesser_df(teilkreisdurchmesser, normalmodul, kopfspiel);

                double volumen = prg.schrägVolumen_v(kopfkreisdurchmesser, Kreiszahl, breite);

                double masse = prg.schrägMasse_m(material, volumen);

                // teilkreisdurchmesser.Content = d;
            }

            //Fehler: Falsch Werte
            else
            {
                if (z % 1 != 0 || z < 2)
                {
                    MessageBox.Show("Bitte eine ganzzahlige Zähnezahl über 2 eingeben!");
                    txb_zähnezahl.Background = Brushes.OrangeRed;
                }
                if (m <= 0)
                {
                    MessageBox.Show("Bitte Modul über 0 wählen!");
                    txb_modul.Background = Brushes.OrangeRed;
                }
                if (b <= 0)
                {
                    MessageBox.Show("Bitte Breite über 0 wählen!");
                    txb_breite.Background = Brushes.OrangeRed;
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
                textbox_breite.Background = Brushes.White;
                textbox_zähnezahl.Background = Brushes.White;
                textbox_modul.Background = Brushes.White;
                //BERECHNUNGEN HIER EINFÜGEN
                double modul = prg.Teilkreisdurchmesser_d(teilkreisdurchmesser, zähnezahl);

                double teilung = prg.Teilung_p(Kreiszahl, modul);

                double kopfspiel = prg.Kopfspiel_c(modul, Kopfspielzahl);

                double innenKopfkreisdurchmesser = prg.Kopfkreisdurchmesser_dai(teilkreisdurchmesser, modul);

                double innenFußkreisdurchmesser = prg.Fußkreisdurchmesser_dfi(teilkreisdurchmesser, modul, kopfspiel);

                double zahnhöhe = prg.Zahnhöhe_h(modul, kopfspiel);

                double zahnkopfhöhe = prg.Zahnkopfhöhe_ha(modul);

                double zahnfüßhöhe = prg.Zahnfußhöhe_hf(modul, kopfspiel);

                // teilkreisdurchmesser.Content = d;
            }

            // Fehler: Falsche Werte
            else
            {
                if (z % 1 != 0 || z < 2)
                {
                    MessageBox.Show("Bitte eine ganzzahlige Zähnezahl über 2 eingeben!");
                    textbox_zähnezahl.Background = Brushes.OrangeRed;
                }
                if (m <= 0)
                {
                    MessageBox.Show("Bitte Modul über 0 wählen!");
                    textbox_modul.Background = Brushes.OrangeRed;
                }
                if (b <= 0)
                {
                    MessageBox.Show("Bitte Breite über 0 wählen!");
                    textbox_breite.Background = Brushes.OrangeRed;
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