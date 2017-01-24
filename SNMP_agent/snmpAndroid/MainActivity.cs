using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.ServiceModel;
using SnmpService;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace snmpAndroid
{
    [Activity(Label = "snmpAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static readonly EndpointAddress EndPoint = new EndpointAddress("http://192.168.42.101:54002/SnmpService.svc");
        //private SnmpServiceClient client;

        Spinner spinner;
        Button button1;
        Button button2;
        TextView textview1;
        TextView textview2;
        EditText editText;
        SnmpTypeObject snmpObject;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            snmpObject = new SnmpTypeObject();

            // Set our view from the "Main" layout resource
            SetContentView(Resource.Layout.Main);

            //InitializeGetSnmpServiceClient();
            //snmpObject = new SnmpTypeObject();

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

        //private void InitializeGetSnmpServiceClient()
        //{
        //    BasicHttpBinding binding = CreateBasicHttp();

        //    client = new SnmpServiceClient(binding, EndPoint);
        //    client.GetCompleted += ClientOnGetCompleted;
        //}

        //private void InitializeGetSnmpServiceClient()
        //{
        //    BasicHttpBinding binding = CreateBasicHttp();

        //    client = new SnmpServiceClient(binding, EndPoint);
        //    client.GetCompleted += ClientOnGetCompleted;
        //}

        //private static BasicHttpBinding CreateBasicHttp()
        //{
        //    BasicHttpBinding binding = new BasicHttpBinding
        //    {
        //        Name = "basicHttpBinding",
        //        MaxBufferSize = 2147483647,
        //        MaxReceivedMessageSize = 2147483647
        //    };
        //    TimeSpan timeout = new TimeSpan(0, 0, 30);
        //    binding.SendTimeout = timeout;
        //    binding.OpenTimeout = timeout;
        //    binding.ReceiveTimeout = timeout;
        //    return binding;
        //}

        //private void Btn_Click1(object sender, EventArgs eventArgs)
        //{
        //    Console.WriteLine("Oid wysylanego z komorki obiektu: " + snmpObject.Oid);
        //    client.GetAsync(snmpObject);
        //}

        //private void ClientOnGetCompleted(object sender, GetCompletedEventArgs e)
        //{
        //    textview2 = FindViewById<TextView>(Resource.Id.textView2);
        //    string msg = null;

        //    if (e.Error != null)
        //    {
        //        msg = e.Error.Message;
        //    }
        //    else if (e.Cancelled)
        //    {
        //        msg = "Request was cancelled.";
        //    }
        //    else
        //    {
        //        msg = e.Result.Value;
        //    }
        //    RunOnUiThread(() => textview2.Text = "Returned value is: " + msg);
        //}

        private void Btn_Click1(object sender, EventArgs e)
        {
            spinner = FindViewById<Spinner>(Resource.Id.spinner);
            textview2 = FindViewById<TextView>(Resource.Id.textView2);

            //EndpointAddress EndPoint = new EndpointAddress("http://192.168.42.46:54003/SnmpService.svc");
            //EndpointAddress EndPoint = new EndpointAddress("http://localhost:54002/SnmpService.svc");
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "basicHttpBinding",
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647
            };
            TimeSpan timeout = new TimeSpan(0, 0, 30);
            binding.SendTimeout = timeout;
            binding.OpenTimeout = timeout;
            binding.ReceiveTimeout = timeout;

            //var client = new UdpClient();
            //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.42.109"), 11000); // endpoint where server is listening (testing localy)
            //client.Connect(ep);

            var snmpServiceClient = new SnmpServiceClient(binding, EndPoint);
            var snmpObject = new SnmpTypeObject() { Oid = ".1.3.6.1.2.1.1.3.0" };
            snmpObject = snmpServiceClient.Get(snmpObject);

            //byte[] msg = Encoding.ASCII.GetBytes(snmpObject.Oid);
            //int size = Encoding.ASCII.GetByteCount(msg.ToString());
            //// send data
            //client.Send(msg, size);

            //var client = new UdpClient();
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.42.109"), 11000); // endpoint where server is listening (testing localy)
            //client.Connect(endPoint);
            //var oid = ".1.3.6.1.2.1.1.3.0";
            //byte[] msg = Encoding.ASCII.GetBytes(oid);
            //int size = Encoding.ASCII.GetByteCount(oid);
            //client.Send(msg, size);
            //endPoint = new IPEndPoint(IPAddress.Any, 11001);
            //var receive = client.Receive(ref endPoint);

            //textview2.Text = "Received value is: " + receive.ToString();

            //UdpClient udpServer = new UdpClient(11001);

            //var client = new UdpClient();
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.42.241"), 11000); // endpoint where server is listening (testing localy)
            //client.Connect(endPoint);
            //var oid = ".1.3.6.1.2.1.1.3.0";
            //byte[] msg = Encoding.ASCII.GetBytes(oid);
            //int size = Encoding.ASCII.GetByteCount(oid);
            //client.Send(msg, size);
            //while (true)
            //{
            //    endPoint = new IPEndPoint(IPAddress.Any, 11001);
            //    var receive = udpServer.Receive(ref endPoint);
            //    textview2.Text = "Received value is: " + Encoding.ASCII.GetString(receive);
            //}

            textview2.Text = "OID for " + spinner.SelectedItem.ToString() + ": " + snmpObject.Value;
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
                snmpObject.Oid = ".1.3.6.1.2.1.1.1.0";
            else if (spinner.SelectedItem.ToString() == "sysObjectID")
                snmpObject.Oid = ".1.3.6.1.2.1.1.2.0";
            else if (spinner.SelectedItem.ToString() == "sysUpTime")
                snmpObject.Oid = ".1.3.6.1.2.1.1.3.0";
            else if (spinner.SelectedItem.ToString() == "sysContact")
                snmpObject.Oid = ".1.3.6.1.2.1.1.4.0";
            else if (spinner.SelectedItem.ToString() == "sysName")
                snmpObject.Oid = ".1.3.6.1.2.1.1.5.0";
            else if (spinner.SelectedItem.ToString() == "sysLocation")
                snmpObject.Oid = ".1.3.6.1.2.1.1.6.0";
            else if (spinner.SelectedItem.ToString() == "sysServices")
                snmpObject.Oid = ".1.3.6.1.2.1.1.7.0";

            textview1 = FindViewById<TextView>(Resource.Id.textView1);
            textview1.Text = "OID for " + spinner.SelectedItem.ToString() + ": " + snmpObject.Oid;
        }
    }
}