using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BleedStatusEffect : BaseStatusEffect { 

    public BleedStatusEffect()
    {
        StatusEffectName = "Bleed";
        StatusEffectDescription = "Creates a wound which bleeds for a number of turns dealing damage.";
        StatusEffectID = 1;
        StatusEffectPower = 5;
        StatusEffectApplyPercentage = 30;
        StatusEffectMinTurnApplied = 1;
        StatusEffectMinTurnApplied = 5;

    }
}
