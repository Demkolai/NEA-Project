using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    private bool ReceivedXP = false;
    private BattleStateStart battleStateStartScript = new BattleStateStart();
    private BattleStateAddStatusEffect battleStateAddStatusEffectScript = new BattleStateAddStatusEffect();
    private BattleStateEnemyChoice battleStateEnemyChoiceScript = new BattleStateEnemyChoice();

    public static BattleCalculations battleCalcScript = new BattleCalculations();
    public static BaseAbility playerUsedAbility;
    public static BaseAbility enemyUsedAbility;
    public static int statusEffectBaseDamage;
    public static int totalTurnCount;
    public static BattleStates currentUser;

    private int maxPlayerLvl = 50;

    public GameObject VictoryScreen;
    public GameObject DeathScreen;
    public GameObject MainChoiceMenu;
    public GameObject DamageLog;
    public GameObject PlayerHPBar;
    public GameObject EnemyHPBar;

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        CALCULATEDAMAGE,
        ADDSTATUSEFFECTS,
        ENEMYCHOICE,
        ENDTURN,
        WIN,
        LOSE
    }

    public static BattleStates currentState;

	
	void Start () {

        LoadInformation.LoadAllInfromation();
        totalTurnCount = 1;
        currentState = BattleStates.START;

	}
	
	void Update () { //acts as a loop.

        switch (currentState) //a switch is a case statement in a loop which is the void update.
        {
            case (BattleStates.START):
                battleStateStartScript.PrepareBattle();
                break;

            case (BattleStates.PLAYERCHOICE):
                currentUser = BattleStates.PLAYERCHOICE;
                break;

            case (BattleStates.ENEMYCHOICE):
                currentUser = BattleStates.ENEMYCHOICE;
                battleStateEnemyChoiceScript.EnemyCompleteTurn();
                break;

            case (BattleStates.CALCULATEDAMAGE): //calculate damage and if status effect is active, add that damage.
                if(currentUser == BattleStates.PLAYERCHOICE)
                {
                    battleCalcScript.CalculateTotalPlayerDamage(playerUsedAbility);
                }
                else if (currentUser == BattleStates.ENEMYCHOICE)
                {
                    battleCalcScript.CalculateTotalEnemyDamage(enemyUsedAbility);
                }
                break;

            case (BattleStates.ADDSTATUSEFFECTS):
                battleStateAddStatusEffectScript.CheckAbilityForStatusEffects(playerUsedAbility);
                break;

            case (BattleStates.ENDTURN):
                totalTurnCount += 1;
                if (GameInformation.PlayerHealth <= 0)
                {
                    currentState = StateMachine.BattleStates.LOSE;
                }
                else
                {
                    currentState = StateMachine.BattleStates.PLAYERCHOICE;
                }
                break;


            case (BattleStates.WIN):

                VictoryScreen.SetActive(true);
                MainChoiceMenu.SetActive(false);
                PlayerHPBar.SetActive(false);
                EnemyHPBar.SetActive(false);
                DamageLog.SetActive(false);

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

                DeathScreen.SetActive(true);
                MainChoiceMenu.SetActive(false);
                PlayerHPBar.SetActive(false);
                EnemyHPBar.SetActive(false);
                DamageLog.SetActive(false);

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

}
