using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] enemies;

	public GameObject target;
	Vector3 point;
	public bool positive;
	public float movementRange;
	public float speedMovement;

	float intTimer;
	public float spawnFreq;

	// Use this for initialization
	void Start () {

		intTimer = Time.time + spawnFreq;
		point = target.transform.position;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		movement();

		if (intTimer < Time.time){
			intTimer = Time.time + spawnFreq;
			newEnemy();
		}
		
	}

	public void newEnemy(){

		GameObject newEnemy = Instantiate(enemies[Random.Range(0,enemies.Length)], transform.position, transform.rotation) as GameObject;
	}

	public void movement(){	

		if (positive){
			point.x += movementRange * (speedMovement / 10f);
		} else {
			point.x -= movementRange * (speedMovement / 10f);
		}
	
		if (point.x < -movementRange){
			positive = true;			
		} else if (point.x > movementRange){
			positive = false;
		}

		target.transform.position = point;

	}
}
