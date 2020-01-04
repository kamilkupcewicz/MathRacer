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
using MathGame.MainPages.Settings_pages.ChangeLanguage_pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages.Settings_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChangeLanguage : Page
    {
        string language;

        public ChangeLanguage()
        {
            this.InitializeComponent();
        }

        private void SetLanguage_en(object sender, TappedRoutedEventArgs e)
        {
            string language = "en";
            Frame.Navigate(typeof(ChangeLanguage_tmp), language);

        }

        private void SetLanguage_ua(object sender, TappedRoutedEventArgs e)
        {
            string language = "ua";
            Frame.Navigate(typeof(ChangeLanguage_tmp), language);

        }

        private void SetLanguage_ru(object sender, TappedRoutedEventArgs e)
        {
            string language = "ru";
            Frame.Navigate(typeof(ChangeLanguage_tmp), language);

        }
        private void SetLanguage_pl(object sender, TappedRoutedEventArgs e)
        {
            string language = "pl";
            Frame.Navigate(typeof(ChangeLanguage_tmp), language);

        }

        //Function to refresh page
        private bool Reload(object param = null)
        {
            var type = Frame.CurrentSourcePageType;

            try
            {
                return Frame.Navigate(type, param);
            }
            finally
            {
                Frame.BackStack.Remove(Frame.BackStack.Last());
            }

        }

        private void Go_Settings(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }

    }
}
