using UnityEngine;
using System.Collections;

public class scriptScoreText : MonoBehaviour {
	
	// Inspector variables
	public float showTime = 2.0f;
	
	// Use this for initialization
	void Start () {
		StartCoroutine("DestroyText");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Destroys text after X seconds
	IEnumerator DestroyText ()
	{
		yield return new WaitForSeconds (showTime);
		Destroy(gameObject);
	}
}
