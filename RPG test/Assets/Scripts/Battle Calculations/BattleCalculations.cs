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
    private int totalCritStrikeDamage;

    public void CalculateTotalPlayerDamage(BaseAbility usedAbility)
    {
        //Debug.Log("Used Ability: " + usedAbility);
        totalAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
        //Debug.Log(totalAbilityDamage);
        totalPlayerDamage = totalAbilityDamage + CalculateStatusEffectDamage() + CalculateCriticalStrikeDamage(usedAbility);
        StateMachine.currentState = StateMachine.BattleStates.ENEMYCHOICE;
        Debug.Log("Total player damage: " + totalPlayerDamage);
    }

    public void CalculateUsedPlayerAbilityDamage(BaseAbility usedAbility)
    {

        // move damage + critical strike - armor + weapon damage + stat modifier.
        //use an ability
        //calculate damage
        //check status effect
        //if the move adds a status effect
        //try to add it.
        //if effect is added, then apply damage from effect.
        //calculate total damage with status effect in mind.
    }

    private float CalculateAbilityDamage(BaseAbility usedAbility)
    {
        abilityPower = usedAbility.AbilityPower; //retrieves power of move.
        totalAbilityDamage = abilityPower + statCalcScript.FindPlayerClassBonusDamage(GameInformation.PlayerClasss); ;
        return totalAbilityDamage;
    }

    private int CalculateStatusEffectDamage()
    {
        statusEffectDamage = StateMachine.statusEffectBaseDamage * GameInformation.PlayerLevel;
        return statusEffectDamage;
    }

    private float CalculateCriticalStrikeDamage (BaseAbility usedAbility)
    {
        if (DecideIfAbilityCriticallyHit(usedAbility)) //if the function returns true
        {
            totalCritStrikeDamage = (int)(totalAbilityDamage * 0.25f);
            return totalCritStrikeDamage;
        }
        else
        {
            return totalCritStrikeDamage = 0;
        }
    }

    private bool DecideIfAbilityCriticallyHit(BaseAbility usedAbility)
    {
        int randomtemp = Random.Range(1, 101);
        int CritChance = (int)(usedAbility.AbilityCritChance + (GameInformation.Dexterity * 0.2));
        if(randomtemp <= CritChance)
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
