using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

    public static void LoadAllInfromation()
    {
        GameInfromation.PlayerName = PlayerPrefs.GetString("Player Name");
        GameInfromation.PlayerLevel = PlayerPrefs.GetInt("Player Level");
        GameInfromation.Stamina = PlayerPrefs.GetInt("Stamina");
        GameInfromation.Strength = PlayerPrefs.GetInt("Strength");
        GameInfromation.Intellect = PlayerPrefs.GetInt("Intellect");
        GameInfromation.Dexterity = PlayerPrefs.GetInt("Dexterity");
        GameInfromation.Charisma = PlayerPrefs.GetInt("Charisma");
        GameInfromation.Wisdom = PlayerPrefs.GetInt("Wisdom");
        GameInfromation.Armor = PlayerPrefs.GetInt("Armor");
        GameInfromation.Gold = PlayerPrefs.GetInt("Gold");

        if (PlayerPrefs.GetString("Equipment item 1") != null)
        {
            GameInfromation.EquipmentOne = (BaseEquipment) PlayerPrefsSerialization.Load("Equipment item 1");
        }

    }

}
