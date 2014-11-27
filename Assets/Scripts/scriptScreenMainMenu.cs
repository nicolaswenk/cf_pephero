// Main Menu script

using UnityEngine;
using System.Collections;

public class scriptScreenMainMenu : MonoBehaviour {
	
// Inspector variables
	public bool katana = true;
	public bool serenity = false;
	
// User Interface
	void Update ()
	{

	}
	
	void OnGUI ()
	{
	// Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100,175));
		
		//Make a box to see the group on screen
		GUI.Box (new Rect(0,0,100,175),"Main Menu");



		// Add buttons for game navigation
//		if (GUI.Button(new Rect(10,30,80,30),"Start Game"))				// Creates button to Start Game
//		{
//			Application.LoadLevel ("ScreenLoad");
//		}
//		if (GUI.Button(new Rect(10,65,80,30),"Credits"))				// Creates button to show Credits
//		{
//			Application.LoadLevel ("ScreenCredits");
//		}
//		if (GUI.Button(new Rect(10,100,80,30),"Exit"))					// Creates button Exit to quit the game
//		{
//			Application.Quit ();
//		}
//		if (GUI.Button(new Rect(10,135,80,30),"HomePage"))				// Creates button to access specified web page
//		{
//			Application.OpenURL ("http://www.cysticfibrosis.net/");
//		}
		
		// End the group started from above		
		GUI.EndGroup ();
		
		// Choice between Katana and Serenity ship
		GUI.Box (new Rect(Screen.width / 2 - 100,Screen.height / 3, 200,20),"CHOOSE YOUR SPACESHIP");						// Indicates the player to choose a ship
		
	// Make a group on the left of the screen for KATANA
		GUI.BeginGroup (new Rect(Screen.width / 4 + 50, Screen.height / 5 * 3 + 30, 110,100));
		
		//Make a box to see the group on screen to show left ship information
		GUI.Box (new Rect(0,0,110,100),"");
		GUI.Label (new Rect(10,10,80,30), "Power		++");
		GUI.Label (new Rect(10,30,80,30), "Speed		++");
		GUI.Label (new Rect(10,50,80,30), "Health 		+");
		GUI.Label (new Rect(10,70,80,30), "Shield 		+");
		
		// End the group started from above		
		GUI.EndGroup ();
		
	// Make a group on the right of the screen for SERENITY
		GUI.BeginGroup (new Rect(Screen.width / 5 * 3 + 75, Screen.height / 5 * 3 + 30, 110,100));
		
		//Make a box to see the group on screen to show left ship information
		GUI.Box (new Rect(0,0,110,100),"");
		GUI.Label (new Rect(10,10,80,30), "Power		+");
		GUI.Label (new Rect(10,30,80,30), "Speed		+");
		GUI.Label (new Rect(10,50,80,30), "Health 		++");
		GUI.Label (new Rect(10,70,80,30), "Shield 		++");
		
		// End the group started from above		
		GUI.EndGroup ();
	}
}
