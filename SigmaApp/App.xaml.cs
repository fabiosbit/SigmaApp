﻿using System;
using Xamarin.Forms;

namespace SigmaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            Current.RequestedThemeChanged += (s, a) =>
            {
                Environment.Exit(0);
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
