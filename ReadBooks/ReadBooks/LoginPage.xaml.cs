using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadBooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async private void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // TODO: add login
                AppCenterHelper.TrackEvent("logged_in");
                await Navigation.PopModalAsync(true);
            }
            catch (Exception exception)
            {
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
                {
                    { "Signal", "Strong" },
                    { "NewUser", "False" },
                    { "WiFi", "On" }
                };
                AppCenterHelper.TrackError(exception, keyValuePairs);
            }
        }
    }
}