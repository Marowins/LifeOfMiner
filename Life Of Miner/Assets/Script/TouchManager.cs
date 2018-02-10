using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

	// require Animator
	public Animator Ore;
	public AudioSource Hit;

	// jud variable
	public bool jud = true;

	void Update() {
		if (Input.GetButtonDown ("Fire1")) {
			if (jud) {
				Ore.SetInteger ("JUDGE", 1);
				jud = false;
			} else {
				Ore.SetInteger ("JUDGE", -1);
				jud = true;
			}
			Hit.Play ();
		} else {
			Ore.SetInteger ("JUDGE", 0);
		}
	}

}