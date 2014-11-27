using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Waves : MonoBehaviour {

	// Use this for initialization
	bool breathing;
	Vector2 StartPos;
	GameObject playr;
	public GameObject enemy;

	GameObject wall;
	bool waveStart;
	public bool waveComplete;
	int vertDispersion = 5;

	public int WaveType = 0;
	public int waveNum = 0;
	public const int HIGH = 15;
	public const int LOW = 5;
	public int BlowStrength;
	public const int NONE = 0;
	public List<GameObject> enemyList = new List<GameObject>();




	void Start () {
		StartPos.x = gameObject.transform.position.x;
		StartPos.y = gameObject.transform.position.y;
		playr = GameObject.Find ("Player");	
		wall = GameObject.Find ("wall");
		waveStart = false;
		waveComplete = false;
		startMe ();
	}
	
	// Update is called once per frame
	void Update () {

		checkWaveState ();
		if (waveComplete) {		
			if (waveNum<15){
				waveComplete = false;
				WaveType = 0;
				Invoke ("buildWave",3);
				waveNum++;
			}else{
				//RUN COMPLETED
			}
		}

	}
	public void startMe(){
		Invoke ("buildWave", 3);
	}
	
	void buildWave(){
		int waveCount = Random.Range (2, 4);
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
		WaveType = 1;
		int rand = Random.Range (0, 1);
		if (rand < .55) {

		} else {

		}
	}
	void waveTwo(){
	
		EnemyControl enemyScript;
		int enemyMax = Random.Range (8, 10);
		Vector2 newPos = new Vector2 (0, 0);
		vertDispersion = 5;

		for (int i = 0; i < enemyMax; i++) {
			GameObject newGuy;
			newGuy = Instantiate(enemy) as GameObject;
			enemyScript = newGuy.GetComponent<EnemyControl>();
			enemyScript.getPos (StartPos);
			newGuy.gameObject.transform.position = randPosition(); 

		}
		waveStart = true;
		WaveType = 2;
	}

	void waveThree(){

		EnemyControl enemyScript;
		int enemyMax = Random.Range (7, 9);
		Vector2 newPos = new Vector2 (0, 0);
		vertDispersion = 3;
		for (int i = 0; i < enemyMax; i++) {
			GameObject newGuy;
			newGuy = Instantiate(enemy) as GameObject;
			enemyScript = newGuy.GetComponent<EnemyControl>();
			enemyScript.getPos (StartPos);
			newGuy.gameObject.transform.position = randPosition(); 
			
		}
		waveStart = true;
		WaveType = 3;	
	}
	void waveFour(){
		WaveType = 4;
	}
	void waveFive(){
	}
	Vector2 randPosition(){
		Vector2 newPos = new Vector2(0,0);
		newPos.x = StartPos.x - Random.Range (-5,5);
		newPos.y = StartPos.y - Random.Range (-vertDispersion ,vertDispersion);
		return newPos;
	}
	bool OnTriggerEnter2D(Collider2D other){
		
		return true;
	}
	void hiWall(){
		GameObject newGuy;
		newGuy = Instantiate(wall) as GameObject;
		//newGuy.gameObject.transform.position.y = 20;

	}

	void loWall(){
	
	}
	public void killObject(GameObject enem){
		Destroy (enem);
	}
	void checkWaveState(){
		switch (WaveType) {
		case 1:
			break;
		case 2:
			if (enemyList.Count==0&&waveStart){
				waveComplete = true;
				waveStart = false;
			}
			break;
		case 3:
			if (enemyList.Count==0&&waveStart){
				waveComplete = true;
				waveStart = false;
			}
			break;
		case 4:
			break;
		case 5:
			break;
			
		}
	}

}
