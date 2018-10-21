using Foundation;
using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.ViewModels;
using UIKit;

namespace mobile.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            var setup = new Setup();
            setup.PlatformInitialize(this, Window);

            LoadApplication(setup.FormsApplication);

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}
