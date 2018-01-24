using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatText : MonoBehaviour {

	public Text statText;

	void Update(){
		statText.text = "MY DM : " + GameManager.instance.clickDamage
		+ "\nSPAWN SPEED : " + GameManager.instance.timeActive +
		"\nADD MONEY : " + GameManager.instance.CoreOreCost;
	}
}
