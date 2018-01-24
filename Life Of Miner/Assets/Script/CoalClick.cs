using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalClick : MonoBehaviour {

	CoalHealth coalhealth;

	void Awake() {
		coalhealth = GetComponent<CoalHealth> ();
	}
		
	void OnMouseDown() {
		coalhealth.TakeDamage (GameManager.instance.clickDamage);
		SoundManager.instance.TouchSound.Play();
	}
		
}