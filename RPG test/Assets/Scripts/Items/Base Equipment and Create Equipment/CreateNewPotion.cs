using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour {

    private BasePotion newPotion;
    private string PotionType;

	// Use this for initialization
	void Start () {

        CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID);
        Debug.Log(newPotion.PotionType);
        
    }

    private void CreatePotion()
    {
        newPotion = new BasePotion();
        ChoosePotionType();
        newPotion.ItemName = PotionType + " potion";
        newPotion.ItemDescription = "A " + PotionType + " potion.";
        newPotion.ItemID = Random.Range(1, 101);
    }

    private void ChoosePotionType()
    {
        System.Array potions = System.Enum.GetValues(typeof(BasePotion.PotionTypes));
        newPotion.PotionType = (BasePotion.PotionTypes)potions.GetValue(Random.Range(0, potions.Length));

    }
}
