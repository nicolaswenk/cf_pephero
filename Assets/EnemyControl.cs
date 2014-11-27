using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	// Use this for initialization
	Vector2 buildPos = new Vector2(0,0);
	Waves waveScript;
	GameObject waveController;
	void Start () {
		waveController = GameObject.Find ("waveSpawner");
		waveScript = waveController.GetComponent<Waves> ();
		waveScript.enemyList.Add (this.gameObject);
	}
	void Awake(){
	
	}
	
	// Update is called once per frame
	void Update() {
		moveMe ();
	}
	public void getPos(Vector2 startPos){
		buildPos = startPos;
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy") {
			randPosition();
		}
		if (col.gameObject.tag == "Player"||col.gameObject.tag == "Laser") {
			killMe();
		}
	}
	void moveMe() {
		if (gameObject.transform.position.x < -10) {
			killMe ();
		} else {
			rigidbody2D.velocity = transform.right *-2;
		}
	}
	public void killMe(){
		waveScript.enemyList.Remove (this.gameObject);
		waveScript.killObject (this.gameObject);
	}
	Vector2 randPosition(){
		Vector2 newPos = new Vector2(0,0);
		newPos.x = buildPos.x - Random.Range (-5,5);
		newPos.y = buildPos.y - Random.Range (-5,5);
		return newPos;
	}
}
