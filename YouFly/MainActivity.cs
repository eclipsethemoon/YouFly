﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace YouFly
{
    [Activity(Theme = "@style/android:Theme.Holo.Light.NoActionBar", Label = "YouFly", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //Initializing button from layout
            Button login = FindViewById<Button>(Resource.Id.login);

            //Login button click action
            login.Click += (object sender, EventArgs e) => {
                Android.Widget.Toast.MakeText(this, "Login Button Clicked!", Android.Widget.ToastLength.Short).Show();
            };
        }
    }
}

