#pragma strict

var oxygen: int;

function OnGUI(){
	guiText.text = "Player 1 score: " + oxygen;
	guiText.transform.position = new Vector3(0.11, 0.62, 6);
}