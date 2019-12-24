using System;
using System.Collections.Generic;
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
using MathGame.Classes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Results : Page
    {
        List<PlayerResult> results_add_2 = new List<PlayerResult>();
        List<PlayerResult> results_add_3 = new List<PlayerResult>();
        List<PlayerResult> results_sub_2 = new List<PlayerResult>();
        List<PlayerResult> results_sub_3 = new List<PlayerResult>();

        public Results()
        {
            this.InitializeComponent();
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


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            results_add_2 = sqlConnection.Select("addition", "digits_2");
            results_add_3 = sqlConnection.Select("addition", "digits_3");
            results_sub_2 = sqlConnection.Select("subtraction", "digits_2");
            results_sub_3 = sqlConnection.Select("subtraction", "digits_3");
            

        }

    }
}
