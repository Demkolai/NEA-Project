using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

    public static void LoadAllInfromation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("Player Name");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("Player Level");
        GameInformation.Stamina = PlayerPrefs.GetInt("Stamina");
        GameInformation.Strength = PlayerPrefs.GetInt("Strength");
        GameInformation.Intellect = PlayerPrefs.GetInt("Intellect");
        GameInformation.Dexterity = PlayerPrefs.GetInt("Dexterity");
        GameInformation.Charisma = PlayerPrefs.GetInt("Charisma");
        GameInformation.Wisdom = PlayerPrefs.GetInt("Wisdom");
        GameInformation.Armor = PlayerPrefs.GetInt("Armor");
        GameInformation.Gold = PlayerPrefs.GetInt("Gold");
        GameInformation.PlayerClasss = PlayerPrefs.GetString("Player Class");

		//script to load the correct abillities for each class based on a variable set in the character creation script.
		if (PlayerPrefs.GetString("Player Class") == "Warrior"){
			GameInformation.PlayerClass = new BaseWarriorClass ();
			GameInformation.PlayerMoveOne = new AutoAttack ();
			GameInformation.PlayerMoveTwo = new SwordSlash ();
		}
		else if (PlayerPrefs.GetString("Player Class") == "Mage"){
			GameInformation.PlayerClass = new BaseMageClass ();
			GameInformation.PlayerMoveOne = new RangedAutoAttack ();
			GameInformation.PlayerMoveTwo = new Fireblast ();
		}
		else if (PlayerPrefs.GetString("Player Class") == "Rogue"){
			GameInformation.PlayerClass = new BaseRogueClass ();
			GameInformation.PlayerMoveOne = new AutoAttack ();
			GameInformation.PlayerMoveTwo = new Backstab ();
		}
		else if (PlayerPrefs.GetString("Player Class") == "Archer"){
			GameInformation.PlayerClass = new BaseArcherClass ();
			GameInformation.PlayerMoveOne = new RangedAutoAttack ();
			GameInformation.PlayerMoveTwo = new PowerShot ();
		}

        if (PlayerPrefs.GetString("Equipment item 1") != null)
        {
            GameInformation.EquipmentOne = (BaseEquipment) PlayerPrefsSerialization.Load("Equipment item 1");
        }

    }

}
