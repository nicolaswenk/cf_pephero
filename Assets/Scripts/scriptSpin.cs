// Spin object script

using UnityEngine;
using System.Collections;

public class scriptSpin : MonoBehaviour {
	
	// Inspector variables
	public float rotateSpeed = 30.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,rotateSpeed * Time.deltaTime,0);
	}
}
