using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages.Training_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Substraction_section : Page
    {
        public Substraction_section()
        {
            this.InitializeComponent();
        }

        private void Go_Training(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Training));
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
            base.OnNavigatedTo(e);
            this.RequestedTheme = (ElementTheme)ApplicationData.Current.LocalSettings.Values["AppTheme"];

        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null && this.Frame.CanGoBack) this.Frame.GoBack();
        }

    }
}
