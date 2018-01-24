using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;

	public AudioSource TouchSound;

	void Awake() {
		instance = this;
	}
}
