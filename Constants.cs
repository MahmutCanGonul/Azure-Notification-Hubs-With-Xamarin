using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinanceApp.Droid
{
    public static class Constants
    {
        public const string ListenConnectionString = "Endpoint=sb://bexexchangeapp.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=uGMd/XKmO7VPsdOf8M9qdQZAe7XCCAn+8aOngBjtN2E=";
        public const string NotificationHubName = "bexexchangeappmain";
    }
}