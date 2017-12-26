using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptForLoading : MonoBehaviour {

	// Use this for initialization
	void Start () {

        LoadInformation.LoadAllInfromation();
        Debug.Log("Player Name: " + GameInformation.PlayerName);
        //Debug.Log("Player Class: " + GameInfromation.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Stamina: " + GameInformation.Stamina);
        Debug.Log("Player Strength: " + GameInformation.Strength);
        Debug.Log("Player Intellect: " + GameInformation.Intellect);
        Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
        Debug.Log("Player Charisma: " + GameInformation.Charisma);
        Debug.Log("Player Wisdom: " + GameInformation.Wisdom);
        Debug.Log("Player Gold: " + GameInformation.Gold);
        Debug.Log("Player Ability one: " + GameInformation.PlayerMoveOne.AbilityName);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
