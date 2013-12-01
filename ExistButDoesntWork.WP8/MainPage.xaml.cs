using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExistButDoesntWork.WP8.Resources;

namespace ExistButDoesntWork.WP8
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
            var networkProfiles = Windows.Networking.Connectivity.NetworkInformation.GetConnectionProfiles();
            var adapter = networkProfiles.First<Windows.Networking.Connectivity.ConnectionProfile>().NetworkAdapter;//takes the first network adapter
            Result.Text= adapter.NetworkAdapterId.ToString();//produces a string in the format: 90de0377-d988-4e1b-b89b-475bbca46e1d
        }
    }
}