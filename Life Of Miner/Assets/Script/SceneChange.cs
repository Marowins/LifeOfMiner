using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour {

	public Button sceneChange;
	Scene currentScene;

	void Awake() {
		sceneChange = GetComponent<Button> ();
		sceneChange.onClick.AddListener (Change);
	}

	void Update() {
		currentScene = SceneManager.GetActiveScene ();
	}

	void Change() {
		if (currentScene.name == "CoalStage") {
			SceneManager.LoadScene ("SilverStage");
		} else if (currentScene.name == "SilverStage") {
			SceneManager.LoadScene ("GoldStage");
		} else {
			SceneManager.LoadScene ("CoalStage");
		}
	}

}
