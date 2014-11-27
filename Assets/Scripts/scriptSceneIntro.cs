using UnityEngine;
using System.Collections;

public class scriptSceneIntro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI ()
	{
		GUI.Box (new Rect(Screen.width / 2 - 50,Screen.height / 2 - 30,100,25),"PEP HERO!");

		if (GUI.Button(new Rect(Screen.width / 4 *3 + 50,Screen.height / 4 *3 + 80,80,30),"Next"))				// Creates button to Start Game
		{
			Application.LoadLevel ("ScreenMainMenu");
		}

		//GUI.Box (new Rect(0,0,100,30),"Main Menu");

		// Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100,175));
		
		//Make a box to see the group on screen

		//GUI.Box (new Rect(0,0,100,175),"Enter here some PEP explanations on how cool it is to use a game for cystic fibrosis kids.");

		
		// Add buttons for game navigation

		
		// End the group started from above		
		GUI.EndGroup ();
		
//		// Make a group on the left of the screen for KATANA
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
//		// Make a group on the right of the screen for SERENITY
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
