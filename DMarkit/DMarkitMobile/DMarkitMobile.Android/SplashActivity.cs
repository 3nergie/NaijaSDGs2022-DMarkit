
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DMarkitMobile.Droid
{
    [Activity(Label = "D'Markit" , Icon = "@drawable/logo"
        , Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        protected async override void OnResume()
        {
            base.OnResume();
            /// OR this method
            await SimulatedStartuo();
        }

        private async Task SimulatedStartuo()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(500));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}

