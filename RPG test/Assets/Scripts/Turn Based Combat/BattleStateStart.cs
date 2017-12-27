using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart {

    public BaseEnemy newEnemy = new BaseEnemy();
    private StatCalculations statCalculationsScript = new StatCalculations();
    //private BaseCharacterClass[] classTypes = new BaseCharacterClass[] { new BaseWarriorClass(), new BaseRogueClass() };
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
        newEnemy.EnemyClass = new BaseWarriorClass();
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.EnemyClass.Stamina, StatCalculations.StatType.STAMINA, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Strength = statCalculationsScript.CalculateStat(newEnemy.EnemyClass.Strength, StatCalculations.StatType.STRENGTH, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Intellect = statCalculationsScript.CalculateStat(newEnemy.EnemyClass.Intellect, StatCalculations.StatType.INTELLECT, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Dexterity = statCalculationsScript.CalculateStat(newEnemy.EnemyClass.Dexterity, StatCalculations.StatType.DEXTERITY, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Charisma = statCalculationsScript.CalculateStat(newEnemy.EnemyClass.Charisma, StatCalculations.StatType.CHARISMA, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Wisdom = statCalculationsScript.CalculateStat(newEnemy.EnemyClass.Wisdom, StatCalculations.StatType.WISDOM, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Health = statCalculationsScript.CalculateHealth(newEnemy.Stamina);
        newEnemy.Mana = statCalculationsScript.CalculateMana(newEnemy.Wisdom);
        newEnemy.AbilityOne = new AutoAttack();
        newEnemy.AbilityTwo = new SwordSlash();
        newEnemy.Armor = 10 * newEnemy.EnemyLevel;
        
    }

    private void DeterminePlayerVitals()
    {
        playerStamina = statCalculationsScript.CalculateStat(GameInformation.Stamina, StatCalculations.StatType.STAMINA, GameInformation.PlayerLevel, isEnemy);
        playerWisdom = statCalculationsScript.CalculateStat(GameInformation.Wisdom, StatCalculations.StatType.WISDOM, GameInformation.PlayerLevel, isEnemy);
        playerHealth = statCalculationsScript.CalculateHealth(playerStamina); //calcualting health
        playerMana = statCalculationsScript.CalculateMana(playerWisdom); // calculating mana
        GameInformation.PlayerHealth = playerHealth;
        GameInformation.PlayerMana = playerMana;

    }
}
