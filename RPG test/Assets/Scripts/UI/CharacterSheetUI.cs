using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSheetUI : MonoBehaviour {

    public Text PlayerName;
    public Text PlayerClass;
    public Text PlayerLevel;
    public Text Stamina;
    public Text Strength;
    public Text Dexterity;
    public Text Intellect;
    public Text Wisdom;
    public Text Charisma;
    public Text Gold;
    public Text Armor;
    public GameObject CharacterSheetUi;

	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Character Sheet"))
        {
            CharacterSheetUi.SetActive(!CharacterSheetUi.activeSelf);
        }

        PlayerName.text = "Player Name: " + GameInformation.PlayerName;
        PlayerClass.text = "Player Class: " + GameInformation.PlayerClasss;
        PlayerLevel.text = "Player Level: " + GameInformation.PlayerLevel;
        Stamina.text = "Stamina: " + GameInformation.Stamina;
        Strength.text = "Strength: " + GameInformation.Strength;
        Dexterity.text = "Dextrity: " + GameInformation.Dexterity;
        Intellect.text = "Intellect: " + GameInformation.Intellect;
        Wisdom.text = "Wisdom: " + GameInformation.Wisdom;
        Charisma.text = "Charisma: " + GameInformation.Charisma;
        Gold.text = "Gold: " + GameInformation.Gold;
        Armor.text = "Armor: " + GameInformation.Armor;
    }
}
