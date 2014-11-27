#pragma strict

//global var
static var playerDamage = 0;

//states
var waveActive: boolean = false;
var spawnEnemies: boolean = false;

//player var
var healthCount: int = 10;
var scoreCount: int = 0;

//GUI
static var lives: int = 3;
static var waves: int = 0;
static var scores: int = 0;

//wave specific var
var waveLevel: int = 0;
var difficultyMultiplier: float = 1.0;
var waveLength: float = 30.0;
var intermissionTime: float = 5.0;
private var waveEndTime: float = 0;

// enemy var
var mucusPrefab: GameObject[];
var mucusSpawns: Transform;
var mucusInterval: float = 1.0;
var enemyCount: int = 0;
var respawnMinBase: float = 3.0;
var respawnMaxBase: float = 10.0;
private var respawnMin: float = 3.0;
private var respawnMax: float = 10.0;
private var mucusSpawnPoints: Transform[];
private var lastSpawnTime: float = 0;

private var nextMucusSpawnTime: float = 0.0;

function Start () {
	mucusSpawnPoints = new Transform[mucusSpawns.childCount];
	var i: int = 0;
	for(var theSpawnPoint: Transform in mucusSpawns){
		mucusSpawnPoints[i] = theSpawnPoint;
		i++;
	}
	
	SetNextWave();
	StartNewWave();
}

function Update () {
	if(waveActive){
		if(Time.time >= waveEndTime){
			spawnEnemies = false;
			if(enemyCount == 0){
				FinishWave();
			}
		}
		
		if(spawnEnemies){
			if(Time.time > (lastSpawnTime + mucusInterval)){
				SpawnNewEnemy();
			}
		}
	}
}

function SetNextWave(){
	waveLevel++;
	difficultyMultiplier = ((Mathf.Pow(waveLevel, 2)) * .005) + 1;
	respawnMin = respawnMinBase * (1/difficultyMultiplier);
	respawnMax = respawnMaxBase * (1/difficultyMultiplier);
}

function StartNewWave(){
//	OnGUI();
	
	//spawn first enemy
	SpawnNewEnemy();
	
	//set the wave and time
	waveEndTime = Time.time + waveLength;
	
	//active the wave
	waveActive = true;
	spawnEnemies = true;
}

function SpawnNewEnemy(){
	
	
	//get a random index to choise an enemy prefab with
	var enemyChoice = Random.Range(0, mucusPrefab.length);
	
	var spawnChoice: int;
	if(mucusPrefab[enemyChoice].tag == "Enemy"){
		spawnChoice = Random.Range(0, mucusSpawnPoints.Length);
		Instantiate(mucusPrefab[enemyChoice], mucusSpawnPoints[spawnChoice].position, mucusSpawnPoints[spawnChoice].rotation);
	}
	// else - for another type of enemies that appear elsewhere
	
	enemyCount++;
	lastSpawnTime = Time.time;
	mucusInterval = Random.Range(respawnMin, respawnMax);

}

function FinishWave(){
	waveActive = false;
	yield WaitForSeconds(intermissionTime);
	
	SetNextWave();
	StartNewWave();
}

function OnGUI(){
	GUI.backgroundColor = Color.blue;
	GUI.Button (Rect (10, 10, 100, 30), "Lives: " + lives);
	GUI.Button (Rect (130, 10, 100, 30), "Waves: " + waves);
	GUI.Button (Rect (250, 10, 100, 30), "Scores: " + scores);
}

/*
function SpawnMucus(){
	nextMucusSpawnTime += mucusInterval;
	var i: int = Random.Range(0, mucusSpawnPoints.length);
	var newMucus: GameObject = Instantiate(mucusPrefab[0], mucusSpawnPoints[i].position, mucusSpawnPoints[i].rotation);
}
*/