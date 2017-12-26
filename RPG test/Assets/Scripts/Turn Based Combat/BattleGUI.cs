using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleGUI : MonoBehaviour {

    private string playerName;
    private int playerLevel;
    private int playerHealth;
    private int playerMana;  

	// Use this for initialization
	void Start () {
        playerName =  GameInformation.PlayerName;
        playerLevel = GameInformation.PlayerLevel;
		Debug.Log (playerName);
		Debug.Log (GameInformation.PlayerMoveOne.AbilityName);
		Debug.Log (GameInformation.PlayerMoveTwo.AbilityName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (StateMachine.currentState == StateMachine.BattleStates.PLAYERCHOICE)
        {
            DisplayPlayersChoice();
        }

        //we need to show enemy health and other enemy info
        //we need to show player information.
    }

    private void DisplayPlayersChoice()
    {
        if (GUI.Button(new Rect(Screen.width - 320, Screen.height - 50, 100, 30), GameInformation.PlayerMoveOne.AbilityName))
        {
            //calculate the players damage to the enemy.
            StateMachine.playerUsedAbility = GameInformation.PlayerMoveOne;
            StateMachine.currentState = StateMachine.BattleStates.ADDSTATUSEFFECTS;
        }
        if (GUI.Button(new Rect(Screen.width - 200, Screen.height - 50, 100, 30), GameInformation.PlayerMoveTwo.AbilityName))
        {
            //calculate the players damage to the enemy.
            StateMachine.playerUsedAbility = GameInformation.PlayerMoveTwo;
            StateMachine.currentState = StateMachine.BattleStates.ADDSTATUSEFFECTS;
        }
    }
}
