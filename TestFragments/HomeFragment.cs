
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace TestFragments
{
    public class HomeFragment : Fragment
    {
        int count = 1;

        public override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);
        }

        public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var view = inflater.Inflate (Resource.Layout.HomeLayout, container, false);

            Button button = view.FindViewById<Button> (Resource.Id.myButton);

            button.Click += delegate { button.Text = string.Format ("{0} clicks!", count++); };

            return view;
        }
    }
}
