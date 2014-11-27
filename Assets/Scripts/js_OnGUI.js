#pragma strict

function Start () {

}

function Update () {

}

function OnGUI(){
	GUI.backgroundColor = Color.blue;
	GUI.Button (Rect (10, 10, 100, 30), "Lives: ");
	GUI.Button (Rect (130, 10, 100, 30), "Waves: ");
	GUI.Button (Rect (250, 10, 100, 30), "Scores: ");
}