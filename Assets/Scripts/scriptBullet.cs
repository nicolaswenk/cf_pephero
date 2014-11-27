// Bullet script

using UnityEngine;
using System.Collections;

public class scriptBullet : MonoBehaviour {
	
	// Inspector variables
		public float bulletSpeed = 15.0f;			// Speed of the bullet
		public float bulletHeightLimit = 10.0f;		// The range the bullet can travel
		public Transform explosion;
		public AudioClip fxSound;					// Loads audio file
		public int katanaPower = 2;					// Sets katana power towards asteroids
		public int serenityPower = 1;				// Sets Serenity power towards asteroids
		public Transform smallAsteroidScore;
		public Transform bigAsteroidScore;
		
	// Private variables
		public Vector3 scoreOffset;
	
	// Use this for initialization
	void Start () {
		GameObject.Find ("prefab Bullet");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,bulletSpeed * Time.deltaTime,0);
		
		if (transform.position.y >= bulletHeightLimit)
		{
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		// Check for asteroid
		GameObject GO = other.gameObject;
		if (GO.tag == ("asteroid"))
		{
			scriptSceneManager sm = scriptSceneManager.GetSceneInstance ();
			scriptAsteroid sp = GO.GetComponent<scriptAsteroid>();
			
			// Reduce Asteroid health when hit by a Bullet
			if(PlayerPrefs.GetInt("ship") == 0)		// 0 = player chose Katana ship
				{sp.reduceAsteroidHealth(katanaPower);}		// asteroid loses 1 health
			if(PlayerPrefs.GetInt("ship") == 1)		// 1 = player chose Serenity ship
				{sp.reduceAsteroidHealth(serenityPower);}		// asteroid loses 2 health
			
			// Give a point to the player
			if (sp.smallAsteroid && sp.asteroidHealth <= 0)
			{
				sm.AddScore (sp.smallAsteroidValue);
			}
			
			if (!sp.smallAsteroid && sp.asteroidHealth <= 0)
			{
				sm.AddScore (sp.bigAsteroidValue);
			}
			
			// Explosion if asteroid is destroyed
			if (explosion && sp.asteroidHealth <=0)
			{
				Instantiate(explosion,transform.position,transform.rotation);
				//Instantiate (smallAsteroidScore,transform.position,transform.rotation);
				AudioSource.PlayClipAtPoint (fxSound, transform.position);
				if(sp.smallAsteroid)
					{Instantiate (smallAsteroidScore,transform.position + scoreOffset,transform.rotation);}
					//{sm.ShowAsteroidScore (true,sp.transform.position,sp.transform.rotation);}
				if(!sp.smallAsteroid)
					{Instantiate (bigAsteroidScore,transform.position + scoreOffset,transform.rotation);}
					//{sm.ShowAsteroidScore (false,sp.transform.position,sp.transform.rotation);}
					//print (sp.smallAsteroid);
				sp.ResetEnemy ();
			}
			
			// Gets rid of the bullet
			Destroy (gameObject);		// Removes bullet from scene
		}
	}
}
