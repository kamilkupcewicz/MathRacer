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
using MathGame.Classes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages.Play_pages.Game_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game_Result : Page
    {

        private DateTime date = DateTime.Now;

        public Game_Result()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            AnotherPagePayload payload = e.Parameter as AnotherPagePayload;      

            result.Text = payload.score.ToString();
            sqlConnection.InsertResult(payload.username, payload.score.ToString(), date, payload.choice_game, payload.choice_mode);
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Play));
        }

    }
}

