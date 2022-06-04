using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace roblox_api_wrapper__written_in_csharp.Source.root
{   

    public class Asset
    {
        public string GetAssetFull(int assetID)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"https://api.roblox.com/Marketplace/ProductInfo?assetId={assetID}");
            }
        }
        public string GetAssetName(long assetID)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/Marketplace/ProductInfo?assetId={assetID}");
                JToken data = JToken.Parse(api);
                return data["Name"].ToString();
            }
        }
        public string GetAssetDescription(long assetID)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/Marketplace/ProductInfo?assetId={assetID}");
                JToken data = JToken.Parse(api);
                return data["Description"].ToString();
            }
        }
        public string GetAssetCreator(long assetID)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/Marketplace/ProductInfo?assetId={assetID}");
                JToken data = JToken.Parse(api);
                return data["Creator"]["Name"].ToString();
            }
        }
        public string GetAssetCreatedDate(long assetID)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/Marketplace/ProductInfo?assetId={assetID}");
                JToken data = JToken.Parse(api);
                return data["Created"].ToString();
            }
        }
        public string GetAssetLastUpdatedDate(long assetID)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/Marketplace/ProductInfo?assetId={assetID}");
                JToken data = JToken.Parse(api);
                return data["Updated"].ToString();
            }
        }
    }
}
