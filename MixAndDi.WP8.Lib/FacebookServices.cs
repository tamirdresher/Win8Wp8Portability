using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Facebook.Client;
using MixAndDi.Shared;

namespace MixAndDi.WP8.Lib
{
    public class FacebookServices:IFacebookServices
    {
        #region AppId

        private string AppId = "[YOUR APP ID]";
        #endregion
        public async Task<string> Login()
        {

            var facebookSessionClient = new FacebookSessionClient(AppId);
            var session = await facebookSessionClient.LoginAsync("user_about_me,read_stream,publish_stream");
            return session.AccessToken;
        }
    }
}
