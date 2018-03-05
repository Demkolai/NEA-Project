using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Backstab : BaseAbility {

    public Backstab()
    {
        AbilityName = "Backstab";
        AbilityDescription = "The rogue moves behind the target and stabs the target's back";
        AbilityID = 4;
        AbilityPower = 15*GameInformation.PlayerLevel;
        AbilityCost = 30+(int)(0.2*GameInformation.PlayerLevel);
        //AbilityStatusEffects.Add (new BleedStatusEffect());
        AbilityStatusEffect = new BleedStatusEffect();
        AbilityCritChance = 25;
    }

}
