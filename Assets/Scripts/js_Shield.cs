using UnityEngine;
using System.Collections;

public class js_Shield : MonoBehaviour {

	public GameObject shield;
	public GameObject waveSpawn;
	public float pressureFixed = 0.55f;
	public float pressureBuffer = 0.01f;
	public float pressureMultiplier = 2.0f;
	Waves waveScript;
	public float pressurePosit;

	void Start () {

		waveSpawn = GameObject.Find ("waveSpawner");
		waveScript = waveSpawn.GetComponent<Waves> ();
		shield = GameObject.FindWithTag("Shield");
		shield.SetActive(false);

	}

	void Update () {

		pressurePosit = s_input.f_pressure;
/*		readSerialPort sp = readSerialPort.GetSceneInstance ();
		pressureFixed = sp.normalPressure;
		pressurePosit = sp.pressure - pressureFixed;
*/		print("pressurePosit");

			if (pressurePosit<15&&pressurePosit>5){
				shield.SetActive(true);
			}
			else
				shield.SetActive(false);

	
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy"&&shield.activeSelf) {
			Destroy(col.gameObject);
		}
	}
}