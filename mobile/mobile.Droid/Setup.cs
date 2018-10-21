using Android.Content;
using mobile.Core;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace mobile.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        protected override IMvxApplication CreateApp() => new CoreApp();

        protected override Xamarin.Forms.Application CreateFormsApplication()
        {
            return new Xamarin.Forms.Application();
        }
    }
}
