using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JuniorFINNApp
{
    public class Ads
    {
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }


        public List<Ads> AllAdsList = new List<Ads>();

       
        public void ConvertJSONDataIntoAds()
        {
            string uri = "https://gist.githubusercontent.com/3lvis/3799feea005ed49942dcb56386ecec2b/raw/63249144485884d279d55f4f3907e37098f55c74/discover.json";
            var json = new WebClient().DownloadString(uri);
            JsonConvert.DeserializeObject<List<Ads>>(json);
        }


    }


}
