#pragma strict
#pragma strict

//Enemy script

//Inspector variables
var shapeColor		: Color[];			// color of the object
var numberOfClicks  : int 		= 2;	// how many times to click on an object before it get destroyed
var respawnWaitTime : float 	= 2.0;	// how long to hide
var explosion		: Transform;		// load particle effect
var enemyPoint		: int 		= 1;	// value of the enemy object

//Private variables
private var storeClicks : int = 0;

//Start is called just before any of the Update methods is called the first time
function Start ()
{
	storeClicks = numberOfClicks;
	var startPosition = Vector3(Random.Range(-4,4),Random.Range(-4,4),0);	// random position for the game object
	transform.position = startPosition;		// move the game object to new location
	RandomColor();
}

// Update is called every frame
function Update ()
{
	if (numberOfClicks <= 0)
	{
		if (explosion)
		{
			Instantiate (explosion, transform.position, transform.rotation);	// create an explosion
		}
		if(audio.clip)
		{
			audio.Play();
		}
		var position = Vector3(Random.Range(-4,4),Random.Range(-4,4),0);	// new random position for the game object
		RespawnWaitTime ();
		transform.position = position;		// move the game object to new location
		numberOfClicks = storeClicks;
	}
}
// RespawnWaitTime is used to hide a game object for a set amount of time and then unhide it
function RespawnWaitTime ()
{
	renderer.enabled = false;
	RandomColor();
	yield WaitForSeconds (respawnWaitTime);
	renderer.enabled = true;
}
// Random color is used to change the material of game object
function RandomColor ()
{
	if (shapeColor.length > 0)
	{
		var newColor = Random.Range(0, shapeColor.length);
		renderer.material.color = shapeColor[newColor];
	}
}