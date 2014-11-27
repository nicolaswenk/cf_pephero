using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Waves : MonoBehaviour {

	// Use this for initialization
	bool breathing;
	Vector2 StartPos;
	GameObject playr;
	GameObject enemy;

	public int WaveType;
	public const int HIGH = 15;
	public const int LOW = 5;
	public int BlowStrength;
	public const int NONE = 0;
	public static List<GameObject> enemyList = new List<GameObject>();




	void Start () {
		StartPos.x = gameObject.transform.position.x;
		StartPos.y = gameObject.transform.position.y;
		WaveType = Random.Range (0, 4);
		playr = GameObject.Find ("Player");
		enemy = GameObject.Find ("enemy");
		enemyList.Add (GameObject.Find ("enemy1"));
		enemyList.Add (GameObject.Find ("enemy0"));
		enemyList.Add (GameObject.Find ("enemy"));
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}


	void buildWave(int waveCount){
		switch (waveCount) {
		case 0:
			breakWave();
			break;
		case 1:
			waveOne();
			break;
		case 2:
			waveTwo ();
			break;
		case 3:
			waveThree();
			break;
		case 4:
			waveFour();
			break;
		case 5:
			waveFive();
			break;
		}	
	}
	void breakWave(){
	}
	void waveOne(){
		int rand = Random.Range (0, 1);
		if (rand < .55) {

		} else {

		}
	}
	void waveTwo(){
		EnemyControl enemyScript;
		int enemyMax = Random.Range (8, 10);
		Vector2 newPos = new Vector2 (0, 0);
		for (int i = 0; i < enemyMax; i++) {
			GameObject newGuy;
			newGuy = Instantiate(enemy) as GameObject;
			enemyScript = newGuy.GetComponent<EnemyControl>();
			enemyScript.getPos (StartPos);
			newGuy.gameObject.transform.position = randPosition(); 
			enemyList.Add (enemy);
		}
	}
	void waveThree(){
	}
	void waveFour(){

	}
	void waveFive(){
	}
	Vector2 randPosition(){
		Vector2 newPos = new Vector2(0,0);
		newPos.x = StartPos.x - Random.Range (-5,5);
		newPos.y = StartPos.y - Random.Range (-5,5);
		return newPos;
	}
	bool OnTriggerEnter2D(Collider2D other){
		
		return true;
	}
	void hiWall(){
		GameObject newGuy;

	}

	void loWall(){
	
	}


}
