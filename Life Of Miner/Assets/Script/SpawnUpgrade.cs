using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnUpgrade : MonoBehaviour {

	public Text SpawnText;
	public Button SpUp;
	int SupCostValue = 0;
	float spawnLessTime = 0.1f;
	int[] spawnCost = {15, 15, 40, 40, 65, 65, 80, 80, 100, 150, 5000, 10000, 30000, 90000, 150000, 450000, 895000, 10000000, 50000000, 1};
	int gold = 0;
	int silver = 0;
	int copper = 0;

	void Awake(){
		SpUp = GetComponent<Button> ();
		SpUp.onClick.AddListener (AddSpawn);
	}

	void Update(){
		copper = spawnCost[SupCostValue] % 1000;
		silver = (spawnCost[SupCostValue] % 1000000)/1000;
		gold = spawnCost[SupCostValue] / 1000000;
		SpawnText.text =  "Less Value " + spawnLessTime + "\nCost " + 
			copper + "C " + silver + "S " + gold + "G";
	}

	void AddSpawn(){
		if (MoneyManager.instance.MoneyStack - spawnCost [SupCostValue] >= 0) {
			GameManager.instance.timeActive -= spawnLessTime;
			MoneyManager.instance.MoneyStack -= spawnCost [SupCostValue];
			if (SupCostValue <= 18) {
				SpawnText.text = "Decrease Value " + spawnLessTime + "\nCost " + 
					copper + "C " + silver + "S " + gold + "G";
				SupCostValue++;
			} else {
				SpawnText.text = "Decrease Value " + spawnLessTime + "\nCost " + 
					copper + "C " + silver + "S " + gold + "G\n(UP-MAX)";
			}

		}
	}
}
