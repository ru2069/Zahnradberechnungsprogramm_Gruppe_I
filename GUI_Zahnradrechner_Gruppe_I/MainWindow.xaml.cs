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
        public void Button_Click(object sender, RoutedEventArgs e)
        {

            //If-Abfrage Radiobutton Gerade
            if (rdbtn_gerade.IsChecked == true)
            {
                //If-Abfragen Zahlcheck der Eingaben
                string zahlCheckModul = txb_modul.Text;
                string zahlCheckZähnezahl = txb_zähnezahl.Text;

                if (eingabecheckmodul(zahlCheckModul) == true)
                {

                    if (eingabecheckzähnezahl(zahlCheckZähnezahl) == true)
                    {
                        double m = Convert.ToDouble(txb_modul.Text);
                        double z = Convert.ToDouble(txb_zähnezahl.Text);

                        BerechnungenGeradeAußen(m, z);
                        
                    }

                    else if (eingabecheckzähnezahl(zahlCheckZähnezahl) == false)
                    {
                        MessageBox.Show("Sie müssen eine Zahl als Zähnezahl eingeben!");
                    }

                }

                else if (eingabecheckmodul(zahlCheckModul) == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl als Modul eingeben!");
                }

            }

            //If-Abfrage Radiobutton Schräg
            else if (rdbtn_schräg.IsChecked == true)
            {

            }
        }


        //INNENVERZAHNUNG
        private void btn_ClickInnen(object sender, RoutedEventArgs e)
        {

        }


        //Zahlcheck
        private bool eingabecheckmodul(string zahlCheckModul)
        {
            try
            {
                double eingabeZahl = double.Parse(zahlCheckModul);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private bool eingabecheckzähnezahl(string zahlCheckZähnezahl)
        {
            try
            {
                double eingabeZahl = double.Parse(zahlCheckZähnezahl);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Berechnungen
        private void BerechnungenGeradeAußen(double m, double z)
        {
            //If-Abfragen Korrekte Eingaben
            if (z % 1 == 0 && z >= 2 && m > 0)
            {
                //BERECHNUNGEN HIER EINFÜGEN
                double d = m * z;
                teilkreisdurchmesser.Content = d;
            }
            else
            {
                if (z % 1 != 0)
                {
                    MessageBox.Show("Bitte eine ganzzahlige Zähnezahl eingeben!");
                }
                if (z < 2)
                {
                    MessageBox.Show("Bitte eine Zähnezahl über 2 eingeben!");
                }
                if (m <= 0)
                {
                    MessageBox.Show("Bitte Modul über 0 wählen!");
                }
            }
        }


    }
}





//Button der zu den Ergebnissen fürt
//Außenverzahnung Az = new Außenverzahnung();
//Az.geradverzahnungAußen();

//Schrägverzahnung Sz = new Schrägverzahnung();
//Sz.schrägverzahnungAußen();