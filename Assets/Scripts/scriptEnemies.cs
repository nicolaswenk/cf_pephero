using UnityEngine;
using System.Collections;

public class scriptEnemies : MonoBehaviour {

	public AudioClip fxSound;
	public GameObject wave1;
	public GameObject wave2;

	private static scriptEnemies _instance;	// transform to class and become unique (script must be only exist at one place = be unique) --> Used for SINGLETON


	// Use this for initialization
	void Start () {
		_instance = this;												// Script creates a reference to itself so it is accessible from any other script --> Used for SINGLETON

		if(PlayerPrefs.GetInt("wave") == 0)								// 0 = Player chose Katana
		{
//			print ("Player chose " + PlayerPrefs.GetInt("wave1"));
			wave2.SetActiveRecursively(false);
			wave1.SetActiveRecursively(true);
		}
		if(PlayerPrefs.GetInt("wave") == 1)								// 1 = Player chose Serenity
		{
//			print ("Player chose " + PlayerPrefs.GetInt("wave2"));
			wave1.SetActiveRecursively(false);
			wave2.SetActiveRecursively(true);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static scriptEnemies GetSceneInstance ()
	{
		return _instance;	// gives access to this unique instance for this script from anywhere else
	}
}
