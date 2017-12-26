using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    private bool ReceivedXP = false;
    private BattleStateStart battleStateStartScript = new BattleStateStart();
    private BattleStateAddStatusEffect battleStateAddStatusEffectScript = new BattleStateAddStatusEffect();

    public static BattleCalculations battleCalcScript = new BattleCalculations();
    public static BaseAbility playerUsedAbility;
    public static int statusEffectBaseDamage;

    private int maxPlayerLvl = 50;

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        CALCULATEDAMAGE,
        ADDSTATUSEFFECTS,
        ENEMYCHOICE,
        WIN,
        LOSE
    }

    public static BattleStates currentState;

	
	void Start () {

        LoadInformation.LoadAllInfromation();
        currentState = BattleStates.START;

	}
	
	void Update () { //acts as a loop.

        //Debug.Log(currentState);

        switch (currentState) //a switch is a case statement in a loop which is the void update.
        {
            case (BattleStates.START):
                battleStateStartScript.PrepareBattle();
                break;

            case (BattleStates.PLAYERCHOICE):
                
                break;

            case (BattleStates.ENEMYCHOICE):
                break;

            case (BattleStates.CALCULATEDAMAGE): //calculate damage and if status effect is active, add that damage.
                battleCalcScript.CalculateTotalPlayerDamage(playerUsedAbility);
                break;

            case (BattleStates.ADDSTATUSEFFECTS):
                battleStateAddStatusEffectScript.CheckAbilityForStatusEffects(playerUsedAbility);
                break;


            case (BattleStates.WIN):

                if (GameInformation.PlayerLevel < maxPlayerLvl)
                {
                    if (!ReceivedXP)
                    {
                        IncreaseExperience.AddExperienceWin();
                        ReceivedXP = true;
                    }
                }
                else
                {
                    GameInformation.PlayerLevel = maxPlayerLvl;
                }

                break;

            case (BattleStates.LOSE):

                if (GameInformation.PlayerLevel < maxPlayerLvl)
                {
                    if (!ReceivedXP)
                    {
                        IncreaseExperience.AddExperienceLose();
                        ReceivedXP = true;
                    }
                }
                else
                {
                    GameInformation.PlayerLevel = maxPlayerLvl;
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
