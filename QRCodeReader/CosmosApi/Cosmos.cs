﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace QRCodeReader.CosmosApi
{
    public class Cosmos
    {
        public static void Initialize()
        {
            var url = "https://api.cosmos.bluesoft.com.br/gtins/7891910000197.json";
        }

        public static object GetProductInfo(string url)
        {
            CosmosWebClient wc = new CosmosWebClient();
            try
            {
                return wc.DownloadString(url);
            }
            catch (AuthenticationRequiredException authEx)
            {
                return $"Authentication problem: {authEx.Message}";
            }
            catch (Exception ex)
            {
                return $"Problem when downloading the product: {ex.Message}";
            }
        }
    }
}