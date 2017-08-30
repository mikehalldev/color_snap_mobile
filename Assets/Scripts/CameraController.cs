using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	private GameObject player;
	private float playerY;
	public float offset;
	
	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	void Update() {
		if (player != null) {
			playerY = player.transform.position.y;
			transform.position = new Vector3 (transform.position.x, playerY + offset, transform.position.z);
		} else {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
