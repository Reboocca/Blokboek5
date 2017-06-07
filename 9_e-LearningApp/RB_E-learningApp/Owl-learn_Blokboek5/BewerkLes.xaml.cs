using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
    public sealed partial class BewerkLes : Page
    {//VARIABELEN
        public string userid;
        public string vakid;
        public string lesid;

        //STRUCTS
        struct Vraag
        {
            public string ID { get; set; }
            public string Omschrijving { get; set; }
        }

        //LISTS
        List<Vraag> lstVragen = new List<Vraag>();

        public BewerkLes()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var parameters = (user)e.Parameter;
            userid = parameters.userID;
            vakid = parameters.selectedVakID;
            lesid = parameters.selectedLesID;

            getVragen();
        }
        

        private async void getVragen()
        {
            HttpClient connect = new HttpClient();
            HttpResponseMessage getVraag = await connect.GetAsync("http://localhost/Leerjaar2/OP3/Owl-learn/functies/ConsulentDashboard/getVragen.php?lesID=" + lesid);
            // gebruik eventueel PostAsync
            getVraag.EnsureSuccessStatusCode();

            string result = null;
            result = await getVraag.Content.ReadAsStringAsync();

            string[] items = result.Split(',').ToArray();

            foreach (string i in items)
            {
                if (i != "")
                {
                    string[] info = i.Split('.').ToArray();
                    lstVragen.Add(new Vraag() { Omschrijving = info[0], ID = info[1] });
                }

            }
            lbVragen.ItemsSource = lstVragen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parameters = new user();
            parameters.userID = userid;
            parameters.selectedVakID = vakid;

            this.Frame.Navigate(typeof(BewerkVak), parameters);
        }

        private void btLogout_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
