using UnityEngine;
using System.Collections;

public class scriptCalib : MonoBehaviour {

	public float waitCalibTime = 3.0f;
	public float normalPressure;
	public float maxBlowPressure;

	private bool inCalib = false;
	private bool calibRunning;
	private float averagePressure;
	private float tempMinPressure;
	private float tempMaxPressure;
	private float minPressure;
	private float maxPressure;
	private int calibState = 0;	//0 = start calibration, 1 = wait for calibration, 2 = mid calibration, 3 = blow as hard as possible, 4 = calibration over
	//private float

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//readSerialPort ps = GetComponent<readSerialPort>();
		//print (ps.pressure);
	}

	void OnGUI ()
	{
		if (!inCalib && GUI.Button(new Rect(Screen.width / 2 - 50,Screen.height / 2 - 30,80,30),"Calibrate"))				// Creates button to Start Game
		{
			inCalib = true;
		}

		if (inCalib){
			GUI.Box (new Rect(Screen.width / 2 - 100,Screen.height / 2 - 30,200,25),"STEP 1 : Do not blow for 3 sec");
			if (calibState == 0) {
				Invoke("calibMid", 3);
				calibState = 1;
			}
			if (calibState == 1) {
//				readSerialPort ps = GetComponent<readSerialPort>();
				//print (ps.pressure);
//				tempMinPressure = ps.pressure;
				tempMinPressure = s_input.f_pressure; // ONATHA
				//print("calibrating");
			}
			if (calibState == 2) {
				//print("calibrating");
			}

			//StartCoroutine(WaitCalib());
		}

		if (!inCalib && GUI.Button(new Rect(Screen.width / 4 * 3 + 50,Screen.height / 4 * 3 + 80,80,30),"Next"))				// Creates button to Start Game
		{
			Application.LoadLevel ("ScreenMainMenu");
		}

	}

	void calibMid(){
		calibState = 2;
		//print ("calibration done");
	}
	void calibOver(){
		calibState = 4;
		//print ("calibration done");
	}

//	IEnumerator WaitCalib ()
//	{
//		yield return new WaitForSeconds (waitCalibTime);
//		//calibRunning = true;
//		while (calibRunning){
//
//		}
//
//	}

}
