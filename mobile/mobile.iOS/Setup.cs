using MvvmCross.ViewModels;
using MvvmCross.Forms.Platforms.Ios.Core;
using mobile.Core;

namespace mobile.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        public Setup()
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }

        protected override Xamarin.Forms.Application CreateFormsApplication()
        {
            return new Xamarin.Forms.Application();
        }
    }
}

