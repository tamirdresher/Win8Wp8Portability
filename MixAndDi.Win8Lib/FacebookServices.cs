using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Authentication.Web;
using Facebook;
using MixAndDi.Shared;

namespace MixAndDi.Win8Lib
{
    public class FacebookServices : IFacebookServices
    {
        #region AppId

        private string AppId = "[YOUR APP ID]";
        #endregion
        public async Task<string> Login()
        {
            var facebookClient = new FacebookClient();
            const string redirectUrl = "https://www.facebook.com/connect/login_success.html";
            var loginUrl = facebookClient.GetLoginUrl(new
            {
                client_id = AppId,
                redirect_uri = redirectUrl,
                scope = "user_about_me,read_stream,publish_stream",
                display = "popup",
                response_type = "token"
            });

            var endUri = new Uri(redirectUrl);
            var webAuthenticationResult = await WebAuthenticationBroker.AuthenticateAsync(
               WebAuthenticationOptions.None,
               loginUrl,
               endUri);

            var callbackUri = new System.Uri(webAuthenticationResult.ResponseData.ToString());
            var facebookOAuthResult = facebookClient.ParseOAuthCallbackUrl(callbackUri);
            return facebookOAuthResult.AccessToken;


        }
    }
}
