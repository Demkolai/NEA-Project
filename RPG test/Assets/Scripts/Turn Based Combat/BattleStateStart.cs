using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart {

    private BaseEnemy newEnemy = new BaseEnemy();
    private StatCalculations statCalculationsScript = new StatCalculations();
    private BaseCharacterClass[] classTypes = new BaseCharacterClass[] { new BaseWarriorClass(), new BaseMageClass(), new BaseRogueClass(), new BaseBardClass(), new BaseArcherClass() };
    private string[] enemyNames = new string[] { "Skeleton", "Orc", "Ogre" };
    private bool isEnemy = false;

    public void PrepareBattle()
    {
        //Create an enemy.
        CreateEnemy();
        StateMachine.currentState = StateMachine.BattleStates.PLAYERCHOICE;
    }

    public void CreateEnemy()
    {
        isEnemy = true;
        newEnemy.EnemyName = enemyNames[Random.Range(0, enemyNames.Length + 1)];
        newEnemy.EnemyLevel = Random.Range(GameInfromation.PlayerLevel - 2, GameInfromation.PlayerLevel + 2);
        newEnemy.EnemyClass = classTypes[Random.Range(0, classTypes.Length + 1)];
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Stamina, StatCalculations.StatType.STAMINA, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Strength, StatCalculations.StatType.STRENGTH, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Intellect, StatCalculations.StatType.INTELLECT, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Dexterity, StatCalculations.StatType.DEXTERITY, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Charisma, StatCalculations.StatType.CHARISMA, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Stamina = statCalculationsScript.CalculateStat(newEnemy.Wisdom, StatCalculations.StatType.WISDOM, newEnemy.EnemyLevel, isEnemy);
        newEnemy.Armor = 10 * newEnemy.EnemyLevel;
    }
}
