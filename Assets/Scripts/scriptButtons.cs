using UnityEngine;
using System.Collections;

public class scriptButtons : MonoBehaviour {

	public Material defaultMat;
	public Material mouseOverMat;
	public Material mouseDownMat;
	public string loadNextScene;
	public bool webLink = false;
	public bool quitButton = false;
	public string webPage;

	//public bool startCalib = false;

	private int matState; //0 = default, 1 = over, 2 = down
	//private bool buttonClicked = false;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (matState == 0)
			gameObject.renderer.material = defaultMat;
		if (matState == 1)
			gameObject.renderer.material = mouseOverMat;
		if (matState == 2)
			gameObject.renderer.material = mouseDownMat;
		}

	void OnMouseExit () {
		matState = 0;
	}

	void OnMouseOver () {
		matState = 1;
	}


	void OnMouseDown () {
		if (!webLink && !quitButton){
			gameObject.renderer.material = mouseDownMat;	//Material not showing up!
			Application.LoadLevel (loadNextScene);
			print("clicked");
			print(loadNextScene);
		}
		if (webLink && !quitButton)
			Application.OpenURL (webPage);

		if (!webLink && quitButton)
			Application.Quit ();
	}

}
