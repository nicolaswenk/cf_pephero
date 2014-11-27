// Pickup life script

using UnityEngine;
using System.Collections;

public class scriptPickupLife : MonoBehaviour {
	
	// Inspector variables
	public float pickupSpeed = 7.0f;
	public float pickupMinHeight = 10;
	public float pickupMaxHeight = 20;
	
	// Private variables
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float newSpeed = pickupSpeed * Time.deltaTime;
		transform.Translate (Vector3.forward * newSpeed);
		
		// Check for bottom of the screen
		if (transform.position.y <= -6)
		{
			// Resets position of asteroid
			ResetPickup ();
		}
	}
	
	// Detects if player touched the pickup
	void OnTriggerEnter(Collider other)
	{
		GameObject GO = other.gameObject;
		if (GO.tag == ("Player"))
		{
			// Tells sceneManager to remove life to player
			
			// Using direct reference to scriptSceneManager SINGLETON
			scriptSceneManager rl = scriptSceneManager.GetSceneInstance ();
			rl.AddLife (1);					// Gives additionnal life to the player
			audio.Play();
			
			ResetPickup ();					// Resets position after player took it
		}
	}
	
	// Resets pickup position
	public void ResetPickup ()
	{
		// Resets position of asteroid
		Vector3 newPickupPosition = transform.position;
		newPickupPosition = new Vector3 (Random.Range(-7.0f, 7.0f), Random.Range(pickupMinHeight,pickupMaxHeight),transform.position.z);
		transform.position = newPickupPosition;
		
		//print ("Enemy reset");
	}
}