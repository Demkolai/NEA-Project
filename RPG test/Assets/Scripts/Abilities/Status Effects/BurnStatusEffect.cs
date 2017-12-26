using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BurnStatusEffect : BaseStatusEffect {

    public BurnStatusEffect()
    {
        StatusEffectName = "Burn";
        StatusEffectDescription = "Burns an enemy for a number of turns";
        StatusEffectID = 1;
        StatusEffectPower = 5;
        StatusEffectApplyPercentage = 75; //75% chance of being applied
        StatusEffectMinTurnApplied = 1;
        StatusEffectMinTurnApplied = 5;

    }

}
