using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

	[SerializeField] GameObject[] objs;
	private Transform cam;

	public float spawnDistance;

	public float startSpawnDistance;

	private float nextLocation;
	
	void Start() {
		spawn();
		nextLocation = Mathf.Round(transform.position.y - startSpawnDistance);
	}

	void Update() {
		if (transform.position.y < nextLocation) {
			Invoke ("spawn",0f);
			nextLocation = Mathf.Round(transform.position.y - spawnDistance + Random.Range(-5, 5));
		}
	}

	void spawn() {
		Instantiate (objs[Random.Range(0, objs.Length)], transform.position, Quaternion.identity);
	}
}
