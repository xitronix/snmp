using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Appka.SnmpServiceReference;

using Xamarin.Forms;

namespace Appka
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "Appka",
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

            var snmpServiceClient = new SnmpServiceClient();
            var snmpObject = new SnmpTypeObject() { Oid = ".1.3.6.1.2.1.1.3.0" };
            snmpServiceClient.GetAsync(snmpObject);
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
