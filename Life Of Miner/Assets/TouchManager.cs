using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

	// script static화
	public static TouchManager instance;

	// ore & player animation controllor

	public bool jud;

	void Awake() {
		instance = this;
	}

	// function value reset
	void Start() {
		
	}

	void Update() {
		
	}

}
