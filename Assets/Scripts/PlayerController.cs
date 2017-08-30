using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float horizontalSpeed;
	public float boundary;
	private bool isBlue;
	private Renderer playerRenderer;
	public Material redMaterial;
	public Material blueMaterial;
	private TrailRenderer trail;
	public Material redTrail;
	public Material blueTrail;

	void Start() {
		rb = GetComponent<Rigidbody>();
		playerRenderer = GetComponent<Renderer>();
		playerRenderer.material = redMaterial;
		trail = GetComponent<TrailRenderer>();
	}
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float accel = Input.acceleration.x;
		Vector3 movement;
		
		if (accel != 0)
			movement = new Vector3 (Input.acceleration.x*horizontalSpeed, rb.velocity.y, 0.0f);
		else
			movement = new Vector3 (moveHorizontal*horizontalSpeed, rb.velocity.y, 0.0f);
		rb.velocity = movement;

		rb.position = new Vector3 (
			Mathf.Clamp(rb.position.x, -boundary, boundary), rb.position.y, 0.0f
		);
	}

	void Update() {
		isBlue = FindObjectOfType<GameController>().isBlue;
		if (!isBlue) {
			playerRenderer.material = blueMaterial;
			trail.material = blueTrail;
		} else {
			playerRenderer.material = redMaterial;
			trail.material = redTrail;
		}
	}

	void OnCollisionEnter(Collision other) {
		GetComponent<AudioSource> ().Play ();
	}
}
