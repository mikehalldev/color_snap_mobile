using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmptyStringOnSpace : MonoBehaviour {
	
	void Update () {
		if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetButtonDown("Jump"))
			GetComponent<Text>().text = "";
	}
}
