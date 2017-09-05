using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartOnClick : MonoBehaviour {

	void Start () {
		Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
