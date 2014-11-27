// Credits script

using UnityEngine;
using System.Collections;

public class scriptScreenCredit : MonoBehaviour {
	
	// Inspector variables
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI ()
	{
		// Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 - 110,Screen.height / 2 - 110,220,220));
		
		//Make a box to see the group on screen
		GUI.Box (new Rect(0,0,200,200),"Credits");
		
		// Instructions for the player
		GUI.Label (new Rect(20,40,200,50),		"Designer : 		David Duguay");
		GUI.Label (new Rect(20,65,200,50),		"Artist : 			David Duguay");
		GUI.Label (new Rect(20,90,200,50),		"Software : 		David Duguay");
		GUI.Label (new Rect(20,115,200,50),	"Level Designer : 	NOBODY");
		
		if (GUI.Button(new Rect(60,160,80,30),"Back"))
		{
			Application.LoadLevel("ScreenMainMenu");		// Take us back to the start
		}
		
		// End the group started from above
		GUI.EndGroup ();
	}
}
