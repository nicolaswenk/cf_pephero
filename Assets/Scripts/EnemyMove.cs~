using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float enemySpeed = -10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(enemySpeed * Time.deltaTime,0,0);
		//this.rigidbody2D.velocity  = transform.right * enemySpeed;
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "shield") {
			Destroy(gameObject);
//			print("DESTROY");
		}
//		if (col.gameObject.tag == "Enemy") {
//			Destroy(gameObject);
//		}
	}
}
