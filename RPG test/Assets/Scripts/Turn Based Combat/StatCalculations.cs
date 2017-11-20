using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCalculations {

    private float enemyStaminaModifier = 0.25f; // 0.25f = 25%
    private float enemyStrengthModifier = 0.2f; // 0.2f = 20%
    private float enemyIntellectModifier = 0.2f;
    private float enemyDexterityModifier = 0.2f;
    private float enemyCharismaModifier = 0.2f;
    private float enemyWisdomModifier = 0.2f;
    private float statModifier;

    public enum StatType
    {
        STAMINA,
        STRENGTH,
        INTELLECT,
        DEXTERITY,
        CHARISMA,
        WISDOM
    }

    public int CalculateStat(int statVal, StatType statType, int level, bool isEnemy)
    {
        if(isEnemy == true)
        {
            SetEnemyModifier(statType);
            return (statVal + (int)((statVal * statModifier) * level));
        }
        return 0;
    }

    private void SetEnemyModifier(StatType statType)
    {
        if (statType == StatType.STAMINA)
        {
            statModifier = enemyStaminaModifier;
        }
        if (statType == StatType.STRENGTH)
        {
            statModifier = enemyStrengthModifier;
        }
        if (statType == StatType.INTELLECT)
        {
            statModifier = enemyIntellectModifier;
        }
        if (statType == StatType.DEXTERITY)
        {
            statModifier = enemyDexterityModifier;
        }
        if (statType == StatType.CHARISMA)
        {
            statModifier = enemyCharismaModifier;
        }
        if (statType == StatType.WISDOM)
        {
            statModifier = enemyWisdomModifier;
        }
    }
}
