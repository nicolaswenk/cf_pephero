using UnityEngine;
using System.Collections;

public class scriptPlayerNEW : MonoBehaviour {


	void Start () {
		Invoke("finish",64);
	}

	void Update () {
	if (s_input.f_pressure > 0.107f){
			Vector3 newPlayerPosition = transform.position;
			newPlayerPosition = new Vector3(transform.position.x, s_input.f_pressure * 5f, transform.position.z);		//sets horizontal and vertical limit
			transform.position = newPlayerPosition;
		}
		if (s_input.f_pressure <= 0.107f){
			Vector3 newPlayerPosition = transform.position;
			newPlayerPosition = new Vector3(transform.position.x, 0f, transform.position.z);		//sets horizontal and vertical limit
			transform.position = newPlayerPosition;
		}

	}
	void finish (){
		Application.LoadLevel("EndSceneNav");
		print("FINISHED");
	}
}
