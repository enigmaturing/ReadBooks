﻿using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadBooks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new MainPage());
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("8f6b4bd2-9436-4362-a3f5-2306e81f5f0f",
                            typeof(Analytics), typeof(Crashes));

            bool didAppCrash = await Crashes.HasCrashedInLastSessionAsync();
            if (didAppCrash)
            {
                await MainPage.DisplayAlert("Sorry", "It appears we had some issue there, sorry about that.", "It is ok!");
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
