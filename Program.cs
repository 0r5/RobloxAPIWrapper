using roblox_api_wrapper__written_in_csharp.Source.root;

namespace roblox_api_wrapper__written_in_csharp
{
    class Wrapper
    {
        static void Main(string[] args)
        {

            // Misc setup

            Miscellaneous misc = new Miscellaneous();

            // Roblox group example
            RobloxGroup group = new RobloxGroup();

            // get the group name
            string group_name = group.GetGroupName(12056516);
            Console.WriteLine($"Group name: {group_name}");

            // get the group description
            string group_desc = group.GetGroupDescription(12056516);
            Console.WriteLine($"Group description: {group_desc}");

            // get the group owner's id
            string group_owner = group.GetGroupOwner(12056516);
            Console.WriteLine($"Group owner ID: {group_owner}");

            // Get asset example
            Asset asset = new Asset();

            // get the asset name
            string asset_name = asset.GetAssetName(9583116970);
            Console.WriteLine($"Asset name: {asset_name}");

            // get the asset desc
            string asset_desc = asset.GetAssetDescription(9583116970);
            Console.WriteLine($"Asset description: {asset_desc}");

            // get the asset owner's name
            string asset_owner = asset.GetAssetCreator(9583116970);
            Console.WriteLine($"Asset owner: {asset_owner}");

            // get the date the asset was created on
            string asset_createdAt = asset.GetAssetCreatedDate(9583116970);
            Console.WriteLine($"Asset created at: {asset_createdAt}");

            // get the date the asset was updated on
            string asset_updatedAt = asset.GetAssetLastUpdatedDate(9583116970);
            Console.WriteLine($"Asset updated at: {asset_updatedAt}");

            // Get details about an user example
            UserDetails details = new UserDetails();
            
            // get the user's id
            string userId = details.GetUserID("shedletsky");
            Console.WriteLine($"User ID: {userId}");

            // check if the user's online
            string userCheck = details.GetUserState("shedletsky");
            Console.WriteLine($"Is the user online? {userCheck}");

            // get the user's last online date
            Console.WriteLine($"User's last online date: {details.GetLastOnlineDate("1")}");

            // get user headshot
            Console.WriteLine($"User headshot: {details.GetUserHeadshot("1")}");

            // Get Roblox version

            Console.WriteLine($"Roblox player version: {misc.GetRobloxVersion()}");

            // Asset logger (on, off)
            //misc.AssetLogger("on");

            //misc.AssetLogger("off"); // broken, if you're gonna use the logger you're not gonna turn it off anytime soon

            // Get game details

            GameDetails gameDetails = new GameDetails();

            // gameDetails.GetGameInfo("id", "the info you want to get (name, desc, created, updated, url, visitedcount, favoritedcount)")

            // Get game info

            string gameName = gameDetails.GetGameInfo("606849621", "name");
            string gameDesc = gameDetails.GetGameInfo("606849621", "desc");
            string gameCreatedAt = gameDetails.GetGameInfo("606849621", "created");
            string gameUpdatedAt = gameDetails.GetGameInfo("606849621", "updated");
            string gameUrl = gameDetails.GetGameInfo("606849621", "url");
            string gameVisitedCount = gameDetails.GetGameInfo("606849621", "visitedcount");
            string gameFavoritedCount = gameDetails.GetGameInfo("606849621", "favoritedcount");

            Console.WriteLine($"Game name: {gameName}\nGame created at: {gameCreatedAt}\nGame updated at: {gameUpdatedAt}\nGame url: {gameUrl}\nGame visited: {gameVisitedCount} times\nGame favorited: {gameFavoritedCount} times");

        }
    }
}