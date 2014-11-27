#pragma strict

var ship: int;

function Start () {

}

function Update (){
	if (ship){
		PlayerPrefs.SetInt("ship",0);
	}
	if (ship){
		PlayerPrefs.SetInt("ship",1);
	}
}