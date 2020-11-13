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

namespace GUI
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
        
        TabControl tbControl;

        private void tbCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            tbControl = (sender as TabControl);
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            TabItem newTabItem = new TabItem
            {
                Header = "Geradverzahnung Außen",
            };
            tbControl.Items.Add(newTabItem);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TabItem newTabItem = new TabItem
            {
                Header = "Geradverzahnung Innen",
            };
            tbControl.Items.Add(newTabItem);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            TabItem newTabItem = new TabItem
            {
                Header = "Geradverzahnung Innen",
            };
            tbControl.Items.Add(newTabItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbControl.Items.Remove(tbControl.SelectedItem);
        }
    }
}
