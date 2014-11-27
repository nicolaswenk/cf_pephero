 #pragma strict
var moveVect = new Vector2(0,0);
function Start () {

}

function Update () {
	moveMe();
}

public function getVect(Vect:Vector2){
	moveVect = Vect;	
}

function moveMe(){
	transform.position+=moveVect;
}