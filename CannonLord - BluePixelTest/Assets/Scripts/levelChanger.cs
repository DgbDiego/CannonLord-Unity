using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Códigos produzidos por Diego Gomes Barbosa
dgb.diego@gmail.com
https://diego-gomes.itch.io
https://github.com/DgbDiego/
 */
 
public class levelChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeLevel (int scene){
		Time.timeScale = 1f;
		SceneManager.LoadScene(scene);

	}

	public void exitGame(){

		Application.Quit();

	}
}
