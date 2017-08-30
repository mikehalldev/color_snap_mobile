using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float boundary;

	public float speed;

	private bool dirRight;

	void Start () {
		dirRight = true;
	}
	
	void Update() {
		if (transform.position.x >= boundary) {
			dirRight = false;
		}
		if (transform.position.x <= -boundary) {
			dirRight = true;
		}
		

		if (dirRight)
			transform.Translate (Vector3.right * Time.deltaTime * speed);
		else
			transform.Translate (-Vector3.right * Time.deltaTime * speed);
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Red" || other.tag == "Blue") {
			dirRight = !dirRight;
		}
	}
}
