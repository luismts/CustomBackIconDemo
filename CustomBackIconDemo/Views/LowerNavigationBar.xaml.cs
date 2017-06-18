﻿using CustomBackIconDemo.Pages;
using Xamarin.Forms;

namespace CustomBackIconDemo.Views
{
    public partial class LowerNavigationBar : ContentView
    {
        public LowerNavigationBar()
        {
            InitializeComponent();
        }

		async void OnNavBarButtonLabelTappedAsync(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new MenuPage(9));
		}
    }
}
