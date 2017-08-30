using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

	[SerializeField] GameObject[] objs;
	private Transform cam;

	public float spawnMin;

	public float spawnMax;
	public float spawnDistance;

	public float startSpawnDistance;

	private float nextLocation;

	private Vector3 gridSize;
	
	void Start() {
		spawn();
		nextLocation = Mathf.Round(transform.position.y - startSpawnDistance);
		gridSize = new Vector3 (1f, 1f, 1f);
	}

	void Update() {
		if (transform.position.y < nextLocation) {
			Invoke ("spawn", Random.Range (spawnMin, spawnMax));
			nextLocation = Mathf.Round(transform.position.y - spawnDistance);
		}
	}

	void spawn() {
		Instantiate (objs[Random.Range(0, objs.Length)], transform.position, Quaternion.identity);
	}
}
