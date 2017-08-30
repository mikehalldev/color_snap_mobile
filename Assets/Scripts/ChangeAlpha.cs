using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlpha : MonoBehaviour {
	public Material platformMat;
	private Color platformColor;

	public bool transparent;

	private bool isBlue;

	private BoxCollider boxCol;

	void Start() {
		platformMat = GetComponent<Renderer>().material;
		platformColor = platformMat.color;
		platformColor.a = 1f;
		transparent = false;

		boxCol = GetComponent<BoxCollider>();
	}

	void Update() {
		isBlue = FindObjectOfType<GameController>().isBlue;

		if ((isBlue && gameObject.tag == "Red") || (!isBlue && gameObject.tag == "Blue") ) transparent = false;
		if ((!isBlue && gameObject.tag == "Red") || (isBlue && gameObject.tag == "Blue") ) transparent = true;


		if (transparent) {
			platformColor.a = 0.25f;
			platformMat.color = platformColor;
			boxCol.isTrigger = true;
		}
		else {
			platformColor.a = 1f;
			platformMat.color = platformColor;
			boxCol.isTrigger = false;
		}
	}
}
