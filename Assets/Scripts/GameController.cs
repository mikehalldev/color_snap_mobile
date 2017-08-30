using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public bool isBlue;

	public Text distanceText;

	public Text gameOverText;

	private Transform playerTransform;

	private int score;

	private AudioSource music;

	private AudioSource snap;

	void Start () {
		isBlue = true;
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		distanceText.text = "";
		gameOverText.text = "";

		AudioSource[] audioSources = GetComponents<AudioSource>();
		music = audioSources[0];
		snap = audioSources[1];
	}
	
	void Update () {
		if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || (Input.GetButtonDown("Jump"))) {
			isBlue = !isBlue;
			snap.Play();
		}
		if (playerTransform != null) {
			score = (int)playerTransform.position.y;
			distanceText.text = "Score:  " + -score;
		} else {
			music.Stop();
			gameOverText.text = "Game Over!\nScore:  " + -score + "\nTap to Restart";
			if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || (Input.GetButton("Submit"))) {
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
		
	}
}
