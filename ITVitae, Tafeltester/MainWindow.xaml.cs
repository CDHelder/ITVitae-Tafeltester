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
            AllesVerstoppen();

            Label_Sommen.Content = "";
            LabelCijfer.Content = "";

        }
        private void Button_MaakSommen_Click(object sender, RoutedEventArgs e)
        {
            AllesCleanen();
            Textblokkenverstoppen();

            if (Convert.ToInt32(Textbox_MaxHoogteSommen.Text) <= Convert.ToInt32(TextboxHoeveelheidVragen.Text))
            {
                MessageBox.Show("Zorg ervoor dat de maximale hoogte groter is dan de hoeveelheid vragen");
                return;
            }
            else
            {

                try
                {
                    List<int> AlleNummers = new List<int>();
                    Random Random = new Random();
                    int Nummers = 0;

                    Label[] InfoLabels = new[] {Label_1X, Label_2X, Label_3X, Label_4X, Label_5X, Label_6X, Label_7X,
                        Label_8X, Label_9X, Label_10X, Label_11X, Label_12X, Label_13X, Label_14X, Label_15X, Label_16X, Label_17X,
                        Label_18X, Label_19X, Label_20X,};

                    for (int i = 0; i < Convert.ToInt32(TextboxHoeveelheidVragen.Text); i++)
                    {
                        do
                        {
                            Nummers = Random.Next(1, Convert.ToInt32(Textbox_MaxHoogteSommen.Text));
                        } while (AlleNummers.Contains(Nummers));
                        AlleNummers.Add(Nummers);

                        /*
                        foreach (var Label in InfoLabels)
                        {
                            Label.Content = ((Array.IndexOf(InfoLabels, Label) + 1) + " X " + Nummers + " = ").ToString();
                        }
                        
                        Door de foreach loop gaat hij door alle labels in de array heen
                        Ik wil dat hij eentje aanpast en dan de volgende maar dat ik ook toegang heb tot de .Content om de tekst te veranderen
                        */

                        VragenLatenZien();

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
                        else if (Label_6X.Content == "")
                        {
                            Label_6X.Content = "6 X " + Nummers + " = ";
                        }
                        else if (Label_7X.Content == "")
                        {
                            Label_7X.Content = "7 X " + Nummers + " = ";
                        }
                        else if (Label_8X.Content == "")
                        {
                            Label_8X.Content = "8 X " + Nummers + " = ";
                        }
                        else if (Label_9X.Content == "")
                        {
                            Label_9X.Content = "9 X " + Nummers + " = ";
                        }
                        else if (Label_10X.Content == "")
                        {
                            Label_10X.Content = "10 X " + Nummers + " = ";
                        }
                        else if (Label_11X.Content == "")
                        {
                            Label_11X.Content = "11 X " + Nummers + " = ";
                        }
                        else if (Label_12X.Content == "")
                        {
                            Label_12X.Content = "12 X " + Nummers + " = ";
                        }
                        else if (Label_13X.Content == "")
                        {
                            Label_13X.Content = "13 X " + Nummers + " = ";
                        }
                        else if (Label_14X.Content == "")
                        {
                            Label_14X.Content = "14 X " + Nummers + " = ";
                        }
                        else if (Label_15X.Content == "")
                        {
                            Label_15X.Content = "15 X " + Nummers + " = ";
                        }
                        else if (Label_16X.Content == "")
                        {
                            Label_16X.Content = "16 X " + Nummers + " = ";
                        }
                        else if (Label_17X.Content == "")
                        {
                            Label_17X.Content = "17 X " + Nummers + " = ";
                        }
                        else if (Label_18X.Content == "")
                        {
                            Label_18X.Content = "18 X " + Nummers + " = ";
                        }
                        else if (Label_19X.Content == "")
                        {
                            Label_19X.Content = "19 X " + Nummers + " = ";
                        }
                        else if (Label_20X.Content == "")
                        {
                            Label_20X.Content = "20 X " + Nummers + " = ";
                        }
                        
                    }
                }
                catch
                {
                    if (TextboxHoeveelheidVragen.Text == "")
                    {
                        MessageBox.Show("Voer een getal in voor de maximale hoogte van de sommen van minimaal de hoeveelheid vragen die wilt hebben");
                    }
                    else
                    {
                        MessageBox.Show("Voer een getal in voor de maximale hoogte van de sommen van minimaal " + TextboxHoeveelheidVragen.Text);
                    }
                }
            }
        }
        private void Button_ShowScore_Click(object sender, RoutedEventArgs e)
        {
            double GoeieAntwoorden = 0;

            string RandomNumber1X = "";
            string RandomNumber2X = "";
            string RandomNumber3X = "";
            string RandomNumber4X = "";
            string RandomNumber5X = "";
            string RandomNumber6X = "";
            string RandomNumber7X = "";
            string RandomNumber8X = "";
            string RandomNumber9X = "";
            string RandomNumber10X = "";
            string RandomNumber11X = "";
            string RandomNumber12X = "";
            string RandomNumber13X = "";
            string RandomNumber14X = "";
            string RandomNumber15X = "";
            string RandomNumber16X = "";
            string RandomNumber17X = "";
            string RandomNumber18X = "";
            string RandomNumber19X = "";
            string RandomNumber20X = "";
            try
            {
                int VraagNummer = 0;

                AntwoordChecken(RandomNumber1X, Label_1X, Textbox_1X, LabelGoF1);
                AntwoordChecken(RandomNumber2X, Label_2X, Textbox_2X, LabelGoF2);
                AntwoordChecken(RandomNumber3X, Label_3X, Textbox_3X, LabelGoF3);
                AntwoordChecken(RandomNumber4X, Label_4X, Textbox_4X, LabelGoF4);
                AntwoordChecken(RandomNumber5X, Label_5X, Textbox_5X, LabelGoF5);
                AntwoordChecken(RandomNumber6X, Label_6X, Textbox_6X, LabelGoF6);
                AntwoordChecken(RandomNumber7X, Label_7X, Textbox_7X, LabelGoF7);
                AntwoordChecken(RandomNumber8X, Label_8X, Textbox_8X, LabelGoF8);
                AntwoordChecken(RandomNumber9X, Label_9X, Textbox_9X, LabelGoF9);
                AntwoordChecken(RandomNumber10X, Label_10X, Textbox_10X, LabelGoF10);
                AntwoordChecken(RandomNumber11X, Label_11X, Textbox_11X, LabelGoF11);
                AntwoordChecken(RandomNumber12X, Label_12X, Textbox_12X, LabelGoF12);
                AntwoordChecken(RandomNumber13X, Label_13X, Textbox_13X, LabelGoF13);
                AntwoordChecken(RandomNumber14X, Label_14X, Textbox_14X, LabelGoF14);
                AntwoordChecken(RandomNumber15X, Label_15X, Textbox_15X, LabelGoF15);
                AntwoordChecken(RandomNumber16X, Label_16X, Textbox_16X, LabelGoF16);
                AntwoordChecken(RandomNumber17X, Label_17X, Textbox_17X, LabelGoF17);
                AntwoordChecken(RandomNumber18X, Label_18X, Textbox_18X, LabelGoF18);
                AntwoordChecken(RandomNumber19X, Label_19X, Textbox_19X, LabelGoF19);
                AntwoordChecken(RandomNumber20X, Label_20X, Textbox_20X, LabelGoF20);

                void AntwoordChecken(string randomNumber, ContentControl contentControl, TextBox textBox, Label label)
                {
                    VraagNummer += 1;
                    if (textBox.Text != "")
                    {
                        randomNumber = (string)contentControl.Content;
                        randomNumber = randomNumber.Remove(0, 1);
                        randomNumber = randomNumber.Replace("=", "");
                        randomNumber = randomNumber.Replace("X", "");
                        randomNumber = randomNumber.Trim();
                        if (VraagNummer * Convert.ToInt32(randomNumber) == Convert.ToInt32(textBox.Text))
                        {
                            label.Content = "Goed";
                            GoeieAntwoorden += 1;
                        }
                        else
                        {
                            label.Content = "Fout";
                        }
                    }
                }

                /*
                Label[] InfoLabels = new[] {Label_1X, Label_2X, Label_3X, Label_4X, Label_5X, Label_6X, Label_7X,
                        Label_8X, Label_9X, Label_10X, Label_11X, Label_12X, Label_13X, Label_14X, Label_15X, Label_16X, Label_17X,
                        Label_18X, Label_19X, Label_20X,};

                TextBox[] InvoerTextBlokken = new[] { Textbox_1X, Textbox_2X, Textbox_3X, Textbox_4X, Textbox_5X, Textbox_6X, Textbox_7X, Textbox_8X,
                Textbox_9X, Textbox_10X, Textbox_11X, Textbox_12X, Textbox_13X, Textbox_14X, Textbox_15X, Textbox_16X, Textbox_17X, Textbox_18X,
                Textbox_19X, Textbox_20X};

                Label[] GoedOfFoutLabel = new[] {LabelGoF1, LabelGoF2, LabelGoF3, LabelGoF4, LabelGoF5, LabelGoF6
                    , LabelGoF7, LabelGoF8, LabelGoF9, LabelGoF10, LabelGoF11, LabelGoF12, LabelGoF13, LabelGoF14,
                    LabelGoF15, LabelGoF16, LabelGoF17, LabelGoF18, LabelGoF19 , LabelGoF20};

                foreach (var infolabel in InfoLabels)
                {
                    AntwoordChecken(RandomNumber1X, infolabel, Textbox_1X, LabelGoF1);
                }

                */

                /*
                //Hier zijn de blokken die ik eerst had
                //Checken of 2e vraag klopt
                if (Textbox_2X.Text != "")
                {
                    RandomNumber2X = (string)Label_2X.Content;
                    RandomNumber2X = RandomNumber2X.Remove(0, 1);
                    RandomNumber2X = RandomNumber2X.Replace("=", "");
                    RandomNumber2X = RandomNumber2X.Replace("X", "");
                    RandomNumber2X = RandomNumber2X.Trim();
                    if (2 * Convert.ToInt32(RandomNumber2X) == Convert.ToInt32(Textbox_2X.Text))
                    {
                        LabelGoF2.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF2.Content = "Fout";
                    }
                }

                //Checken of 3e vraag klopt
                if (Textbox_3X.Text != "")
                {
                    RandomNumber3X = (string)Label_3X.Content;
                    RandomNumber3X = RandomNumber3X.Remove(0, 1);
                    RandomNumber3X = RandomNumber3X.Replace("=", "");
                    RandomNumber3X = RandomNumber3X.Replace("X", "");
                    RandomNumber3X = RandomNumber3X.Trim();
                    if (3 * Convert.ToInt32(RandomNumber3X) == Convert.ToInt32(Textbox_3X.Text))
                    {
                        LabelGoF3.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF3.Content = "Fout";
                    }
                }

                //Checken of 4e vraag klopt
                if (Textbox_4X.Text != "")
                {
                    RandomNumber4X = (string)Label_4X.Content;
                    RandomNumber4X = RandomNumber4X.Remove(0, 1);
                    RandomNumber4X = RandomNumber4X.Replace("=", "");
                    RandomNumber4X = RandomNumber4X.Replace("X", "");
                    RandomNumber4X = RandomNumber4X.Trim();
                    if (4 * Convert.ToInt32(RandomNumber4X) == Convert.ToInt32(Textbox_4X.Text))
                    {
                        LabelGoF4.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF4.Content = "Fout";
                    }
                }

                //Checken of 5e vraag klopt
                if (Textbox_5X.Text != "")
                {
                    RandomNumber5X = (string)Label_5X.Content;
                    RandomNumber5X = RandomNumber5X.Remove(0, 1);
                    RandomNumber5X = RandomNumber5X.Replace("=", "");
                    RandomNumber5X = RandomNumber5X.Replace("X", "");
                    RandomNumber5X = RandomNumber5X.Trim();
                    if (5 * Convert.ToInt32(RandomNumber5X) == Convert.ToInt32(Textbox_5X.Text))
                    {
                        LabelGoF5.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF5.Content = "Fout";
                    }
                }

                //Checken of 6e vraag klopt
                if (Textbox_6X.Text != "")
                {
                    RandomNumber6X = (string)Label_6X.Content;
                    RandomNumber6X = RandomNumber6X.Remove(0, 1);
                    RandomNumber6X = RandomNumber6X.Replace("=", "");
                    RandomNumber6X = RandomNumber6X.Replace("X", "");
                    RandomNumber6X = RandomNumber6X.Trim();
                    if (6 * Convert.ToInt32(RandomNumber6X) == Convert.ToInt32(Textbox_6X.Text))
                    {
                        LabelGoF6.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF6.Content = "Fout";
                    }
                }

                //Checken of 7e vraag klopt
                if (Textbox_7X.Text != "")
                {
                    RandomNumber7X = (string)Label_7X.Content;
                    RandomNumber7X = RandomNumber7X.Remove(0, 1);
                    RandomNumber7X = RandomNumber7X.Replace("=", "");
                    RandomNumber7X = RandomNumber7X.Replace("X", "");
                    RandomNumber7X = RandomNumber7X.Trim();
                    if (7 * Convert.ToInt32(RandomNumber7X) == Convert.ToInt32(Textbox_7X.Text))
                    {
                        LabelGoF7.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF7.Content = "Fout";
                    }
                }

                //Checken of 8e vraag klopt
                if (Textbox_8X.Text != "")
                {
                    RandomNumber8X = (string)Label_8X.Content;
                    RandomNumber8X = RandomNumber8X.Remove(0, 1);
                    RandomNumber8X = RandomNumber8X.Replace("=", "");
                    RandomNumber8X = RandomNumber8X.Replace("X", "");
                    RandomNumber8X = RandomNumber8X.Trim();
                    if (8 * Convert.ToInt32(RandomNumber8X) == Convert.ToInt32(Textbox_8X.Text))
                    {
                        LabelGoF8.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF8.Content = "Fout";
                    }
                }

                //Checken of 9e vraag klopt
                if (Textbox_9X.Text != "")
                {
                    RandomNumber9X = (string)Label_9X.Content;
                    RandomNumber9X = RandomNumber9X.Remove(0, 1);
                    RandomNumber9X = RandomNumber9X.Replace("=", "");
                    RandomNumber9X = RandomNumber9X.Replace("X", "");
                    RandomNumber9X = RandomNumber9X.Trim();
                    if (9 * Convert.ToInt32(RandomNumber9X) == Convert.ToInt32(Textbox_9X.Text))
                    {
                        LabelGoF9.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF9.Content = "Fout";
                    }
                }

                //Checken of 10e vraag klopt
                if (Textbox_10X.Text != "")
                {
                    RandomNumber10X = (string)Label_10X.Content;
                    RandomNumber10X = RandomNumber10X.Remove(0, 1);
                    RandomNumber10X = RandomNumber10X.Replace("=", "");
                    RandomNumber10X = RandomNumber10X.Replace("X", "");
                    RandomNumber10X = RandomNumber10X.Trim();
                    if (10 * Convert.ToInt32(RandomNumber10X) == Convert.ToInt32(Textbox_10X.Text))
                    {
                        LabelGoF10.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF10.Content = "Fout";
                    }
                }

                //Checken of 11e vraag klopt
                if (Textbox_11X.Text != "")
                {
                    RandomNumber11X = (string)Label_11X.Content;
                    RandomNumber11X = RandomNumber11X.Remove(0, 1);
                    RandomNumber11X = RandomNumber11X.Replace("=", "");
                    RandomNumber11X = RandomNumber11X.Replace("X", "");
                    RandomNumber11X = RandomNumber11X.Trim();
                    if (11 * Convert.ToInt32(RandomNumber11X) == Convert.ToInt32(Textbox_11X.Text))
                    {
                        LabelGoF11.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF11.Content = "Fout";
                    }
                }

                //Checken of 12e vraag klopt
                if (Textbox_12X.Text != "")
                {
                    RandomNumber12X = (string)Label_11X.Content;
                    RandomNumber12X = RandomNumber12X.Remove(0, 1);
                    RandomNumber12X = RandomNumber12X.Replace("=", "");
                    RandomNumber12X = RandomNumber12X.Replace("X", "");
                    RandomNumber12X = RandomNumber12X.Trim();
                    if (12 * Convert.ToInt32(RandomNumber12X) == Convert.ToInt32(Textbox_12X.Text))
                    {
                        LabelGoF12.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF12.Content = "Fout";
                    }
                }

                //Checken of 13e vraag klopt
                if (Textbox_13X.Text != "")
                {
                    RandomNumber13X = (string)Label_13X.Content;
                    RandomNumber13X = RandomNumber13X.Remove(0, 1);
                    RandomNumber13X = RandomNumber13X.Replace("=", "");
                    RandomNumber13X = RandomNumber13X.Replace("X", "");
                    RandomNumber13X = RandomNumber13X.Trim();
                    if (13 * Convert.ToInt32(RandomNumber13X) == Convert.ToInt32(Textbox_13X.Text))
                    {
                        LabelGoF13.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF13.Content = "Fout";
                    }
                }

                //Checken of 14e vraag klopt
                if (Textbox_14X.Text != "")
                {
                    RandomNumber14X = (string)Label_14X.Content;
                    RandomNumber14X = RandomNumber14X.Remove(0, 1);
                    RandomNumber14X = RandomNumber14X.Replace("=", "");
                    RandomNumber14X = RandomNumber14X.Replace("X", "");
                    RandomNumber14X = RandomNumber14X.Trim();
                    if (14 * Convert.ToInt32(RandomNumber14X) == Convert.ToInt32(Textbox_14X.Text))
                    {
                        LabelGoF14.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF14.Content = "Fout";
                    }
                }

                //Checken of 15e vraag klopt
                if (Textbox_15X.Text != "")
                {
                    RandomNumber15X = (string)Label_15X.Content;
                    RandomNumber15X = RandomNumber15X.Remove(0, 1);
                    RandomNumber15X = RandomNumber15X.Replace("=", "");
                    RandomNumber15X = RandomNumber15X.Replace("X", "");
                    RandomNumber15X = RandomNumber15X.Trim();
                    if (15 * Convert.ToInt32(RandomNumber15X) == Convert.ToInt32(Textbox_15X.Text))
                    {
                        LabelGoF15.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF15.Content = "Fout";
                    }
                }

                //Checken of 16e vraag klopt
                if (Textbox_16X.Text != "")
                {
                    RandomNumber16X = (string)Label_16X.Content;
                    RandomNumber16X = RandomNumber16X.Remove(0, 1);
                    RandomNumber16X = RandomNumber16X.Replace("=", "");
                    RandomNumber16X = RandomNumber16X.Replace("X", "");
                    RandomNumber16X = RandomNumber16X.Trim();
                    if (16 * Convert.ToInt32(RandomNumber16X) == Convert.ToInt32(Textbox_16X.Text))
                    {
                        LabelGoF16.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF16.Content = "Fout";
                    }
                }

                //Checken of 17e vraag klopt
                if (Textbox_17X.Text != "")
                {
                    RandomNumber17X = (string)Label_17X.Content;
                    RandomNumber17X = RandomNumber17X.Remove(0, 1);
                    RandomNumber17X = RandomNumber17X.Replace("=", "");
                    RandomNumber17X = RandomNumber17X.Replace("X", "");
                    RandomNumber17X = RandomNumber17X.Trim();
                    if (17 * Convert.ToInt32(RandomNumber17X) == Convert.ToInt32(Textbox_17X.Text))
                    {
                        LabelGoF17.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF17.Content = "Fout";
                    }
                }

                //Checken of 18e vraag klopt
                if (Textbox_18X.Text != "")
                {
                    RandomNumber18X = (string)Label_18X.Content;
                    RandomNumber18X = RandomNumber18X.Remove(0, 1);
                    RandomNumber18X = RandomNumber18X.Replace("=", "");
                    RandomNumber18X = RandomNumber18X.Replace("X", "");
                    RandomNumber18X = RandomNumber18X.Trim();
                    if (18 * Convert.ToInt32(RandomNumber18X) == Convert.ToInt32(Textbox_18X.Text))
                    {
                        LabelGoF18.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF18.Content = "Fout";
                    }
                }

                //Checken of 19e vraag klopt
                if (Textbox_19X.Text != "")
                {
                    RandomNumber19X = (string)Label_19X.Content;
                    RandomNumber19X = RandomNumber19X.Remove(0, 1);
                    RandomNumber19X = RandomNumber19X.Replace("=", "");
                    RandomNumber19X = RandomNumber19X.Replace("X", "");
                    RandomNumber19X = RandomNumber19X.Trim();
                    if (19 * Convert.ToInt32(RandomNumber19X) == Convert.ToInt32(Textbox_19X.Text))
                    {
                        LabelGoF19.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF19.Content = "Fout";
                    }
                }

                //Checken of 20e vraag klopt
                if (Textbox_20X.Text != "")
                {
                    RandomNumber20X = (string)Label_20X.Content;
                    RandomNumber20X = RandomNumber20X.Remove(0, 1);
                    RandomNumber20X = RandomNumber20X.Replace("=", "");
                    RandomNumber20X = RandomNumber20X.Replace("X", "");
                    RandomNumber20X = RandomNumber20X.Trim();
                    if (20 * Convert.ToInt32(RandomNumber20X) == Convert.ToInt32(Textbox_20X.Text))
                    {
                        LabelGoF20.Content = "Goed";
                        GoeieAntwoorden += 1;
                    }
                    else
                    {
                        LabelGoF20.Content = "Fout";
                    }
                }
                */

                double Cijfer = 10 * GoeieAntwoorden / double.Parse(TextboxHoeveelheidVragen.Text);
                Cijfer = Math.Round(Cijfer, 1);
                LabelCijfer.Content = "Je hebt een: " + Cijfer.ToString();

            }
            catch
            {
                MessageBox.Show("Voer een getal in bij alle antwoord vakjes");
            }
        }
        private void AllesCleanen()
        {
            LabelGoF1.Content = "";
            LabelGoF2.Content = "";
            LabelGoF3.Content = "";
            LabelGoF4.Content = "";
            LabelGoF5.Content = "";
            LabelGoF6.Content = "";
            LabelGoF7.Content = "";
            LabelGoF8.Content = "";
            LabelGoF9.Content = "";
            LabelGoF10.Content = "";
            LabelGoF11.Content = "";
            LabelGoF12.Content = "";
            LabelGoF13.Content = "";
            LabelGoF14.Content = "";
            LabelGoF15.Content = "";
            LabelGoF16.Content = "";
            LabelGoF17.Content = "";
            LabelGoF18.Content = "";
            LabelGoF19.Content = "";
            LabelGoF20.Content = "";

            Textbox_1X.Text = "";
            Textbox_2X.Text = "";
            Textbox_3X.Text = "";
            Textbox_4X.Text = "";
            Textbox_5X.Text = "";
            Textbox_6X.Text = "";
            Textbox_7X.Text = "";
            Textbox_8X.Text = "";
            Textbox_9X.Text = "";
            Textbox_10X.Text = "";
            Textbox_11X.Text = "";
            Textbox_12X.Text = "";
            Textbox_13X.Text = "";
            Textbox_14X.Text = "";
            Textbox_15X.Text = "";
            Textbox_16X.Text = "";
            Textbox_17X.Text = "";
            Textbox_18X.Text = "";
            Textbox_19X.Text = "";
            Textbox_20X.Text = "";

            Label_1X.Content = "";
            Label_2X.Content = "";
            Label_3X.Content = "";
            Label_4X.Content = "";
            Label_5X.Content = "";
            Label_6X.Content = "";
            Label_7X.Content = "";
            Label_8X.Content = "";
            Label_9X.Content = "";
            Label_10X.Content = "";
            Label_11X.Content = "";
            Label_12X.Content = "";
            Label_13X.Content = "";
            Label_14X.Content = "";
            Label_15X.Content = "";
            Label_16X.Content = "";
            Label_17X.Content = "";
            Label_18X.Content = "";
            Label_19X.Content = "";
            Label_20X.Content = "";

            LabelCijfer.Content = "";
        }
        private void AllesVerstoppen()
        {
            Textbox_1X.Visibility = Visibility.Hidden;
            Textbox_2X.Visibility = Visibility.Hidden;
            Textbox_3X.Visibility = Visibility.Hidden;
            Textbox_4X.Visibility = Visibility.Hidden;
            Textbox_5X.Visibility = Visibility.Hidden;
            Textbox_6X.Visibility = Visibility.Hidden;
            Textbox_7X.Visibility = Visibility.Hidden;
            Textbox_8X.Visibility = Visibility.Hidden;
            Textbox_9X.Visibility = Visibility.Hidden;
            Textbox_10X.Visibility = Visibility.Hidden;
            Textbox_11X.Visibility = Visibility.Hidden;
            Textbox_12X.Visibility = Visibility.Hidden;
            Textbox_13X.Visibility = Visibility.Hidden;
            Textbox_14X.Visibility = Visibility.Hidden;
            Textbox_15X.Visibility = Visibility.Hidden;
            Textbox_16X.Visibility = Visibility.Hidden;
            Textbox_17X.Visibility = Visibility.Hidden;
            Textbox_18X.Visibility = Visibility.Hidden;
            Textbox_19X.Visibility = Visibility.Hidden;
            Textbox_20X.Visibility = Visibility.Hidden;

            Label_1X.Visibility = Visibility.Hidden;
            Label_2X.Visibility = Visibility.Hidden;
            Label_3X.Visibility = Visibility.Hidden;
            Label_4X.Visibility = Visibility.Hidden;
            Label_5X.Visibility = Visibility.Hidden;
            Label_6X.Visibility = Visibility.Hidden;
            Label_7X.Visibility = Visibility.Hidden;
            Label_8X.Visibility = Visibility.Hidden;
            Label_9X.Visibility = Visibility.Hidden;
            Label_10X.Visibility = Visibility.Hidden;
            Label_11X.Visibility = Visibility.Hidden;
            Label_12X.Visibility = Visibility.Hidden;
            Label_13X.Visibility = Visibility.Hidden;
            Label_14X.Visibility = Visibility.Hidden;
            Label_15X.Visibility = Visibility.Hidden;
            Label_16X.Visibility = Visibility.Hidden;
            Label_17X.Visibility = Visibility.Hidden;
            Label_18X.Visibility = Visibility.Hidden;
            Label_19X.Visibility = Visibility.Hidden;
            Label_20X.Visibility = Visibility.Hidden;

            LabelGoF1.Visibility = Visibility.Hidden;
            LabelGoF2.Visibility = Visibility.Hidden;
            LabelGoF3.Visibility = Visibility.Hidden;
            LabelGoF4.Visibility = Visibility.Hidden;
            LabelGoF5.Visibility = Visibility.Hidden;
            LabelGoF6.Visibility = Visibility.Hidden;
            LabelGoF7.Visibility = Visibility.Hidden;
            LabelGoF8.Visibility = Visibility.Hidden;
            LabelGoF9.Visibility = Visibility.Hidden;
            LabelGoF10.Visibility = Visibility.Hidden;
            LabelGoF11.Visibility = Visibility.Hidden;
            LabelGoF12.Visibility = Visibility.Hidden;
            LabelGoF13.Visibility = Visibility.Hidden;
            LabelGoF14.Visibility = Visibility.Hidden;
            LabelGoF15.Visibility = Visibility.Hidden;
            LabelGoF16.Visibility = Visibility.Hidden;
            LabelGoF17.Visibility = Visibility.Hidden;
            LabelGoF18.Visibility = Visibility.Hidden;
            LabelGoF19.Visibility = Visibility.Hidden;
            LabelGoF20.Visibility = Visibility.Hidden;

        }
        private void VragenLatenZien()
        {
            try
            {

                switch (Convert.ToInt32(TextboxHoeveelheidVragen.Text))
                {
                    case 1:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        break;
                    case 5:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        break;
                    case 6:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        break;
                    case 7:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        break;
                    case 8:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        break;
                    case 9:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        break;
                    case 10:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        break;
                    case 11:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        break;
                    case 12:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        break;
                    case 13:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        break;
                    case 14:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        Textbox_14X.Visibility = Visibility.Visible;
                        Label_14X.Visibility = Visibility.Visible;
                        LabelGoF14.Visibility = Visibility.Visible;
                        break;
                    case 15:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        Textbox_14X.Visibility = Visibility.Visible;
                        Label_14X.Visibility = Visibility.Visible;
                        LabelGoF14.Visibility = Visibility.Visible;
                        Textbox_15X.Visibility = Visibility.Visible;
                        Label_15X.Visibility = Visibility.Visible;
                        LabelGoF15.Visibility = Visibility.Visible;
                        break;
                    case 16:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        Textbox_14X.Visibility = Visibility.Visible;
                        Label_14X.Visibility = Visibility.Visible;
                        LabelGoF14.Visibility = Visibility.Visible;
                        Textbox_15X.Visibility = Visibility.Visible;
                        Label_15X.Visibility = Visibility.Visible;
                        LabelGoF15.Visibility = Visibility.Visible;
                        Textbox_16X.Visibility = Visibility.Visible;
                        Label_16X.Visibility = Visibility.Visible;
                        LabelGoF16.Visibility = Visibility.Visible;
                        break;
                    case 17:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        Textbox_14X.Visibility = Visibility.Visible;
                        Label_14X.Visibility = Visibility.Visible;
                        LabelGoF14.Visibility = Visibility.Visible;
                        Textbox_15X.Visibility = Visibility.Visible;
                        Label_15X.Visibility = Visibility.Visible;
                        LabelGoF15.Visibility = Visibility.Visible;
                        Textbox_16X.Visibility = Visibility.Visible;
                        Label_16X.Visibility = Visibility.Visible;
                        LabelGoF16.Visibility = Visibility.Visible;
                        Textbox_17X.Visibility = Visibility.Visible;
                        Label_17X.Visibility = Visibility.Visible;
                        LabelGoF17.Visibility = Visibility.Visible;
                        break;
                    case 18:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        Textbox_14X.Visibility = Visibility.Visible;
                        Label_14X.Visibility = Visibility.Visible;
                        LabelGoF14.Visibility = Visibility.Visible;
                        Textbox_15X.Visibility = Visibility.Visible;
                        Label_15X.Visibility = Visibility.Visible;
                        LabelGoF15.Visibility = Visibility.Visible;
                        Textbox_16X.Visibility = Visibility.Visible;
                        Label_16X.Visibility = Visibility.Visible;
                        LabelGoF16.Visibility = Visibility.Visible;
                        Textbox_17X.Visibility = Visibility.Visible;
                        Label_17X.Visibility = Visibility.Visible;
                        LabelGoF17.Visibility = Visibility.Visible;
                        Textbox_18X.Visibility = Visibility.Visible;
                        Label_18X.Visibility = Visibility.Visible;
                        LabelGoF18.Visibility = Visibility.Visible;
                        break;
                    case 19:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        Textbox_14X.Visibility = Visibility.Visible;
                        Label_14X.Visibility = Visibility.Visible;
                        LabelGoF14.Visibility = Visibility.Visible;
                        Textbox_15X.Visibility = Visibility.Visible;
                        Label_15X.Visibility = Visibility.Visible;
                        LabelGoF15.Visibility = Visibility.Visible;
                        Textbox_16X.Visibility = Visibility.Visible;
                        Label_16X.Visibility = Visibility.Visible;
                        LabelGoF16.Visibility = Visibility.Visible;
                        Textbox_17X.Visibility = Visibility.Visible;
                        Label_17X.Visibility = Visibility.Visible;
                        LabelGoF17.Visibility = Visibility.Visible;
                        Textbox_18X.Visibility = Visibility.Visible;
                        Label_18X.Visibility = Visibility.Visible;
                        LabelGoF18.Visibility = Visibility.Visible;
                        Textbox_19X.Visibility = Visibility.Visible;
                        Label_19X.Visibility = Visibility.Visible;
                        LabelGoF19.Visibility = Visibility.Visible;
                        break;
                    case 20:
                        Textbox_1X.Visibility = Visibility.Visible;
                        Label_1X.Visibility = Visibility.Visible;
                        LabelGoF1.Visibility = Visibility.Visible;
                        Textbox_2X.Visibility = Visibility.Visible;
                        Label_2X.Visibility = Visibility.Visible;
                        LabelGoF2.Visibility = Visibility.Visible;
                        Textbox_3X.Visibility = Visibility.Visible;
                        Label_3X.Visibility = Visibility.Visible;
                        LabelGoF3.Visibility = Visibility.Visible;
                        Textbox_4X.Visibility = Visibility.Visible;
                        Label_4X.Visibility = Visibility.Visible;
                        LabelGoF4.Visibility = Visibility.Visible;
                        Textbox_5X.Visibility = Visibility.Visible;
                        Label_5X.Visibility = Visibility.Visible;
                        LabelGoF5.Visibility = Visibility.Visible;
                        Textbox_6X.Visibility = Visibility.Visible;
                        Label_6X.Visibility = Visibility.Visible;
                        LabelGoF6.Visibility = Visibility.Visible;
                        Textbox_7X.Visibility = Visibility.Visible;
                        Label_7X.Visibility = Visibility.Visible;
                        LabelGoF7.Visibility = Visibility.Visible;
                        Textbox_8X.Visibility = Visibility.Visible;
                        Label_8X.Visibility = Visibility.Visible;
                        LabelGoF8.Visibility = Visibility.Visible;
                        Textbox_9X.Visibility = Visibility.Visible;
                        Label_9X.Visibility = Visibility.Visible;
                        LabelGoF9.Visibility = Visibility.Visible;
                        Textbox_10X.Visibility = Visibility.Visible;
                        Label_10X.Visibility = Visibility.Visible;
                        LabelGoF10.Visibility = Visibility.Visible;
                        Textbox_11X.Visibility = Visibility.Visible;
                        Label_11X.Visibility = Visibility.Visible;
                        LabelGoF11.Visibility = Visibility.Visible;
                        Textbox_12X.Visibility = Visibility.Visible;
                        Label_12X.Visibility = Visibility.Visible;
                        LabelGoF12.Visibility = Visibility.Visible;
                        Textbox_13X.Visibility = Visibility.Visible;
                        Label_13X.Visibility = Visibility.Visible;
                        LabelGoF13.Visibility = Visibility.Visible;
                        Textbox_14X.Visibility = Visibility.Visible;
                        Label_14X.Visibility = Visibility.Visible;
                        LabelGoF14.Visibility = Visibility.Visible;
                        Textbox_15X.Visibility = Visibility.Visible;
                        Label_15X.Visibility = Visibility.Visible;
                        LabelGoF15.Visibility = Visibility.Visible;
                        Textbox_16X.Visibility = Visibility.Visible;
                        Label_16X.Visibility = Visibility.Visible;
                        LabelGoF16.Visibility = Visibility.Visible;
                        Textbox_17X.Visibility = Visibility.Visible;
                        Label_17X.Visibility = Visibility.Visible;
                        LabelGoF17.Visibility = Visibility.Visible;
                        Textbox_18X.Visibility = Visibility.Visible;
                        Label_18X.Visibility = Visibility.Visible;
                        LabelGoF18.Visibility = Visibility.Visible;
                        Textbox_19X.Visibility = Visibility.Visible;
                        Label_19X.Visibility = Visibility.Visible;
                        LabelGoF19.Visibility = Visibility.Visible;
                        Textbox_20X.Visibility = Visibility.Visible;
                        Label_20X.Visibility = Visibility.Visible;
                        LabelGoF20.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }
                Label_Sommen.Content = "Sommen:";
            }
            catch
            {
                MessageBox.Show("Voer een getal in hoeveel vragen je wilt hebben");
                return;
            }
        }

        private void Button_Reset_Click(object sender, RoutedEventArgs e)
        {
            AllesCleanen();
            AllesVerstoppen();
            Label_Sommen.Content = "";
            Textbox_MaxHoogteSommen.Text = "";
            TextboxHoeveelheidVragen.Text = "";
        }
        private void Textblokkenverstoppen()
        {
            Textbox_1X.Visibility = Visibility.Hidden;
            Textbox_2X.Visibility = Visibility.Hidden;
            Textbox_3X.Visibility = Visibility.Hidden;
            Textbox_4X.Visibility = Visibility.Hidden;
            Textbox_5X.Visibility = Visibility.Hidden;
            Textbox_6X.Visibility = Visibility.Hidden;
            Textbox_7X.Visibility = Visibility.Hidden;
            Textbox_8X.Visibility = Visibility.Hidden;
            Textbox_9X.Visibility = Visibility.Hidden;
            Textbox_10X.Visibility = Visibility.Hidden;
            Textbox_11X.Visibility = Visibility.Hidden;
            Textbox_12X.Visibility = Visibility.Hidden;
            Textbox_13X.Visibility = Visibility.Hidden;
            Textbox_14X.Visibility = Visibility.Hidden;
            Textbox_15X.Visibility = Visibility.Hidden;
            Textbox_16X.Visibility = Visibility.Hidden;
            Textbox_17X.Visibility = Visibility.Hidden;
            Textbox_18X.Visibility = Visibility.Hidden;
            Textbox_19X.Visibility = Visibility.Hidden;
            Textbox_20X.Visibility = Visibility.Hidden;
        }
    }
}
