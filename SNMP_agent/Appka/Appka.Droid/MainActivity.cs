using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Appka.Droid;
using Appka.SnmpServiceReference;

namespace Apka.Droid
{
    [Activity(Label = "Apka", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Spinner spinner;
        Button button1;
        Button button2;
        TextView textview1;
        TextView textview2;
        EditText editText;
        String oid;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "Main" layout resource
            SetContentView(Resource.Layout.Main);

            spinner = FindViewById<Spinner>(Resource.Id.spinner);

            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.oid_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += Btn_Click1;
            button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += Btn_Click2;
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            spinner = FindViewById<Spinner>(Resource.Id.spinner);
            textview2 = FindViewById<TextView>(Resource.Id.textView2);

            var snmpServiceClient = new SnmpServiceClient();
            var snmpObject = new SnmpTypeObject() { Oid = ".1.3.6.1.2.1.1.3.0" };
            snmpServiceClient.GetAsync(snmpObject);

            textview2.Text = "OID for " + spinner.SelectedItem.ToString() + ": " + oid;
        }

        private void Btn_Click2(object sender, EventArgs e)
        {
            editText = FindViewById<EditText>(Resource.Id.editText);
            textview2 = FindViewById<TextView>(Resource.Id.textView2);

            //get z editboxa

            textview2.Text = editText.Text;
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;

            string toast = string.Format("The oid is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();

            if (spinner.SelectedItem.ToString() == "sysDescr")
                oid = ".1.3.6.1.2.1.1.1.0";
            else if (spinner.SelectedItem.ToString() == "sysObjectID")
                oid = ".1.3.6.1.2.1.1.2.0";
            else if (spinner.SelectedItem.ToString() == "sysUpTime")
                oid = ".1.3.6.1.2.1.1.3.0";
            else if (spinner.SelectedItem.ToString() == "sysContact")
                oid = ".1.3.6.1.2.1.1.4.0";
            else if (spinner.SelectedItem.ToString() == "sysName")
                oid = ".1.3.6.1.2.1.1.5.0";
            else if (spinner.SelectedItem.ToString() == "sysLocation")
                oid = ".1.3.6.1.2.1.1.6.0";
            else if (spinner.SelectedItem.ToString() == "sysServices")
                oid = ".1.3.6.1.2.1.1.7.0";

            textview1 = FindViewById<TextView>(Resource.Id.textView1);
            textview1.Text = "OID for " + spinner.SelectedItem.ToString() + ": " + oid;
        }
    }
}