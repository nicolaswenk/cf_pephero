using UnityEngine;
using System.Collections;

public class scriptScreenLoad : MonoBehaviour {
	
	// Inspector variables
	public float waitTime = 3.0f;
	
	// Use this for initialization
	void Start () {
//		PlayerPrefs.SetInt("ship2",PlayerPrefs.GetInt("ship"));
//		print ("player choice" + PlayerPrefs.GetInt("ship2"));
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Timer for waiting
		if(Input.GetKeyDown("space"))
		{
			Application.LoadLevel ("Level_01");		// Start game
		}
		else
		{
			StartCoroutine(WaitTime());
		}
	}
	
	void OnGUI ()
	{
	// Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 - 100, Screen.height / 4 -100, 200, 120));
		
		//Make a box to see the group on screen
		GUI.Box (new Rect(0,0,200,120),"Controls");
		
		// Instructions for the player
		GUI.Label (new Rect(40,30,140,40),"Move		ARROWS");
		GUI.Label (new Rect(40,50,160,70),"Shoot	SPACE BAR");
		GUI.Label (new Rect(40,70,160,70),"Shield	E");
		GUI.Label (new Rect(40,90,160,70),"Quit		ESC");
		
		// End the group started from above
		GUI.EndGroup ();
		
	// Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 - 150, Screen.height / 4+50, 300, 400));
		
		//Make a box to see the group on screen
		GUI.Box (new Rect(0,0,300,400),"Points");
		
		// Instructions for the player
		GUI.Label (new Rect(190,90,140,40),"+1 PTS");
		GUI.Label (new Rect(190,250,160,70),"+2 PTS");
		
		// End the group started from above
		GUI.EndGroup ();
	}
	
	IEnumerator WaitTime ()
	{
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("Level_01");
	}
}
