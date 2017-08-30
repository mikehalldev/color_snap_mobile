using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionColorController : MonoBehaviour {

	public Material blue;

	public Material red;

	public Material blueTrail;

	public Material redTrail;

	private bool isBlue;

	void Start() {
		isBlue = FindObjectOfType<GameController>().isBlue;

		if (!isBlue) {
			gameObject.GetComponent<ParticleSystemRenderer> ().material = blue;
			gameObject.GetComponent<ParticleSystemRenderer> ().trailMaterial = blueTrail;
		} else {
			gameObject.GetComponent<ParticleSystemRenderer> ().material = red;
			gameObject.GetComponent<ParticleSystemRenderer> ().trailMaterial = redTrail;
		}
	}
}
