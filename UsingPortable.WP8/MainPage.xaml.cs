using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PortableClassLib;
using UsingPortable.WP8.Resources;

namespace UsingPortable.WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Result.Text = string.Format("{0} - Took {1} ms", MyMath.CountPairs(Enumerable.Range(1, 10000000)),
                stopwatch.ElapsedMilliseconds);
        }
    }
}