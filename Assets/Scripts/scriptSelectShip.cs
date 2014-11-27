using UnityEngine;
using System.Collections;

public class scriptSelectShip : MonoBehaviour {

	// Inspector variables
	public bool katana = true;
	public bool serenity = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (katana)
		{PlayerPrefs.SetInt("ship",0);
		}
		if (serenity)
		{PlayerPrefs.SetInt("ship",1);
		}
	}

	void OnGUI (){
		if(serenity = !GUI.Toggle (new Rect(Screen.width / 4, Screen.height / 4 * 3 , 100, 30),katana,""))		// Creates button to choose Katana ship
		{serenity = !katana;}																							// Deselects Serenity when Katana selected
		if(katana = !GUI.Toggle (new Rect(Screen.width / 4 * 3, Screen.height / 4 * 3 , 100, 30),serenity,""))		// Creates button to choose Serenity ship
		{katana = !serenity;}
	}
}
