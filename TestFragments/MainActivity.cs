using Android.App;
using Android.OS;
using System;

namespace TestFragments
{
    [Activity (Label = "TestFragments", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            var loginFragment = new LoginFragment ();

            loginFragment.OnEventSuccess += (sender, e) => {
                SetMainPageFragment ();
            };

            //Tanto con el Add como con el Replace funciono igual
            //FragmentManager.BeginTransaction ().Add (Resource.Id.fragment_container, loginFragment).Commit ();

            SwapFragments (loginFragment);
        }

        void SwapFragments (Fragment fragment)
        {
            if (fragment == null)
                throw new ArgumentNullException (nameof (fragment));

            FragmentManager.BeginTransaction ().Replace (Resource.Id.fragment_container, fragment, fragment.GetType().Name).Commit();
        }

        void SetMainPageFragment ()
        {
            var home = new HomeFragment ();
            SwapFragments (home);
        }
    }
}

