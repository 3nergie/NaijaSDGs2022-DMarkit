using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DMarkitMobile.Views
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SigninPage());
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }
    }
}

