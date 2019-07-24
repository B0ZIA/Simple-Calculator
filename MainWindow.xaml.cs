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

namespace Calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzialania = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(1);
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(2);
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(3);
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(4);
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(5);
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(6);
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(7);
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(8);
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(9);
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(0);
        }

        private void BWynik_Click(object sender, RoutedEventArgs e)
        {
            switch (RodzajDzialania)
            {
                case ('+'):
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    if (LiczbaDruga == "0")
                    {
                        tbWynik.Text = "Nie mozna dzielic przez zero!";
                        break;
                    }
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }

            LiczbaPierwsza = "";
            LiczbaDruga = "";
            RodzajDzialania = ' ';
        }

        private void BDodawanie_Click(object sender, RoutedEventArgs e)
        {
            RodzajDzialania = '+';
            tbWynik.Text = "";
        }

        private void BOdejmowanie_Click(object sender, RoutedEventArgs e)
        {
            RodzajDzialania = '-';
            tbWynik.Text = "";
        }

        private void BMnozenie_Click(object sender, RoutedEventArgs e)
        {
            RodzajDzialania = '*';
            tbWynik.Text = "";
        }

        private void BDzielenie_Click(object sender, RoutedEventArgs e)
        {
            RodzajDzialania = '/';
            tbWynik.Text = "";
        }

        private void Dzialanie(int liczba)
        {
            if (RodzajDzialania == ' ')
            {
                LiczbaPierwsza += liczba;
                tbWynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                tbWynik.Text = LiczbaDruga;
            }
            
        }
    }
}
