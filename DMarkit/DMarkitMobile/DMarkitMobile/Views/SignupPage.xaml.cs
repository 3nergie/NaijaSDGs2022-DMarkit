using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DMarkitMobile.Views
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SiginupTwoPage());
        }

        async void Register_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SigninPage());
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}

