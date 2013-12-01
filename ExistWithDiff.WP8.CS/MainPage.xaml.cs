using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExistWithDiff.WP8.CS.Resources;

namespace ExistWithDiff.WP8.CS
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            
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
        //        Dispatcher.BeginInvoke(()=>ProgressLayer.Visibility = Visibility.Visible);
        //        await Task.Delay(1500);
        //        Dispatcher.BeginInvoke(()=>ProgressLayer.Visibility = Visibility.Collapsed);
        //    });
        //}
        
    }
}