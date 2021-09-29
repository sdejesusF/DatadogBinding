using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Com.Datadog.Android.Rum.Tracking;
using Com.Datadog.Android;
using Com.Datadog.Android.Privacy;
using Com.Datadog.Android.Tracing;
using Com.Datadog.Android.Rum;
using IO.Opentracing.Util;
using DatadogLogger = Com.Datadog.Android.Log.Logger;
using Com.Datadog.Android.Log;

namespace AppAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Logger logger;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            var credentials = new Com.Datadog.Android.Core.Configuration.Credentials("", "env", "", "", null);
            var configurationBuilder = new Com.Datadog.Android.Core.Configuration.Configuration.Builder(true, true, true, true);
            configurationBuilder.UseViewTrackingStrategy(new ActivityViewTrackingStrategy(true));
            configurationBuilder.TrackInteractions();
            Datadog.Initialize(ApplicationContext, credentials, configurationBuilder.Build(), TrackingConsent.Granted);

            var tracer = new AndroidTracer
                .Builder()
                .SetBundleWithRumEnabled(true)
                .Build();
            GlobalTracer.RegisterIfAbsent(tracer);

            logger = new DatadogLogger
                .Builder()
                .SetNetworkInfoEnabled(true)
                .SetBundleWithRumEnabled(true)
                .Build();

            var monitor = new RumMonitorBuilder()
                .Build();

            GlobalRum.RegisterIfAbsent(monitor);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            logger.D("Hi from DD");
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
