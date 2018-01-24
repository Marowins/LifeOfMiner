using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public GameObject CoalOre;
	public Slider HealthSlider;

	public float timer = 0f;
	public float timeActive = 2f;
	public bool jud = false;
	public int clickDamage = 1;

	public int CoreOreCost = 5;

	void Awake() {
		instance = this;
	}

	void Update() {
		if (timer >= timeActive && jud == true) {
			CoalOre.SetActive (true);
			GameManager.instance.HealthSlider.gameObject.SetActive(true);
			HealthSlider.value = 100f;
			jud = false;
		}
		timer += Time.deltaTime;

	}

}
