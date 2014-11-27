using UnityEngine;
using System.Collections;

public class scriptSelectWave : MonoBehaviour {

	// Inspector variables
	public bool wave1 = true;
	public bool wave2 = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (wave1)
		{PlayerPrefs.SetInt("wave",0);
		}
		if (wave2)
		{PlayerPrefs.SetInt("wave",1);
		}
	}
	
	void OnGUI (){
		if(wave2 = !GUI.Toggle (new Rect(Screen.width / 4, Screen.height / 4 * 3 , 100, 30),wave1,""))		// Creates button to choose wave1 ship
		{wave2 = !wave1;}																							// Deselects wave2 when wave1 selected
		if(wave1 = !GUI.Toggle (new Rect(Screen.width / 4 * 3, Screen.height / 4 * 3 , 100, 30),wave2,""))		// Creates button to choose wave2 ship
		{wave1 = !wave2;}
	}
}
