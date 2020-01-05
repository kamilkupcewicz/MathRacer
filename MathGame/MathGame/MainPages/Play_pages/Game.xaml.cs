using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MathGame.Classes;
using MathGame.MainPages.Play_pages.Game_pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages.Play_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {

        AnotherPagePayload payload;
        int[] numbers;

        public Game()
        {
            this.InitializeComponent();
            bad_answer.Visibility = Visibility.Collapsed;
            good_answer.Visibility = Visibility.Collapsed;
        }

        public void new_task()
        {
            switch (payload.choice_game)
            {
                case "addition":
                    switch (payload.choice_mode)
                    {
                        case "digits_2":
                            numbers = GenerateNumbers.Addition(digits: 2);
                            break;
                        case "digits_3":
                            numbers = GenerateNumbers.Addition(digits: 3);
                            break;
                        //to add
                        default:
                            //error
                            break;
                    }
                    symbol.Text = "+";
                    //UI
                    UI_show_task();
                    //
                    break;
                case "subtraction":
                    switch (payload.choice_mode)
                    {
                        case "digits_2":
                            numbers = GenerateNumbers.Subtraction(digits: 2);
                            break;
                        case "digits_3":
                            numbers = GenerateNumbers.Subtraction(digits: 3);
                            break;
                        //to add
                        default:
                            //error
                            break;
                    }
                    symbol.Text = "-";
                    //UI
                    UI_show_task();
                    //
                    break;
                case "multiplication":
                                    switch (payload.choice_mode)
                                    {
                                        case "digits_2":
                                            numbers = GenerateNumbers.Multiplying(digits: 2);
                                            break;
                                      case "digits_3":
                                            numbers = GenerateNumbers.Multiplying(digits: 3);
                                            break;
                                        //to add
                                        default:
                                            //error
                                            break;
                                    }
                                    symbol.Text = "*";
                                    //UI
                                    UI_show_task();
                                    //
                                    break;
                default:
                    //error
                    break;
            }
        }

        public void UI_show_task()
        {
            first_number.Text = numbers[0].ToString();
            second_number.Text = numbers[1].ToString();
        }

        private static int time;
        private DispatcherTimer timer;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            payload = e.Parameter as AnotherPagePayload;
            Debug.WriteLine(payload.score);
            

            new_task(); 

            Task.Run(async () =>
            {
                await Task.Delay(Time.time);
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Frame.Navigate(typeof(Game_Result), payload));
            });
            time = Time.time / 1000;
            tbTime.Text = time.ToString();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        private void timer_Tick(object sender, object e)
        {
            time--;
            tbTime.Text = time.ToString();
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e) { timer.Stop(); }
        private void Numbers_Click(object sender, RoutedEventArgs e)
        {
            string btn_name = (sender as Button).Name.ToString();
            if (answer.Text.Length < 10) //cheking for answer length. answer number must be less than 10 digit number
            {
                switch (btn_name)
                {
                    case "One":
                        answer.Text += "1";
                        break;
                    case "Two":
                        answer.Text += "2";
                        break;
                    case "Three":
                        answer.Text += "3";
                        break;
                    case "Four":
                        answer.Text += "4";
                        break;
                    case "Five":
                        answer.Text += "5";
                        break;
                    case "Six":
                        answer.Text += "6";
                        break;
                    case "Seven":
                        answer.Text += "7";
                        break;
                    case "Eight":
                        answer.Text += "8";
                        break;
                    case "Nine":
                        answer.Text += "9";
                        break;
                    case "Zero":
                        answer.Text += "0";
                        break;
                    case "Del_num":
                        if (answer.Text.Length > 1)
                        {
                            answer.Text = answer.Text.Remove(answer.Text.Length - 1);
                        }
                        break;
                    case "Sumbit":
                        Check_task();//function to sumbit number for checking
                        break;
                    default:
                        //error
                        break;
                }
            }
            else
            {
                switch (btn_name)
                {
                    case "Del_num":
                        if (answer.Text.Length > 1)
                        {
                            answer.Text = answer.Text.Remove(answer.Text.Length - 1);
                        }
                        break;
                    case "Sumbit":
                        Check_task();
                        break;
                    default:
                        //error
                        break;
                }
            }
        }

        public void Check_task()
        {
            if (answer.Text.Substring(2) == numbers[2].ToString())
            {
                //Correct task
                payload.score += 10;
                Debug.WriteLine(payload.score);
                good_answer.Visibility = Visibility.Visible;
                bad_answer.Visibility = Visibility.Collapsed;

            }
            else
            {
                //Inncorect task
                Debug.WriteLine(payload.score);
                bad_answer.Visibility = Visibility.Visible;
                good_answer.Visibility = Visibility.Collapsed;
            }
            UI_clean_task();
        }

        public void UI_clean_task()
        {
            new_task();
            UI_show_task();
            answer.Text = "= ";
        }

        private void Check_num_pressed(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key)
            {
                case VirtualKey.Number1:
                case VirtualKey.NumberPad1:
                    Numbers_Click(One, e);
                    break;
                case VirtualKey.Number2:
                case VirtualKey.NumberPad2:
                    Numbers_Click(Two, e);
                    break;
                case VirtualKey.Number3:
                case VirtualKey.NumberPad3:
                    Numbers_Click(Three, e);
                    break;
                case VirtualKey.Number4:
                case VirtualKey.NumberPad4:
                    Numbers_Click(Four, e);
                    break;
                case VirtualKey.Number5:
                case VirtualKey.NumberPad5:
                    Numbers_Click(Five, e);
                    break;
                case VirtualKey.Number6:
                case VirtualKey.NumberPad6:
                    Numbers_Click(Six, e);
                    break;
                case VirtualKey.Number7:
                case VirtualKey.NumberPad7:
                    Numbers_Click(Seven, e);
                    break;
                case VirtualKey.Number8:
                case VirtualKey.NumberPad8:
                    Numbers_Click(Eight, e);
                    break;
                case VirtualKey.Number9:
                case VirtualKey.NumberPad9:
                    Numbers_Click(Nine, e);
                    break;
                case VirtualKey.Number0:
                case VirtualKey.NumberPad0:
                    Numbers_Click(Zero, e);
                    break;
                case VirtualKey.Back:
                    Numbers_Click(Del_num, e);
                    break;
                case VirtualKey.Enter:
                    Numbers_Click(Sumbit, e);
                    break;
                default:
                    //nothing
                    break;
            }

        }





    }
}
