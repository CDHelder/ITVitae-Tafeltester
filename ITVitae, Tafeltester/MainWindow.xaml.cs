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

namespace ITVitae__Tafeltester
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
        private void Button_MaakSommen_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Label_1X.Content = "";
                Label_2X.Content = "";
                Label_3X.Content = "";
                Label_4X.Content = "";
                Label_5X.Content = "";

                List<int> AlleNummers = new List<int>();
                Random Random = new Random();
                int Nummers = 0;
                for (int i = 0; i < 5; i++)
                {
                    do
                    {
                        Nummers = Random.Next(1, Convert.ToInt32(Textbox_MaxHoogteSommen.Text));
                    } while (AlleNummers.Contains(Nummers));
                    AlleNummers.Add(Nummers);

                    if (Label_1X.Content == "")
                    {
                        Label_1X.Content = "1 X " + Nummers + " = ";
                    }
                    else if (Label_2X.Content == "")
                    {
                        Label_2X.Content = "2 X " + Nummers + " = ";
                    }
                    else if (Label_3X.Content == "")
                    {
                        Label_3X.Content = "3 X " + Nummers + " = ";
                    }
                    else if (Label_4X.Content == "")
                    {
                        Label_4X.Content = "4 X " + Nummers + " = ";
                    }
                    else if (Label_5X.Content == "")
                    {
                        Label_5X.Content = "5 X " + Nummers + " = ";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Voer een getal in voor maximale hoogte van de sommen van minimaal 5");
            }
        }
        private void Button_ShowScore_Click(object sender, RoutedEventArgs e)
        {
            bool Vraag1;
            bool Vraag2;
            bool Vraag3;
            bool Vraag4;
            bool Vraag5;

            string RandomNumber1X;
            string RandomNumber2X;
            string RandomNumber3X;
            string RandomNumber4X;
            string RandomNumber5X;

            RandomNumber1X = (string)Label_1X.Content;
            RandomNumber1X = RandomNumber1X.Remove(0, 1);
            RandomNumber1X = RandomNumber1X.Replace("=", "");
            RandomNumber1X = RandomNumber1X.Replace("X", "");
            RandomNumber1X = RandomNumber1X.Trim();

            /*
            Hoe maak ik van die hele tekst hierboven een method die een string waarde terug geeft
            zodat ik alles kan copy pasten
            +
            Maak een stuk waarme het antwoord wordt gecontroleerd en de tekst goed of fout weergeeft
            +
            Stop het in een try catch statement met een messagebox om errrors te verkomen met letters
            en geen antwoorden invullen
             */
        }
    }
}
