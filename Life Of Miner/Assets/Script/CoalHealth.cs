using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalHealth : MonoBehaviour {

	public float StartHealth = 100f;
	public float CurrentHealth = 0f;

	void Awake() {
		CurrentHealth = StartHealth;
	}

	public void TakeDamage(int amount) {
		if ( CurrentHealth - amount <= 0 ) {
			MoneyManager.instance.MoneyText(GameManager.instance.CoreOreCost);
			GameManager.instance.HealthSlider.value -= amount;
			CurrentHealth = 100f;
			GameManager.instance.HealthSlider.gameObject.SetActive(false);
			GameManager.instance.CoalOre.SetActive (false);
			GameManager.instance.jud = true;
			GameManager.instance.timer = 0f;
		} else {
			CurrentHealth -= amount;
			GameManager.instance.HealthSlider.value = CurrentHealth;
		}
	}
}

