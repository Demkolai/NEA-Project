using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

    public static void SaveAllInfromation()
    {
        PlayerPrefs.SetInt("Player Level", GameInfromation.PlayerLevel);
        PlayerPrefs.SetString("Player Name", GameInfromation.PlayerName);
        PlayerPrefs.SetInt("Stamina", GameInfromation.Stamina);
        PlayerPrefs.SetInt("Strength", GameInfromation.Strength);
        PlayerPrefs.SetInt("Intellect", GameInfromation.Intellect);
        PlayerPrefs.SetInt("Dexterity", GameInfromation.Dexterity);
        PlayerPrefs.SetInt("Charisma", GameInfromation.Charisma);
        PlayerPrefs.SetInt("Wisdom", GameInfromation.Wisdom);
        PlayerPrefs.SetInt("Armor", GameInfromation.Armor);
        PlayerPrefs.SetInt("Gold", GameInfromation.Gold);

        if (GameInfromation.EquipmentOne != null)
        {
            PlayerPrefsSerialization.Save("Equipment item 1", GameInfromation.EquipmentOne);
        }

        Debug.Log("Saved all information");
    }

}
