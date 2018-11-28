using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Códigos produzidos por Diego Gomes Barbosa
dgb.diego@gmail.com
https://diego-gomes.itch.io
https://github.com/DgbDiego/
 */
 
public class PlayerWeapon : MonoBehaviour {

	public ParticleSystem particles;
	public GameObject explosion;

	void OnParticleCollision(GameObject other) {

		GameObject exp = Instantiate (explosion, other.transform.position, other.transform.rotation) as GameObject;
		Destroy(other);
		Destroy(exp, 1.2f);		
		
	}

	public void shoot(){

		particles.Emit(1);
	}


}
