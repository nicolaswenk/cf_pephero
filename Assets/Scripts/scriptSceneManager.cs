// Scene manage script

using UnityEngine;
using System.Collections;

public class scriptSceneManager : MonoBehaviour {
	
// Inspector variables
	public float gameTime = 60.0f;
	//public float labelRight = 100.0f;
	public AudioClip fxSound;
	public GameObject katana;
	public GameObject serenity;
	public int numberOfShields			= 4;		// number of shields player gets to use each game
	public int katanaLives 				= 3;		// number of lives for Katana ship
	public int serenityLives		 	= 5;		// number of lives for Serenity ship
	public Transform smallAsteroidScore;
	public Transform bigAsteroidScore;
	
// Private variables
	private static scriptSceneManager _instance;	// transform to class and become unique (script must be only exist at one place = be unique) --> Used for SINGLETON
	private int score = 0;
	private int lives = 3;
	
	
// Use this for initialization
	void Start () {
		_instance = this;												// Script creates a reference to itself so it is accessible from any other script --> Used for SINGLETON
		
		InvokeRepeating ("CountDown",1.0f,1.0f);						// Starts countdown timer when the game starts
		
		// Change ship settings based on the one chosen by the player in the Main Menu
		if(PlayerPrefs.GetInt("ship") == 0)								// 0 = Player chose Katana
		{
			print ("Player chose " + PlayerPrefs.GetInt("ship2"));
			serenity.SetActiveRecursively(false);
			katana.SetActiveRecursively(true);
			lives = katanaLives;
		}
		if(PlayerPrefs.GetInt("ship") == 1)								// 1 = Player chose Serenity
		{
			print ("Player chose " + PlayerPrefs.GetInt("ship2"));
			katana.SetActiveRecursively(false);
			serenity.SetActiveRecursively(true);
			lives = serenityLives;
		}
	}
	
// Update is called once per frame
	void Update () {
		
		// Happens when health reaches 0
		if (lives <= 0)
		{
			PlayerPrefs.SetInt("SCORE",score);							// Saves game score
			Application.LoadLevel ("ScreenLose");						// Loads LOSE screen
		}
		
		// Happens when counter reaches 0
		if (gameTime <= 0)
		{
			PlayerPrefs.SetInt("SCORE",score);							// Saves game score
			Application.LoadLevel ("ScreenWin");						// Loads WIN screen
		}
	}
	
// Can be colled by other scripts to access information for this unique instance ***SHOULD NOT BE CALLED INTO ANY OTHER "START" FUNCTION*** --> Used for SINGLETON
	public static scriptSceneManager GetSceneInstance ()
	{
		return _instance;	// gives access to this unique instance for this script from anywhere else
	}
	
// Adds score each time an asteroid is destroyed
	public void AddScore (int numberOfAddedPoints)
	{
		score += numberOfAddedPoints;
	}
	
// Removes player shield when shield is activated
	public void RemoveShield (int numberOfRemovedShields)
	{
		numberOfShields -= numberOfRemovedShields;
		//print ("used shield");
	}

// Removes player live when hit by an asteroid
	public void RemoveLife (int numberOfRemovedLives)
	{
		lives -= numberOfRemovedLives;
		//print ("got hit");
	}
	
// Gives player a life if he gets a pickupLife
	public void AddLife (int numberOfAddedLives)
	{
		lives += numberOfAddedLives;
		//print ("got hit");
	}
	
// Popup score when asteroid is destroyed
	public void ShowAsteroidScore (bool smallAsteroid, Vector3 asteroidPosition, Quaternion asteroidRotation)
	{
		print (smallAsteroid);
		if(smallAsteroid)
			{Instantiate (smallAsteroidScore,asteroidPosition,asteroidRotation);}	// Creates small POINTS instance at destroyed asteroid position
			//print ("+1");
		if(!smallAsteroid)
			{Instantiate (bigAsteroidScore,asteroidPosition,asteroidRotation);}		// Creates big POINTS instance at destroyed asteroid position
			//print ("+2");
	}
	
//	Timer that counts down to 0
	void CountDown ()
	{
		if (--gameTime == 0)
		{
			CancelInvoke ("CountDown");
		}
		
	}
	
// User Interface
	void OnGUI ()
	{
		GUI.Label(new Rect(10,10,100,20), "Score " + score);
		GUI.Label(new Rect(10,25,100,20), "Lives " + lives);
		GUI.Label(new Rect(10,40,100,20), "Shields " + numberOfShields);
		GUI.Label(new Rect (Screen.width - 75,10,100,20), "Counter " + gameTime); 
	}
}
