// Lose script

using UnityEngine;
using System.Collections;

public class scriptScreenLose : MonoBehaviour {
	
	// Inspector variables
	public string loseQuote = "YOUR FINAL SCORE";
	public int lowScore = 20;
	public int mediumScore = 40;
	public int highScore = 70;
	public int veryHighScore = 100;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI ()
	{
		// Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 - 110,Screen.height / 2 - 50,240,150));
		
		//Make a box to see the group on screen
		GUI.Box (new Rect(0,0,240,150),loseQuote);		// Uses designer input	
		
		// Instructions for the player
		GUI.Label (new Rect(20,35,200,50), "You made: " + PlayerPrefs.GetInt("SCORE") + " points");
		
		// Gives some feedback to the player on his performance
		if(PlayerPrefs.GetInt("SCORE") < lowScore)
			{GUI.Label (new Rect(20,60,200,50), "A bit lousy ain't you...");}
		if(PlayerPrefs.GetInt("SCORE") >= lowScore && PlayerPrefs.GetInt("SCORE") < mediumScore)
			{GUI.Label (new Rect(20,60,200,50), "You can do better!");}
		if(PlayerPrefs.GetInt("SCORE") >= mediumScore && PlayerPrefs.GetInt("SCORE") < highScore)
			{GUI.Label (new Rect(20,60,200,50), "Just above my grandma!!");}
		if(PlayerPrefs.GetInt("SCORE") >= highScore && PlayerPrefs.GetInt("SCORE") < veryHighScore)
			{GUI.Label (new Rect(20,60,200,50), "Just above my grandpa!!!");}
		if(PlayerPrefs.GetInt("SCORE") >= veryHighScore)
			{GUI.Label (new Rect(20,60,200,50), "Only Chuck Norris can do better!!!!");}
		
		if (GUI.Button(new Rect(15,100,100,30),"Main Menu"))
		{
			Application.LoadLevel("ScreenMainMenu");		// Take us back to the start
		}
		if (GUI.Button(new Rect(125,100,100,30),"Restart"))
		{
			Application.LoadLevel("ScreenLoad");		// Take us back to the start
		}
		
		// End the group started from above
		GUI.EndGroup ();
	}
}
