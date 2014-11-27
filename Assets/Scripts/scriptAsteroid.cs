// Asteroid script

using UnityEngine;
using System.Collections;

public class scriptAsteroid : MonoBehaviour {
	
	// Inspector variables
	public Transform explosion;
	public AudioClip shieldExplosion;
	public AudioClip playerExplosion;
	public float asteroidSpeed = 7.0f;
	public float asteroidSmallMinSpeed = 7.0f;
	public float asteroidSmallMaxSpeed = 9.0f;
	public float asteroidBigMinSpeed = 3f;
	public float asteroidBigMaxSpeed = 5f;
	public float asteroidMinSize = 2.0f;
	public float asteroidMaxSize = 4.0f;
	public int asteroidHealth = 1;
	public int asteroidSmallHealth = 2;
	public int asteroidBigHealth = 4;
	public int smallAsteroidValue = 1;
	public int bigAsteroidValue = 2;
	public bool smallAsteroid = true;
	
	
	// Private variables
	private float asteroidSize = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float newSpeed = asteroidSpeed * Time.deltaTime;
		transform.Translate (Vector3.forward * newSpeed);
		
		// Check for bottom of the screen
		if (transform.position.y <= -6)
		{
			ResetEnemy ();							// Resets position of asteroid
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		GameObject GO = other.gameObject;
		if (GO.tag == ("Player"))
		{
			// Tells sceneManager to remove life to player
			scriptSceneManager rl = scriptSceneManager.GetSceneInstance ();			// Using direct reference to scriptSceneManager SINGLETON
			rl.RemoveLife (1);														// Removes health to the ship
			
			// Using reference to GameObject variable -> HAVE TO BE ON EVERY ASTEROID TO WORK
//			scriptSceneManager rl = sceneManager.GetComponent<scriptSceneManager>();
//			rl.RemoveLife (1);
			
			if (explosion)
			{
				Instantiate (explosion, transform.position, transform.rotation);	// Creates an explosion
				audio.clip = playerExplosion;										// Fetches explosion sound
				audio.Play();														// Plays explosion sound
			}	
			ResetEnemy ();															// Resets position of asteroid
		}
		if (GO.tag == "shield")
		{
			if (explosion)
			{
				Instantiate (explosion, transform.position, transform.rotation);	// Creates an explosion
				audio.clip = shieldExplosion;										// Fetches explosion sound
				audio.Play();														// Plays explosion sound
			}
			ResetEnemy ();															// Resets position of asteroid
		}
	}
	
	public void ResetEnemy ()
	{
		// Resets position of asteroid
		Vector3 newAsteroidPosition = transform.position;
		newAsteroidPosition = new Vector3 (Random.Range(-7.0f, 7.0f), 8, transform.position.z);
		transform.position = newAsteroidPosition;
		
		
		// Sets random scale in a float value
		asteroidSize = Random.Range(asteroidMinSize,asteroidMaxSize);
		// Change scale to an integer value
		if (asteroidSize >= 3)
			{asteroidSize = 4;}
		else
			{asteroidSize = 2;}
		
		// Sets scale to asteroid
		transform.localScale = new Vector3 (asteroidSize,asteroidSize,asteroidSize);
		//print ("Asteroid size " + asteroidSize);
		
		
		// Affects small asteroids ONLY
		if (asteroidSize < 4)
		{
			asteroidHealth = asteroidSmallHealth;
			// Sets new random speed to asteroid
			asteroidSpeed = Random.Range(asteroidSmallMinSpeed,asteroidSmallMaxSpeed);		// Speed between
			smallAsteroid = true;
			//print ("Asteroid Health :" + asteroidHealth);
		}
		
		// Affects big asteroids ONLY
		else
		{
			asteroidHealth = asteroidBigHealth;
			// Sets new random speed to asteroid
			asteroidSpeed = Random.Range(asteroidBigMinSpeed,asteroidBigMaxSpeed);		// Speed between
			smallAsteroid = false;
			//print ("Asteroid Health :" + asteroidHealth);
		}
		//print ("Enemy reset");
	}
	
	// Removes health to hit asteroid
	public void reduceAsteroidHealth (int asteroidDamage)
	{
		asteroidHealth -= asteroidDamage;
	}
}