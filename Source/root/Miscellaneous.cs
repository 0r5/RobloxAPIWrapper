using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading;

namespace roblox_api_wrapper__written_in_csharp.Source.root
{

    public class Miscellaneous
    {
        public string GetRobloxVersion()
        {
            return new WebClient().DownloadString("http://setup.roblox.com/version");
        }

        public string AssetLogger(string toggle)
        {

            Console.WriteLine("\n -- WARNING: THIS LOGGER DOESN'T LOG THE ASSETS IN ORDER -- \n");

            if (toggle == "on")
            {
                while (toggle == "on")
                {
                    using (WebClient client = new WebClient())
                    {
                        string API = client.DownloadString("https://search.roblox.com/catalog/json?CatalogContext=2&Category=6&SortType=3&ResultsPerPage=20");
                        JToken token = JToken.Parse(API);

                        Console.WriteLine("\n -- ASSET LOGGER -- \n");

                        Random intNum = new Random(); // Probably not the best way to make an asset logger but oh well :shrug:

                        string name = token[intNum.Next(1, 19)]["Name"].ToString();
                        string desc = token[intNum.Next(1, 19)]["Description"].ToString();
                        string id = token[intNum.Next(1, 19)]["AssetId"].ToString();
                        string creator = token[intNum.Next(1, 19)]["Creator"].ToString();

                        Console.WriteLine($"Asset ID: {id}\nAsset name: {name}\nAsset description: '{desc}'\nAsset creator: {creator}");
                        Thread.Sleep(5000);
                    }
                }
            } else
            {
                Console.WriteLine("\n -- ASSET LOGGER STOPPED -- \n");
            }
            return string.Empty;
        }
    }
}
