using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace QRCodeReader.CosmosApi
{
    public class CosmosWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = (HttpWebRequest)base.GetWebRequest(address);
            request.Headers["X-Cosmos-Token"] = "iHZDpLYr_Kq5O6opM8AnjA";
            base.Encoding = Encoding.UTF8;
            return request;
        }
    }
}