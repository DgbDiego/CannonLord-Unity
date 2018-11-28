using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

/*
Códigos produzidos por Diego Gomes Barbosa
dgb.diego@gmail.com
https://diego-gomes.itch.io
https://github.com/DgbDiego/
 */

public class gameManager : MonoBehaviour {

	public string timeCounter;
	public Text inGameMarker;
	public Text gameOverMarker;

	public TimeSpan tspActual;
	public Stopwatch stp;

	public GameObject gameOverLayer;

	

	// Use this for initialization
	void Start () {

		stp = new Stopwatch();
		stp.Start();
		
	}
	
	// Update is called once per frame
	void Update () {

		tspActual = stp.Elapsed;

		timeCounter = tspActual.ToString();
		if (timeCounter.Length > 8){
			timeCounter = timeCounter.Remove (8, timeCounter.Length - 8);
		}

		inGameMarker.text = "LIFETIME: " + timeCounter;
		gameOverMarker.text = "TOTAL TIME: " + timeCounter;
		
	}

	public void gameOverState(){

		stp.Stop();

		gameOverLayer.SetActive(true);
		Time.timeScale = 0f;

	}

}
