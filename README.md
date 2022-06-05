# kfWrapper

A Roblox API wrapper I made in C# for the fun of learning it

# Group Documentation
```txt
Setup: RobloxGroup groupDetails = new RobloxGroup();

Group info:
	- Get the group's name: groupDetails.GetGroupName(<id>);
	- Get the group's description: groupDetails.GetGroupDescription(<id>);
	- Get the group's owner: groupDetails.GetGroupOwner(<id>);
```
# Asset documentation
```txt
Setup: Asset assetDetails = new Asset();

Asset info:
	- Get the asset's name: assetDetails.GetAssetName(<id>);
	- Get the asset's description: assetDetails.GetAssetDescription(<id>);
	- Get the asset owner: assetDetails.GetAssetCreator(<id>);
	- Get the date the asset was created on: assetDetails.GetAssetCreatedDate(<id>);
	- Get the date the asset was updated on: assetDetails.GetAssetLastUpdatedDate(<id>);
```
# User documentation
```txt
Setup: UserDetails userDetails = new UserDetails();

User info:
	- Get the user's ID: userDetails.GetUserID("name");
	- Check if the user's online: userDetails.GetUserState("name");
	- Get the user's last online date: userDetails.GetLastOnlineDate("id");
	- Get the user's headshot: userDetails.GetUserHeadshot("id");
```
# Game details documentation
```txt
Setup: GameDetails gameDetails = new gameDetails();

Game info:
	- Get the game's name: gameDetails.GetGameInfo("game id", "name");
	- Get the game's description: gameDetails.GetGameInfo("game id", "desc");
	- Get the game's created date: gameDetails.GetGameInfo("game id", "created");
	- Get the game's updated date: gameDetails.GetGameInfo("game id", "updated");
	- Get the game's visits: gameDetails.GetGameInfo("game id", "visitedcount");
	- Get the game's favorites: gameDetails.GetGameInfo("game id", "favoritedcount");
```
# Misc documentation
```txt
Setup: Miscellaneous misc = new Miscellaneous();

- Get the roblox version: misc.GetRobloxVersion();
```
