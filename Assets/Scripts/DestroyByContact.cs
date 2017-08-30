using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject playerExplosion;

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			Destroy(other.gameObject);
			Instantiate(playerExplosion, transform.position, Quaternion.identity);
		}
	}
}
