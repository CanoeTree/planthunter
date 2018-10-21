using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Presenters;
using MvvmCross.Platforms.Android.Presenters;
using Xamarin.Forms;

namespace mobile.Droid
{
    [Activity(Label = "MainActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity
        : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);

            Forms.Init(this, bundle);

            var formsPresenter = (MvxFormsPagePresenter)Mvx.IoCProvider.Resolve<IMvxAndroidViewPresenter>();
            LoadApplication(formsPresenter.FormsApplication);
        }
    }
}


