using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading;

namespace roblox_api_wrapper__written_in_csharp.Source.root
{

    public class GameDetails
    {
        public string GetGameInfo(string id, string data)
        {

            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://www.roblox.com/places/api-get-details?assetId={id}");

                JToken info = JToken.Parse(api);

                switch (data)
                {
                    case "name":
                        return info["Name"].ToString();
                    case "desc":
                        return info["Description"].ToString();
                    case "created":
                        return info["Created"].ToString();
                    case "updated":
                        return info["Updated"].ToString();
                    case "url":
                        return info["Url"].ToString();
                    case "visitedcount":
                        return info["VisitedCount"].ToString();
                    case "favoritedcount":
                        return info["FavoritedCount"].ToString();
                    default:
                        break;
                }
                return string.Empty;
            }
        }
    }
}