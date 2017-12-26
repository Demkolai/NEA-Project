using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

    public static void SaveAllInfromation()
    {
        PlayerPrefs.SetInt("Player Level", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("Player Name", GameInformation.PlayerName);
        PlayerPrefs.SetInt("Stamina", GameInformation.Stamina);
        PlayerPrefs.SetInt("Strength", GameInformation.Strength);
        PlayerPrefs.SetInt("Intellect", GameInformation.Intellect);
        PlayerPrefs.SetInt("Dexterity", GameInformation.Dexterity);
        PlayerPrefs.SetInt("Charisma", GameInformation.Charisma);
        PlayerPrefs.SetInt("Wisdom", GameInformation.Wisdom);
        PlayerPrefs.SetInt("Armor", GameInformation.Armor);
        PlayerPrefs.SetInt("Gold", GameInformation.Gold);
        PlayerPrefs.SetString("Player Class", GameInformation.PlayerClasss);

        if (GameInformation.EquipmentOne != null)
        {
            PlayerPrefsSerialization.Save("Equipment item 1", GameInformation.EquipmentOne);
        }

        Debug.Log("Saved all information");
    }

}
