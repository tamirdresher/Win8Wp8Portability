using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Practices.Unity;
using MixAndDi.Shared;
using MixAndDi.WP8.App.Resources;

namespace MixAndDi.WP8.App
{
    public partial class LoginPageView : PhoneApplicationPage
    {
        // Constructor
        public LoginPageView()
        {
            if (!DesignerProperties.IsInDesignTool)
            {
                this.DataContext = App.Container.Resolve<LoginPageViewModel>();
            }
            InitializeComponent();
            
        }

        
    }
}