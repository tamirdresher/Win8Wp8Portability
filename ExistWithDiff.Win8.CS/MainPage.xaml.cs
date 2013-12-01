using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ExistWithDiff.Win8.CS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }


        ///NOT WORKING CODE
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(async () =>
            {
                ProgressLayer.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                ProgressLayer.Visibility = Visibility.Collapsed;
            });
        }

        ///WORKING CODE
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Task.Run(async () =>
        //    {
        //        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
        //            () => { ProgressLayer.Visibility = Visibility.Visible; });
        //        await Task.Delay(1000);
        //        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
        //           () => { ProgressLayer.Visibility = Visibility.Collapsed; });
        //    });
        //}

    }
}
