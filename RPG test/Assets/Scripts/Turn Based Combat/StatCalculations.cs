using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCalculations {

    private float playerStaminaModifier = 0.15f; // 0.15f = 15%
    private float playerWisdomModifier = 0.1f; // 0.1f = 10%

    private float enemyStaminaModifier = 0.15f; // 0.25f = 25%
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

        else if(!isEnemy)
        {
            SetHealthAndManaModifier(statType);
            return (statVal + (int)((statVal * statModifier) * level));
        }
        return 0;
    }
    //-----------------------------------------------------------------------------
    private void SetHealthAndManaModifier(StatType statType)
    {
        if (statType == StatType.STAMINA)
        {
            statModifier = playerStaminaModifier;
        }
        if (statType == StatType.WISDOM)
        {
            statModifier = playerWisdomModifier;
        }
    }
    //----------------------------------------------------------------------------
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
    //------------------------------------------------------------------------------
    public int CalculateHealth(int statValue)
    {
        return statValue * 15; //calculating health based on stamina
    }

    public int CalculateMana(int statValue)
    {
        return statValue * 10; //calculating mana based on wisdom
    }
    //-----------------------------------------------------------------------------
    public int FindPlayerClassBonusDamage(string playerClass) // used to 
    {
        if (playerClass == "Warrior")
        {
            int Bonus = (int)(GameInformation.Strength * 0.3);
            return Bonus;
        }
        else if (playerClass == "Mage")
        {
            int Bonus = (int)(GameInformation.Intellect * 0.4);
            return Bonus;
        }
        else if (playerClass == "Rogue" || playerClass == "Archer")
        {
            int Bonus = (int)((GameInformation.Dexterity * 0.3) + (GameInformation.Strength *0.1));
            return Bonus;
        }
        else if (playerClass == "Bard")
        {
            int Bonus = (int)(GameInformation.Charisma * 0.3);
            return Bonus;
        }
        return 0 ;
    }
}
