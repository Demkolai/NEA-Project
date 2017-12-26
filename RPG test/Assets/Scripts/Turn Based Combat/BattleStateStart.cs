using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart {

    public BaseEnemy newEnemy = new BaseEnemy();
    private StatCalculations statCalculationsScript = new StatCalculations();
    private BaseCharacterClass[] classTypes = new BaseCharacterClass[] { new BaseWarriorClass(), new BaseMageClass(), new BaseRogueClass(), new BaseBardClass(), new BaseArcherClass() };
    //private string[] enemyNames = new string[] { "Skeleton", "Orc", "Ogre" };
    private bool isEnemy = false;

    private int playerStamina;
    private int playerWisdom;
    private int playerHealth;
    private int playerMana;

    public void PrepareBattle()
    {
        //Create an enemy.
        CreateEnemy();
        //Find player vitals(Stat calculations)
        DeterminePlayerVitals();
        StateMachine.currentState = StateMachine.BattleStates.PLAYERCHOICE;
    }

    public void CreateEnemy()
    {
        isEnemy = true;
        newEnemy.EnemyName = "Skeleton";
        newEnemy.EnemyLevel = Random.Range(GameInformation.PlayerLevel - 2, GameInformation.PlayerLevel + 2);
        newEnemy.EnemyClass = classTypes[Random.Range(0, classTypes.Length)];
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Stamina, StatCalculations.StatType.STAMINA, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Strength, StatCalculations.StatType.STRENGTH, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Intellect, StatCalculations.StatType.INTELLECT, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Dexterity, StatCalculations.StatType.DEXTERITY, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Charisma, StatCalculations.StatType.CHARISMA, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Wisdom, StatCalculations.StatType.WISDOM, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Armor = 10 * newEnemy.EnemyLevel;
    }

    private void DeterminePlayerVitals()
    {
        playerStamina = statCalculationsScript.CalculateStat(GameInformation.Stamina, StatCalculations.StatType.STAMINA, GameInformation.PlayerLevel, isEnemy);
        playerWisdom = statCalculationsScript.CalculateStat(GameInformation.Wisdom, StatCalculations.StatType.WISDOM, GameInformation.PlayerLevel, isEnemy);
        playerHealth = statCalculationsScript.CalculateHealth(playerStamina); //calcualting health
        playerHealth = statCalculationsScript.CalculateMana(playerWisdom); // calculating mana
        GameInformation.PlayerHealth = playerHealth;
        GameInformation.PlayerMana = playerMana;

    }
}
