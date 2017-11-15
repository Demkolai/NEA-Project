using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptForLoading : MonoBehaviour {

	// Use this for initialization
	void Start () {

        LoadInformation.LoadAllInfromation();
        Debug.Log("Player Name: " + GameInfromation.PlayerName);
        //Debug.Log("Player Class: " + GameInfromation.PlayerClass);
        Debug.Log("Player Level: " + GameInfromation.PlayerLevel);
        Debug.Log("Player Stamina: " + GameInfromation.Stamina);
        Debug.Log("Player Strength: " + GameInfromation.Strength);
        Debug.Log("Player Intellect: " + GameInfromation.Intellect);
        Debug.Log("Player Dexterity: " + GameInfromation.Dexterity);
        Debug.Log("Player Charisma: " + GameInfromation.Charisma);
        Debug.Log("Player Wisdom: " + GameInfromation.Wisdom);
        Debug.Log("Player Gold: " + GameInfromation.Gold);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
