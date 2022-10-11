using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DMarkitMobile.Views
{
    public partial class SigninPage : ContentPage
    {
        public SigninPage()
        {
            InitializeComponent();
        }

        async void Register_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPasswordPage());
        }
    }
}

