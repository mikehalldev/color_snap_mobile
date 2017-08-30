using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float boundary;

	public float speed;

	private bool dirRight;

	void Start () {
		if (Random.value >= 5)
			dirRight = true;
		else
			dirRight = false;
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
