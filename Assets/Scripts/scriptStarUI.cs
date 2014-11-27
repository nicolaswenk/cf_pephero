using UnityEngine;
using System.Collections;

public class scriptStarUI : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

/*		readSerialPort sp = readSerialPort.GetSceneInstance ();
		pressurePosition = sp.pressure;
		pressureFixed = sp.normalPressure;
		print ("pressureFixed");
*/		if (s_input.f_pressure > 0.107f){
			Vector3 newPlayerPosition = transform.position;
			newPlayerPosition = new Vector3(transform.position.x, s_input.f_pressure + 30, transform.position.z);		//sets horizontal and vertical limit
			transform.position = newPlayerPosition;
		}
		if (s_input.f_pressure <= 0.107f){
			Vector3 newPlayerPosition = transform.position;
			newPlayerPosition = new Vector3(transform.position.x, 0f, transform.position.z);		//sets horizontal and vertical limit
			transform.position = newPlayerPosition;
		}
	}
}
