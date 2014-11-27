#pragma strict

function Start () {										// Script creates a reference to itself so it is accessible from any other script --> Used for SINGLETON
	
	// Change ship settings based on the one chosen by the player in the Main Menu
	if(PlayerPrefs.GetInt("ship") == 0)								// 0 = Player chose Katana
	{
		print ("Player chose " + PlayerPrefs.GetInt("ship 01"));
	}
	if(PlayerPrefs.GetInt("ship") == 1)								// 1 = Player chose Serenity
	{
		print ("Player chose " + PlayerPrefs.GetInt("ship 02"));
	}
}