using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour {

	private Vector3 gridSize = new Vector3 (1f, 2f, 1f);
	private Vector3 moveDirection = new Vector3 (0f, 0f, 1f);

	// Use this for initialization
	void Start () {
		Invoke("UpdatePosition", 0f);
	}
	
	// Update is called once per frame
	void UpdatePosition() {
		Vector3 newPos = transform.position + moveDirection;
		newPos = new Vector3(transform.position.x,
							Mathf.Round(newPos.y/gridSize.y)*gridSize.y,
							transform.position.z);
		transform.position = newPos;
	}
}
