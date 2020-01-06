using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using MathGame.Classes;
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

namespace MathGame.MainPages.Play_pages.Play_mode_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Multiplication_modes : Page
    {
        AnotherPagePayload payload;

        public Multiplication_modes()
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
            
            base.OnNavigatedTo(e);
            this.RequestedTheme = (ElementTheme)ApplicationData.Current.LocalSettings.Values["AppTheme"];
            

            //Get object from previous page
            payload = e.Parameter as AnotherPagePayload;
            //
        }


        private void Go_Nickname_enter(object sender, RoutedEventArgs e)
        {

            string btn_name = (sender as Button).Name.ToString();
            switch (btn_name)
            {
                case "digits_2":
                    payload.choice_mode = "digits_2";
                    Frame.Navigate(typeof(Nickname_enter), payload);
                    break;
                case "digits_3":
                    payload.choice_mode = "digits_3";
                    Frame.Navigate(typeof(Nickname_enter), payload);
                    break;
                //to add
                default:
                    //error
                    break;
            }
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null && this.Frame.CanGoBack) this.Frame.GoBack();
        }


    }
}
