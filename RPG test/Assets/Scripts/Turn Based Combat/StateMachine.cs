using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    private bool ReceivedXP = false;
    private int maxPlayerLvl = 50;

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        WIN,
        LOSE
    }

    private BattleStates currentState;

	
	void Start () {

        currentState = BattleStates.START;

	}
	
	void Update () { //acts as a loop.

        Debug.Log(currentState);

        switch (currentState) //a switch is a case statement in a loop which is the void update.
        {
            case (BattleStates.START):
                break;

            case (BattleStates.PLAYERCHOICE):
                break;

            case (BattleStates.ENEMYCHOICE):
                break;

            case (BattleStates.WIN):

                if (GameInfromation.PlayerLevel < maxPlayerLvl)
                {
                    if (!ReceivedXP)
                    {
                        IncreaseExperience.AddExperienceWin();
                        ReceivedXP = true;
                    }
                }
                else
                {
                    GameInfromation.PlayerLevel = maxPlayerLvl;
                }

                break;

            case (BattleStates.LOSE):

                if (GameInfromation.PlayerLevel < maxPlayerLvl)
                {
                    if (!ReceivedXP)
                    {
                        IncreaseExperience.AddExperienceLose();
                        ReceivedXP = true;
                    }
                }
                else
                {
                    GameInfromation.PlayerLevel = maxPlayerLvl;
                }

                break;

        }

	}

    void OnGUI() //used to create gui buttons and functions.
    {
        if(GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }
            else if (currentState == BattleStates.PLAYERCHOICE)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }
            else if (currentState == BattleStates.ENEMYCHOICE)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }
            
        }
    }
}
