using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DMarkitMobile.Views
{
    public partial class ConfirmEmailPage : ContentPage
    {
        public ConfirmEmailPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SigninPage());
        }
    }
}

