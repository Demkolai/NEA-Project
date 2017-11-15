using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;
    private bool isRogueClass;
    private bool isBardClass;
    private string playerName = "EnterName";

	// Use this for initialization
	void Start () {

        newPlayer = new BasePlayer();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName,15);
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        isRogueClass = GUILayout.Toggle(isRogueClass, "Rogue Class");
        isBardClass = GUILayout.Toggle(isBardClass, "Bard Class");

        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            else if (isRogueClass)
            {
                newPlayer.PlayerClass = new BaseRogueClass();
            }
            else if (isBardClass)
            {
                newPlayer.PlayerClass = new BaseBardClass();
            }

            CreateNewPlayer();
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInfromation();

        }

        if (GUILayout.Button("Load"))
        {
            SceneManager.LoadScene("Test");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInfromation.PlayerName = newPlayer.PlayerName;
        GameInfromation.PlayerLevel = newPlayer.PlayerLevel;
        GameInfromation.Stamina = newPlayer.Stamina;
        GameInfromation.Strength = newPlayer.Strength;
        GameInfromation.Intellect = newPlayer.Intellect;
        GameInfromation.Dexterity = newPlayer.Dexterity;
        GameInfromation.Charisma = newPlayer.Charisma;
        GameInfromation.Wisdom = newPlayer.Wisdom;
        GameInfromation.Armor = newPlayer.Armor;
        GameInfromation.Gold = newPlayer.Gold;
    }

    private void CreateNewPlayer()
    {
        newPlayer.PlayerLevel = 1;
        newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
        newPlayer.Strength = newPlayer.PlayerClass.Strength;
        newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
        newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
        newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
        newPlayer.Wisdom = newPlayer.PlayerClass.Wisdom;
        newPlayer.PlayerName = playerName;
        newPlayer.Gold = 100;
        Debug.Log("Player Name: " + newPlayer.PlayerName);
        Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + newPlayer.PlayerLevel);
        Debug.Log("Player Stamina: " + newPlayer.PlayerClass.Stamina);
        Debug.Log("Player Strength: " + newPlayer.PlayerClass.Strength);
        Debug.Log("Player Intellect: " + newPlayer.PlayerClass.Intellect);
        Debug.Log("Player Dexterity: " + newPlayer.PlayerClass.Dexterity);
        Debug.Log("Player Charisma: " + newPlayer.PlayerClass.Charisma);
        Debug.Log("Player Wisdom: " + newPlayer.PlayerClass.Wisdom);
        Debug.Log("Player Gold: " + newPlayer.Gold);
    }
}
