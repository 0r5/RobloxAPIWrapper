using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace roblox_api_wrapper__written_in_csharp.Source.root
{

    public class UserDetails
    {
        public string GetUserJSONInfo(string Username)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"https://api.roblox.com/users/get-by-username?username={Username}");
            }
        }
        public string GetUserID(string Username)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/users/get-by-username?username={Username}");
                JToken data = JToken.Parse(api);
                return data["Id"].ToString();
            }
        }
        public string GetUserState(string Username)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/users/get-by-username?username={Username}");
                JToken data = JToken.Parse(api);
                return data["IsOnline"].ToString();
            }
        }
        public string GetUserHeadshot(string ID)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://thumbnails.roblox.com/v1/users/avatar-headshot?userIds={ID}&size=48x48&format=Png&isCircular=false");
                JToken data = JToken.Parse(api);
                return data["data"][0]["imageUrl"].ToString();
            }
        }
        public string GetLastOnlineDate(string ID)
        {
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://api.roblox.com/users/{ID}/onlinestatus/");
                JToken data = JToken.Parse(api);
                return data["LastOnline"].ToString();
            }
        }
    }
}
