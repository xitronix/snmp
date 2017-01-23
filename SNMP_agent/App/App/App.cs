using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.ServiceModel;

namespace mainApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "App",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);


        }

        private void callWCF()
        {
            //var endpoint = new EndpointAddress("http://localhost:54002/SnmpService.svc");

            //var binding = new BasicHttpBinding
            //{
            //    Name = "basicHttpBinding",
            //    MaxBufferSize = 2147483647,
            //    MaxReceivedMessageSize = 2147483647
            //};
            //var snmpServiceClient = new SnmpServiceClient();
            //var snmpObject = new SnmpTypeObject() { Oid = ".1.3.6.1.2.1.1.3.0" };
            //snmpServiceClient.GetAsync(snmpObject);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
