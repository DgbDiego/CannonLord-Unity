using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public GameObject target;
	public int attackAngle;

	
	public float speedMovement;
	public Vector3 point;
	public bool positive = true;

	void Start () {

		point = target.transform.localEulerAngles;
		
	}	
	// Update is called once per frame
	void FixedUpdate () {			

		movement();
		
	}
	
	public void movement(){	

		if (positive){
			point.z += attackAngle * (speedMovement / 10f);
		} else {
			point.z -= attackAngle * (speedMovement / 10f);
		}
	
		if (point.z < 90f -attackAngle){
			positive = true;			
		} else if (point.z > 90 + attackAngle){
			positive = false;
		}

		target.transform.localEulerAngles = point;

	}
}
