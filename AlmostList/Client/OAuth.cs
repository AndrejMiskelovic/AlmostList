//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.Essentials;

//namespace AlmostList.Client
//{
//	public class Auth : Microsoft.Maui.Authentication.WebAuthenticatorCallbackActivity
//    {
//        public async Task<string> GetToken()
//        {
//            int clientId = 15602;

//            Microsoft.Maui.Authentication.WebAuthenticatorResult authResult = await Microsoft.Maui.Authentication.WebAuthenticator.Default.AuthenticateAsync(
//new Microsoft.Maui.Authentication.WebAuthenticatorOptions()
//{
//    Url = new Uri($@"https://anilist.co/api/v2/oauth/authorize?client_id={clientId}&response_type=token"),
//    CallbackUrl = new Uri("myapp://"),
//    PrefersEphemeralWebBrowserSession = true
//});

//            return authResult?.AccessToken;
//        }

//    }
//}

