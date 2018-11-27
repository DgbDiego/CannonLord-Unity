using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour {

	public float speedForward;
	public float speedSideward;
	Vector3 direction;
	Vector3 point;
	public bool positive;


	// Use this for initialization
	void Start () {

		point = transform.position;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		movement();

	}

	public void movement(){	

		if (positive){
			point += new Vector3(speedSideward / 10f, speedForward / 10f, 0f );
		} else {
			point += new Vector3 ( - speedSideward / 10f, speedForward / 10f, 0f );
		}

		transform.position = point;

	}


private void OnTriggerEnter2D(Collider2D other) {

		Debug.Log ("colidiu");

		switch (other.gameObject.name){

			case "Left" :
				positive = true;
				break;
			case "Right" :
				positive = false;
				break;
			case "End" :
				Destroy(this.gameObject);
				break;
			default:
				break;

		}

		
	}
}
