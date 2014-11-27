using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	// Use this for initialization
	Vector2 buildPos = new Vector2(0,0);

	void Start () {

	}
	void Awake(){
		this.tag = "Enemy";
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		moveMe ();
	}
	public void getPos(Vector2 startPos){
		buildPos = startPos;
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy") {
			randPosition();
		}
	}
	void moveMe() {
		if (gameObject.transform.position.x < 0) {
			Destroy (this);
		} else {
			rigidbody2D.velocity = transform.right *-2;
		}
	}
	Vector2 randPosition(){
		Vector2 newPos = new Vector2(0,0);
		newPos.x = buildPos.x - Random.Range (-5,5);
		newPos.y = buildPos.y - Random.Range (-5,5);
		return newPos;
	}
}
