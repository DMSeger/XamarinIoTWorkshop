﻿using Android.App;
using Android.OS;

using XamarinIoTWorkshop.Shared;

namespace XamarinIoTWorkshop.Droid
{
    [Activity(Label = "XamarinIoTWorkshop", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            SyncfusionServices.InitializeSyncfusion();

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            global::Xamarin.FormsMaps.Init(this, savedInstanceState);

            Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
    }
}

