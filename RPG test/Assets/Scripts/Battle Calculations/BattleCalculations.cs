using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations {

    private StatCalculations statCalcScript = new StatCalculations();

    private BaseAbility playerUsedAbility;

    private int abilityPower;
    private int statusEffectDamage;
    private float totalAbilityDamage;
    private int playerClassModifier;
    private float totalPlayerDamage;
    private float totalEnemyDamage;
    private int totalCritStrikeDamage;

    // -----------------------------------------------------Player Damage Calculation--------------------------------------------------------------------------------

    public void CalculateTotalPlayerDamage(BaseAbility usedAbility)
    {
        totalAbilityDamage = (int)CalculatePlayerAbilityDamage(usedAbility);
        totalPlayerDamage = totalAbilityDamage + CalculatePlayerStatusEffectDamage() + CalculatePlayerCriticalStrikeDamage(usedAbility) - EnemyInformation.Armor;
        EnemyInformation.Health = EnemyInformation.Health - (int)totalPlayerDamage;

        if(EnemyInformation.Health <= 0)
        {
            StateMachine.currentState = StateMachine.BattleStates.WIN;
        }
        else
        {
            Debug.Log("Total player damage: " + totalPlayerDamage);
            BattleGUI.playerDamageValue = GameInformation.PlayerName + " dealt " + totalPlayerDamage;
            BattleGUI.isPlayerDamage = true;
            StateMachine.currentState = StateMachine.BattleStates.ENEMYCHOICE;
        }

        // move damage + status effect damage + critical strike - armor + weapon damage.
        //use an ability
        //calculate damage
        //check status effect
        //if the move adds a status effect
        //try to add it.
        //if effect is added, then apply damage from effect.
        //calculate total damage with status effect in mind.
    }

    private float CalculatePlayerAbilityDamage(BaseAbility usedAbility)
    {
        abilityPower = usedAbility.AbilityPower; //retrieves power of move.
        totalAbilityDamage = abilityPower + statCalcScript.FindPlayerClassBonusDamage(GameInformation.PlayerClasss); ;
        return totalAbilityDamage;
    }

    private int CalculatePlayerStatusEffectDamage()
    {
        statusEffectDamage = StateMachine.statusEffectBaseDamage * GameInformation.PlayerLevel;
        return statusEffectDamage;
    }

    private float CalculatePlayerCriticalStrikeDamage(BaseAbility usedAbility)
    {
        if (DecideIfPlayerAbilityCriticallyHit(usedAbility)) //if the function returns true
        {
            totalCritStrikeDamage = (int)(totalAbilityDamage * 0.25f);
            return totalCritStrikeDamage;
        }
        else
        {
            return totalCritStrikeDamage = 0;
        }
    }

    private bool DecideIfPlayerAbilityCriticallyHit(BaseAbility usedAbility)
    {
        int randomtemp = Random.Range(1, 101);
        int CritChance = (int)(usedAbility.AbilityCritChance + (GameInformation.Dexterity * 0.2));
        if (randomtemp <= CritChance)
        {
            Debug.Log("CRIT!");
            return true;
        }
        else
        {
            return false;
        }
    } 

    // -----------------------------------------------------Enemy Damage Calculation--------------------------------------------------------------------------------

    public void CalculateTotalEnemyDamage(BaseAbility usedAbility)
    {
        totalAbilityDamage = (int)CalculateEnemyAbilityDamage(usedAbility);
        totalEnemyDamage = totalAbilityDamage + CalculateEnemyStatusEffectDamage() + CalculateEnemyCriticalStrikeDamage(usedAbility);
        GameInformation.PlayerHealth = GameInformation.PlayerHealth - (int)totalEnemyDamage;

        Debug.Log("Total Enemy damage: " + totalEnemyDamage);
        BattleGUI.enemyDamageValue = EnemyInformation.EnemyName + " dealt " + totalEnemyDamage;
        BattleGUI.isEnemyDamage = true;
        StateMachine.currentState = StateMachine.BattleStates.ENDTURN;

    }

    private float CalculateEnemyAbilityDamage(BaseAbility usedAbility)
    {
        abilityPower = usedAbility.AbilityPower; //retrieves power of move.
        totalAbilityDamage = abilityPower + statCalcScript.FindPlayerClassBonusDamage(EnemyInformation.EnemyClasss); ;
        return totalAbilityDamage;
    }

    private int CalculateEnemyStatusEffectDamage()
    {
        statusEffectDamage = StateMachine.statusEffectBaseDamage * EnemyInformation.EnemyLevel;
        return statusEffectDamage;
    }

    private float CalculateEnemyCriticalStrikeDamage(BaseAbility usedAbility)
    {
        if (DecideIfEnemyAbilityCriticallyHit(usedAbility)) //if the function returns true
        {
            totalCritStrikeDamage = (int)(totalAbilityDamage * 0.25f);
            return totalCritStrikeDamage;
        }
        else
        {
            return totalCritStrikeDamage = 0;
        }
    }

    private bool DecideIfEnemyAbilityCriticallyHit(BaseAbility usedAbility)
    {
        int randomtemp = Random.Range(1, 101);
        int CritChance = (int)(usedAbility.AbilityCritChance + (EnemyInformation.Dexterity * 0.2));
        if (randomtemp <= CritChance)
        {
            Debug.Log("CRIT!");
            return true;
        }
        else
        {
            return false;
        }
    }
}
