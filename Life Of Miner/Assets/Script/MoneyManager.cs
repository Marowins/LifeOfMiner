using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

	public static MoneyManager instance;

	public Text Copper; public float copper=0;
	public Text Silver; public float silver=0;
	public Text Gold; 	public float gold=0;

	public int MoneyStack = 0;

	void Awake() {
		instance = this;
	}

	void Update() {
		copper = MoneyStack % 1000;
		silver = (MoneyStack % 1000000)/1000;
		gold = MoneyStack / 1000000;
		Copper.text = copper + "C";
		Silver.text = silver + "S";
		Gold.text = gold + "G";
		if( MoneyStack > 9999999999 )
			Gold.text = 9999 + "+";
	}

	public void MoneyText(int amount) {
		MoneyStack += amount;
	}

}
