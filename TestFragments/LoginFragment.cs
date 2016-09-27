﻿
using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace TestFragments
{
    public class LoginFragment : Fragment
    {
        public event EventHandler OnEventSuccess;

        public override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);
        }

        public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var view = inflater.Inflate (Resource.Layout.LoginLayout, container, false);

            var buttton = view.FindViewById<Button> (Resource.Id.loginButton);

            buttton.Click += (sender, e) => {
                OnEventSuccess?.Invoke (this, new EventArgs ());
            };

            return view;
        }
    }
}
