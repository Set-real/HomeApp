﻿using HomeApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NewDevicePage();
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
