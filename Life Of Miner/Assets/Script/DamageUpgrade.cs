using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUpgrade : MonoBehaviour {

	public Text DmText;
	public Button DmUp;
	int DupCostValue = 0;
	int[] damageCost = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 ,14, 15};
	int[] damageValue = {1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3};

	void Awake() {
		DmUp = GetComponent<Button> ();
		DmUp.onClick.AddListener (AddDamage);
	}

	void AddDamage() {
		if (MoneyManager.instance.MoneyStack - damageCost[DupCostValue] >= 0) {
			GameManager.instance.clickDamage += damageValue[DupCostValue];
			MoneyManager.instance.MoneyStack -= damageCost[DupCostValue];
			if (DupCostValue <= 13) {
				DupCostValue++;
				DmText.text = "DM " + damageValue [DupCostValue] + "\nCost " + damageCost[DupCostValue] + "C";
			} else {
				DmText.text = "DM "+damageValue [DupCostValue]+"\nCost "+damageCost[DupCostValue]+"C\n(UP-MAX)";

			}
		}
	}

}
