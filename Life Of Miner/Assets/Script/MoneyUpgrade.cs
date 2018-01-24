using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUpgrade : MonoBehaviour {

	public Button MoUp;
	public Text MoText;
	int MupCostValue = 0;
	int[] MoneyCost = {2, 22, 222, 2222, 22222, 550999999};
	int MoneyValue = 1;

	void Awake() {
		MoUp = GetComponent<Button> ();
		MoUp.onClick.AddListener (AddMoney);
	}

	void AddMoney() {
		if (MoneyManager.instance.MoneyStack - MoneyCost[MupCostValue] >= 0) {
			GameManager.instance.CoreOreCost += MoneyValue;
			MoneyManager.instance.MoneyStack -= MoneyCost[MupCostValue];
			if (MupCostValue <= 4) {
				MupCostValue++;
				MoText.text = "Plus Money " + MoneyValue+ "\nCost " + MoneyCost[MupCostValue] + "C";
			} else {
				MoText.text = "Plus Money "+MoneyValue+"\nCost "+MoneyCost[MupCostValue]+"C\n(UP-MAX)";

			}
		}
	}

}
