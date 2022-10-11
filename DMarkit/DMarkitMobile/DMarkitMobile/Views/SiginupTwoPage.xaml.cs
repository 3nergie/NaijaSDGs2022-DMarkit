using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DMarkitMobile.Views
{
    public partial class SiginupTwoPage : ContentPage
    {
        public SiginupTwoPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmEmailPage());
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

    }
}

