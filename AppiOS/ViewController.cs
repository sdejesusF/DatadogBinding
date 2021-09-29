using Datadog;
using Foundation;
using System;
using UIKit;

namespace AppiOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            DDAppContext appContext = new DDAppContext(NSBundle.MainBundle);

            DDConfigurationBuilder dDConfigurationBuilder = DDConfiguration.BuilderWithRumApplicationID("", "", "");
            dDConfigurationBuilder.TrackUIKitActions();
            DDDatadog.InitializeWithAppContext(appContext, DDTrackingConsent.Granted, dDConfigurationBuilder.Build());

            DDTracerConfiguration dDTracerConfiguration = new DDTracerConfiguration();
            dDTracerConfiguration.SendNetworkInfo(true);
            DDTracer dDTracer = new DDTracer(dDTracerConfiguration);

            DDGlobal.SharedTracer = dDTracer;

            DDLoggerBuilder loggerBuilder = DDLogger.Builder();
            loggerBuilder.SendNetworkInfo(true);
            var logger = loggerBuilder.Build();

            DDRUMMonitor dDRUMMonitor = new DDRUMMonitor();
            dDRUMMonitor.Init();

            DDGlobal.Rum = dDRUMMonitor;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
