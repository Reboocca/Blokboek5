using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Owl_learn_Blokboek5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ToetsForm : Page
    {
        #region fields
        public List<string> _plstVraagID = new List<string>();
        public List<string> _psltSelectieVragen = new List<string>();
        public List<string> _lstAntwoorden = new List<string>();
        public string user;
        public string lesonderwerp;
        public string _psVraagID;
        static Random rnd = new Random();
        int _iIndex = 0;
        int _piRadioButton = 99;
        int _iScore = 0;
        #endregion

        public ToetsForm()
        {
            this.InitializeComponent();

            //PopulateVraagLijst();
            //SelectVragen();
            //NextQuestion();
        }


        /*
        //Lijst vullen met de vragen van alle lessen:
        public void PopulateVraagLijst()
        {
            DataTable dtToetsVraag = db.Search("vragen", "LesonderwerpID", lesonderwerp);

            foreach (DataRow row in dtToetsVraag.Rows)
            {
                _plstVraagID.Add(row["VraagID"].ToString());
            }

        }

        //Lijst vullen met een random selectie van de vragen -> max 10
        private void SelectVragen()
        {
            for (int i = _psltSelectieVragen.Count; i < 20; i++)
            {
                int r = rnd.Next(_plstVraagID.Count - 1);
                bool contains = _psltSelectieVragen.Contains((string)_plstVraagID[r]);

                if (!contains)
                {
                    _psltSelectieVragen.Add((string)_plstVraagID[r]);
                }
                else
                {
                    i -= 1;
                }
            }

        }

        //Handelingen om naar de volgende vraag te gaan
        public void NextQuestion()
        {
            //Om te kijken of er op verder of opslaan geklikt wordt
            string sContentButton = btVerder.Content.ToString();

           

                //Zolang er nog vragen zijn om te beantwoorden: 
                if (_iIndex < _psltSelectieVragen.Count)
                {
                    //Neem het VraagID
                    _psVraagID = _psltSelectieVragen[_iIndex];

                    //Haal de vraag op via het VraagID
                    DataTable dtVraag = db.Search("vragen", "VraagID", _psVraagID);
                    foreach (DataRow row in dtVraag.Rows)
                    {
                        lbVraag.Text = row["Vraag"].ToString();
                    }

                    //int iVraagNummer = _iIndex + 1;
                    //lbVraagNummer.Content = iVraagNummer.ToString() + " van " + _psltSelectieVragen.Count.ToString();

                    _iIndex++;

                    //Zorg dat alle radiobuttons uitgevinkt staan
                    rbAntwoord1.IsChecked = false;
                    rbAntwoord2.IsChecked = false;
                    rbAntwoord3.IsChecked = false;
                    rbAntwoord4.IsChecked = false;

                    //Verwijder alles uit de antwoord lijst en repopulate hem
                    _lstAntwoorden.Clear();
                    PopulateAntwoordLijst();
                }

                //Wanneer alle vragen zijn beantwoord:
                else
                {
                    //MessageBox.Show("Je hebt alle vragen beantwoord, klik op opslaan om verder te gaan.", "Done");
                    btVerder.Content = "Opslaan";
                }
            }
        }

        //Lijst vullen met de mogelijke antwoorden -> vul deze in de radiobuttons in.
        private void PopulateAntwoordLijst()
        {
            DataTable dtAntwoorden = db.Search("antwoorden", "VraagID", _psVraagID);

            foreach (DataRow row in dtAntwoorden.Rows)
            {
                _lstAntwoorden.Add(row["Antwoord"].ToString());
            }

            rbAntwoord1.Content = _lstAntwoorden[0];
            rbAntwoord2.Content = _lstAntwoorden[1];
            rbAntwoord3.Content = _lstAntwoorden[2];
            rbAntwoord4.Content = _lstAntwoorden[3];
        }

        //Wanneer er op verder geklikt word:
        private void btVerder_Click(object sender, RoutedEventArgs e)
        {
            //Geef mee welke radiobutton is gecheckt voor het controleren of het antwoord juist is beantwoord
            if (rbAntwoord1.IsChecked == true)
            {
                _piRadioButton = 0;
                NextQuestion();
            }
            else if (rbAntwoord2.IsChecked == true)
            {
                _piRadioButton = 1;
                NextQuestion();
            }
            else if (rbAntwoord3.IsChecked == true)
            {
                _piRadioButton = 2;
                NextQuestion();
            }
            else if (rbAntwoord4.IsChecked == true)
            {
                _piRadioButton = 3;
                NextQuestion();
            }
            else
            {
                //MessageBox.Show("Zorg ervoor dat je een antwoord hebt aangevinkt!", "oops!");
            }
        }*/
    }
}
