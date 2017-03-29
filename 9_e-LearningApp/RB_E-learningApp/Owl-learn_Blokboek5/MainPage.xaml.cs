using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Owl_learn_Blokboek5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public static void Navigate(Type typeOfPage)
        {
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate(typeOfPage);
                }
            }
        }
            private void login_Click(object sender, RoutedEventArgs e)
        {
            if(tbUsername.Text == "leerling" && pbPassword.Password == "123")
            {
                MainPage.Navigate(typeof(DashboardLeerling));
            }
            else if(tbUsername.Text == "docent" && pbPassword.Password == "123")
            {
                MainPage.Navigate(typeof(DashboardConsulent));
            }
            else if (tbUsername.Text == "admin" && pbPassword.Password == "123")
            {
                MainPage.Navigate(typeof(DashboardAdmin));
            }
            else
            {
               //Pop up box toevoegen
            }   
                
        }
    }
}
