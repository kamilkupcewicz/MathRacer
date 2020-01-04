using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages.Settings_pages.ChangeLanguage_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChangeLanguage_tmp : Page
    {
        public ChangeLanguage_tmp()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            string language = e.Parameter as string;
            //

            switch (language)
            {
                case "en":
                    ApplicationLanguages.PrimaryLanguageOverride = "en";
                    break;
                case "ua":
                    ApplicationLanguages.PrimaryLanguageOverride = "ua";
                    break;
                case "ru":
                    ApplicationLanguages.PrimaryLanguageOverride = "ru";
                    break;
                case "pl":
                    ApplicationLanguages.PrimaryLanguageOverride = "pl";
                    break;
                default:
                    //error
                    break;
            }

            Task.Run(async () =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Frame.GoBack());
            });
        }



    }
}
