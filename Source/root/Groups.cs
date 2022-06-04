using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace roblox_api_wrapper__written_in_csharp.Source.root
{

    public class RobloxGroup
    {
        public string GetGroupJSONInfo(int groupID)
        {
            using (WebClient client = new WebClient()) // I don't care if it's deprecated or not, webclient better
            {
                return client.DownloadString($"https://groups.roblox.com/v2/groups?groupIds={groupID.ToString()}");
            }
        }
        public string GetGroupName(int groupID)
        {
            string name = string.Empty;
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://groups.roblox.com/v2/groups?groupIds={groupID.ToString()}");
                JToken data = JToken.Parse(api);
                return data["data"][0]["name"].ToString();
            }
        }

        public string GetGroupDescription(int groupID)
        {
            string name = string.Empty;
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://groups.roblox.com/v2/groups?groupIds={groupID.ToString()}");
                JToken data = JToken.Parse(api);
                return data["data"][0]["description"].ToString();
            }
        }
        public string GetGroupOwner(int groupID)
        {
            string name = string.Empty;
            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString($"https://groups.roblox.com/v2/groups?groupIds={groupID.ToString()}");
                JToken data = JToken.Parse(api);
                return data["data"][0]["owner"]["id"].ToString();
            }
        }
    }
}
