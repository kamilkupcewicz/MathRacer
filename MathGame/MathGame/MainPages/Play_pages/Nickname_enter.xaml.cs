using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MathGame.Classes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages.Play_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Nickname_enter : Page
    {

        AnotherPagePayload payload;


        public Nickname_enter()
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
            payload = e.Parameter as AnotherPagePayload;


        }

        private async void Start_Game(object sender, RoutedEventArgs e)
        {
            payload.username = nickname_block.Text;
            if (nickname_block.Text == "")
            {
                MessageDialog message = new MessageDialog(nickname_block.Header.ToString());
                await message.ShowAsync();
            }
            else
            {
                Frame.Navigate(typeof(Game), payload);
            }
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null && this.Frame.CanGoBack) this.Frame.GoBack();
        }

        private void Check_Enter_pressed(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key)
            {
                case VirtualKey.Enter:
                    Start_Game(Button_confim, e);
                    break;
                default:
                    //error
                    break;
            }
        }
    }
}
