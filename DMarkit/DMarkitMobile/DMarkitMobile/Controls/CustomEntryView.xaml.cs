using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DMarkitMobile.Controls
{
    public partial class CustomEntryView : ContentView
    {
        public CustomEntryView()
        {
            InitializeComponent();
        }
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(TitleText), typeof(string), typeof(CustomEntryView), defaultValue: string.Empty,
          defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnTitleChanged);

        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;

            var customEntry = (CustomEntryView)bindable;
            customEntry.Title.Text = (string)newValue;
        }

        public string TitleText
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty ErrorProperty = BindableProperty.Create(nameof(ErrorTextTitle), typeof(string), typeof(CustomEntryView), defaultValue: string.Empty,
            defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnErrorChanged);

        private static void OnErrorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;

            var customEntry = (CustomEntryView)bindable;
            customEntry.ErrorText.Text = (string)newValue;
        }

        public string ErrorTextTitle
        {
            get { return (string)GetValue(ErrorProperty); }
            set { SetValue(ErrorProperty, value); }
        }

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(CustomEntryView), defaultValue: string.Empty,
           defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnImageSourceChanged);

        private static void OnImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;

            var customEntry = (CustomEntryView)bindable;
            customEntry.ImageResource.Source = (string)newValue;
        }

        public string ImageSource
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomEntryView), defaultValue: string.Empty,
           defaultBindingMode: BindingMode.TwoWay);

        //private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    if (bindable == null || newValue == null) return;

        //    var customEntry = (CustomEntryView)bindable;
        //    customEntry.EntryField.Text = (string)newValue;
        //}

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public static readonly BindableProperty PlaceHolderTextProperty = BindableProperty.Create(nameof(PlaceHolderText), typeof(string), typeof(CustomEntryView), defaultValue: $"Enter value",
           defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnPlaceHolderTextChanged);

        public string PlaceHolderText
        {
            get { return (string)GetValue(PlaceHolderTextProperty); }
            set { SetValue(PlaceHolderTextProperty, value); }
        }

        private static void OnPlaceHolderTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;

            var customEntry = bindable as CustomEntryView;
            customEntry.EntryField.Placeholder = (string)newValue;
        }

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CustomEntryView), defaultValue: Color.FromHex("#000000"),
            defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnTextColorChanged);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static void OnTextColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;
            var customEntry = bindable as CustomEntryView;
            customEntry.EntryField.TextColor = (Color)newValue;

        }

        public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create(nameof(MaxLength), typeof(int), typeof(CustomEntryView),
            defaultValue: default(int), defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnMaxLengthChanged);

        private static void OnMaxLengthChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;

            var customEntry = bindable as CustomEntryView;
            customEntry.EntryField.MaxLength = (int)newValue;
        }

        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }


        public static readonly BindableProperty IsRequiredProperty = BindableProperty.Create(nameof(IsRequired), typeof(bool), typeof(CustomEntryView),
           defaultValue: false, defaultBindingMode: BindingMode.OneWay, propertyChanged: OnIsRequiredChanged);

        private static void OnIsRequiredChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;

            var customEntry = bindable as CustomEntryView;
            customEntry.RequiredField.IsVisible = (bool)newValue;
            //customEntry.Required.IsVisible = (bool)newValue;
        }

        public bool IsRequired
        {
            get { return (bool)GetValue(IsRequiredProperty); }
            set { SetValue(IsRequiredProperty, value); }
        }

        public static readonly BindableProperty PassWordImageProperty = BindableProperty.Create(nameof(IsPassWordImage), typeof(bool), typeof(CustomEntryView),
           defaultValue: false, defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnPassWordImageChanged);

        private static void OnPassWordImageChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;

            var customEntry = bindable as CustomEntryView;
            customEntry.PassWordImageSource.IsVisible = (bool)newValue;
            customEntry.EntryField.IsPassword = (bool)newValue;
        }

        public bool IsPassWordImage
        {
            get { return (bool)GetValue(PassWordImageProperty); }
            set { SetValue(PassWordImageProperty, value); }
        }


        void PassWordImageSource_Tapped(System.Object sender, System.EventArgs e)
        {
            if (EntryField.IsPassword)
            {
                EntryField.IsPassword = false;
                PassWordImageSource.Source = "eyeone.png";
                return;
            }

            EntryField.IsPassword = true;
            PassWordImageSource.Source = "eyetwo.png";
        }

        public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create(nameof(ReturnType), typeof(ReturnType), typeof(CustomEntryView),
           defaultValue: ReturnType.Default, defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnReturnTypeChanged);

        private static void OnReturnTypeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;
            var customEntry = bindable as CustomEntryView;
            customEntry.EntryField.ReturnType = (ReturnType)newValue;
        }

        public ReturnType ReturnType
        {
            get { return (ReturnType)GetValue(ReturnTypeProperty); }
            set { SetValue(ReturnTypeProperty, value); }
        }

        public static readonly BindableProperty KeyboardTypeProperty = BindableProperty.Create(nameof(KeyboardType), typeof(Keyboard), typeof(CustomEntryView),
         defaultValue: Keyboard.Default, defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnKeyboardTypeChanged);

        private static void OnKeyboardTypeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;
            var customEntry = bindable as CustomEntryView;
            customEntry.EntryField.Keyboard = (Keyboard)newValue;
        }

        public Keyboard KeyboardType
        {
            get { return (Keyboard)GetValue(KeyboardTypeProperty); }
            set { SetValue(KeyboardTypeProperty, value); }
        }

        void EntryField_Focused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            //MainFrame.BorderColor = Color.Green;
            MainFrame.BorderColor = Color.FromHex("#8DAA6A");
        }

        void EntryField_Unfocused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            MainFrame.BorderColor = Color.FromHex("#FAFAFA");
            // this get the resource base on the key
            //MainFrame.BorderColor = (Color)Application.Current.Resources["Secondary"];
        }
    }
}

