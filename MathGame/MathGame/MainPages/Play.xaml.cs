using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MathGame.Classes;
using MathGame.MainPages.Play_pages.Play_mode_pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Play : Page
    {

        public Play()
        {
            this.InitializeComponent();

            ApplicationView.GetForCurrentView().SetPreferredMinSize(
                new Size(
                    500, // Width
                    500 // Height
                    )
                );

        }
      

        private void Go_Play(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Play));
        }

        private void Go_Results(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Results));
        }

        private void Go_Settings(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }

      

        private void Choose_mode(object sender, RoutedEventArgs e)
        {
            AnotherPagePayload payload = new AnotherPagePayload();
            string btn_name = (sender as Button).Name.ToString();
            switch (btn_name)
            {
                case "addition":
                    payload.choice_game = "addition";
                    Frame.Navigate(typeof(Addition_modes), payload);
                    break;
                case "subtraction":
                    payload.choice_game = "subtraction";
                    Frame.Navigate(typeof(Subtraction_modes), payload);
                    break;
                default:
                    //error
                    break;
            }
        }


    }
}
