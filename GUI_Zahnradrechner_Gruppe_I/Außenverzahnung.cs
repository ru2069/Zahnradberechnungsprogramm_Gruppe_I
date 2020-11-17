using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_Zahnradrechner_Gruppe_I
{
    class Außenverzahnung
    {
        public void geradverzahnungAußen()
        {
            string zahlCheckModul = modul.Text;
            string zahlCheckZähnezahl = zähnezahl.Text;

            if (eingabecheckmodul(zahlCheckModul) == true)
            {

                if (eingabecheckzähnezahl(zahlCheckZähnezahl) == true)
                {
                    //If geradezahlige Zähnezal
                    double m = Convert.ToDouble(modul.Text);
                    double z = Convert.ToDouble(zähnezahl.Text);

                    double d = m * z;
                    teilkreisdurchmesser.Content = d;
                    //else if
                    //Fehler
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
    }
}
