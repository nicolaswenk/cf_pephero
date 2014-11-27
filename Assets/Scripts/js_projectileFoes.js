
var bulletSpeed: float = 15.0;
var timeDelay: float = 10.0;

function Update () {
	transform.Translate(bulletSpeed * Time.deltaTime,0,0);
	
	if(timeDelay > 0){
		timeDelay--;
	}
	
	if(timeDelay <= 0){
		Destroy(gameObject);
	}
}

function OnTriggerEnter2D(other: Collider2D){
	if(other.gameObject.tag == "Foes"){
		Destroy(this.gameObject);
	}
}