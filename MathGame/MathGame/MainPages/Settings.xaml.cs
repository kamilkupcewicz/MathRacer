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
using MathGame.MainPages.Settings_pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {

        public Settings()
        {
            this.InitializeComponent();
            Cheking_Theme();    
            Cheking_Sound();
        }
        public void Cheking_Theme()
        {
            if ((ElementTheme)ApplicationData.Current.LocalSettings.Values["AppTheme"] == ElementTheme.Dark)
            {
                ThemeSwitch.IsOn = true;
            }
            if ((ElementTheme)ApplicationData.Current.LocalSettings.Values["AppTheme"] == ElementTheme.Light)
            {
                ThemeSwitch.IsOn = false;
            }
        }

        public void Cheking_Sound()
        {
            if (ElementSoundPlayer.State == ElementSoundPlayerState.On)
            {
                SoundSwitch.IsOn = true;
            }
            else
            {
                SoundSwitch.IsOn = false;
            }
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
        private void Change_Theme(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch.IsOn == true)
            {
                ApplicationData.Current.LocalSettings.Values["AppTheme"] = (int)ElementTheme.Dark;
                this.RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                ApplicationData.Current.LocalSettings.Values["AppTheme"] = (int)ElementTheme.Light;
                this.RequestedTheme = ElementTheme.Light;
            }

        }


        private void Sound_Status(object sender, RoutedEventArgs e)
        {
            if (SoundSwitch.IsOn)
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.On;
            }
            else
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.Off;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.RequestedTheme = (ElementTheme)ApplicationData.Current.LocalSettings.Values["AppTheme"];
        }

        private void Go_ChangeLanguage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChangeLanguage));
        }



    }
}
