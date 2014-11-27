// Shield script

using UnityEngine;
using System.Collections;

public class scriptShield : MonoBehaviour {
	
	// Inspector variables
	public int shieldHealth = 3;
	public Transform explosion;
	public Transform player;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (shieldHealth <= 0)
		{
			Destroy (gameObject);
		}
	}
	
	void OnTriggerEnter (Collider other)
	{
		GameObject GO = other.gameObject;
		// Check for asteroid
		if (GO.tag == ("asteroid"))
		{
			ReduceShieldHealth (1);
		}
	}
	
	void ReduceShieldHealth (int damagePoints)
	{
		shieldHealth -= damagePoints;
		print ("Shield health " + shieldHealth);
	}
}
