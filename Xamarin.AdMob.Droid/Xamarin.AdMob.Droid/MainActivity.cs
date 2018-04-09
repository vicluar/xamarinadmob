using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;

namespace Xamarin.AdMob.Droid
{
    [Activity(Label = "Xamarin.AdMob.Droid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var id = "ca-app-pub-1111111111~22222222222";
            MobileAds.Initialize(ApplicationContext, id);

            var adView = FindViewById<AdView>(Resource.Id.adView);
            var adRequest = new AdRequest.Builder().Build();
            adView.LoadAd(adRequest);
        }
    }
}

