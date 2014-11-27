// Main Menu script

using UnityEngine;
using System.Collections;

public class scriptScreenMainMenu2 : MonoBehaviour {
	
// Inspector variables
	public bool katana = true;
	public bool serenity = false;
	
// User Interface
	void Update ()
	{
//		if (katana)
//		{PlayerPrefs.SetInt("ship",0);}
//		if (serenity)
//		{PlayerPrefs.SetInt("ship",1);}
	}
	
	void OnGUI ()
	{
	// Make a group on the center of the screen
//		GUI.BeginGroup (new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100,175));
//		
//		//Make a box to see the group on screen
//		GUI.Box (new Rect(0,0,100,175),"Main Menu");
//		
//		// Add buttons for game navigation
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
//			Application.OpenURL ("http://www.affordancestudio.com/");
//		}
//		
//		// End the group started from above		
//		GUI.EndGroup ();
//		
//		// Choice between Katana and Serenity ship
//		if(serenity = !GUI.Toggle (new Rect(Screen.width / 3, Screen.height / 5 * 3, 100, 30),katana,"Katana"))		// Creates button to choose Katana ship
//			{serenity = !katana;}																							// Deselects Serenity when Katana selected
//		if(katana = !GUI.Toggle (new Rect(Screen.width / 3 * 2, Screen.height / 5 * 3, 100, 30),serenity,"Serenity"))		// Creates button to choose Serenity ship
//			{katana = !serenity;}																							// Deselects Katana when Serenity selected
//		
//		GUI.Box (new Rect(Screen.width / 2 - 100,Screen.height / 3, 200,20),"CHOOSE YOUR BATTLESHIP");						// Indicates the player to choose a ship
//		
//	// Make a group on the left of the screen for KATANA
//		GUI.BeginGroup (new Rect(Screen.width / 4 + 50, Screen.height / 5 * 3 + 30, 110,100));
//		
//		//Make a box to see the group on screen to show left ship information
//		GUI.Box (new Rect(0,0,110,100),"");
//		GUI.Label (new Rect(10,10,80,30), "Power		++");
//		GUI.Label (new Rect(10,30,80,30), "Speed		++");
//		GUI.Label (new Rect(10,50,80,30), "Health 		+");
//		GUI.Label (new Rect(10,70,80,30), "Shield 		+");
//		
//		// End the group started from above		
//		GUI.EndGroup ();
//		
//	// Make a group on the right of the screen for SERENITY
//		GUI.BeginGroup (new Rect(Screen.width / 5 * 3 + 75, Screen.height / 5 * 3 + 30, 110,100));
//		
//		//Make a box to see the group on screen to show left ship information
//		GUI.Box (new Rect(0,0,110,100),"");
//		GUI.Label (new Rect(10,10,80,30), "Power		+");
//		GUI.Label (new Rect(10,30,80,30), "Speed		+");
//		GUI.Label (new Rect(10,50,80,30), "Health 		++");
//		GUI.Label (new Rect(10,70,80,30), "Shield 		++");
//		
//		// End the group started from above		
//		GUI.EndGroup ();
	}
}
