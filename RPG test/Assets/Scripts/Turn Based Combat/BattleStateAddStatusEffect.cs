using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateAddStatusEffect {

    public void CheckAbilityForStatusEffects(BaseAbility usedAbility)
    {
        switch (usedAbility.AbilityStatusEffect.StatusEffectName)
        {
            case ("Bleed"):
                if (TryToApplyStatusEffect(usedAbility))
                {
                    Debug.Log("target is bleeding!");
                    StateMachine.statusEffectBaseDamage = usedAbility.AbilityStatusEffect.StatusEffectPower;
                }
                else
                {
                    StateMachine.statusEffectBaseDamage = 0;
                }
                StateMachine.currentState = StateMachine.BattleStates.CALCULATEDAMAGE;
                break;

            case ("Burn"):
                if (TryToApplyStatusEffect(usedAbility))
                {
                    StateMachine.statusEffectBaseDamage = usedAbility.AbilityStatusEffect.StatusEffectPower;
                }
                else
                {
                    StateMachine.statusEffectBaseDamage = 0;
                }
                StateMachine.currentState = StateMachine.BattleStates.CALCULATEDAMAGE;
                break;

            case (null):
                StateMachine.currentState = StateMachine.BattleStates.CALCULATEDAMAGE;
                break;

            default:
                Debug.LogError("Error in Status effect");
                break;
        }
    }

    private bool TryToApplyStatusEffect(BaseAbility usedAbility)
    {
        //looks at % chance of status effect applying rate. Apply the status effect if the chance is hit etc...
        int randomTemp = Random.Range(1, 101);
        Debug.Log(randomTemp);
        if(randomTemp <= usedAbility.AbilityStatusEffect.StatusEffectApplyPercentage)
        {
            return true;
        }
        return false;
    }

}
