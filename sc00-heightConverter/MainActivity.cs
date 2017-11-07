using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace sc00_heightConverter
{
    [Activity(Label = "sc00_heightConverter", MainLauncher = true)]
    public class MainActivity : Activity
    {
        string appName = "sc00_heightConverter";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.btnConvert);
            EditText height = FindViewById<EditText>(Resource.Id.editHeight);
            EditText inches = FindViewById<EditText>(Resource.Id.editInches);
            TextView result = FindViewById<TextView>(Resource.Id.result);

            button.Click += delegate
            {
                var totalInches = (System.Convert.ToInt16(height.Text) * 12) + System.Convert.ToInt16(inches.Text);

                Log.Info(appName, "Height is set to" + totalInches);
                result.Text = System.Convert.ToString(System.Convert.ToDouble(totalInches * 2.54)) + " centimeters";
            };
        }
    }
}

