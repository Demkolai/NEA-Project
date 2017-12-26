using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AutoAttack : BaseAbility {

    public AutoAttack()
    {
        AbilityName = "Auto Attack";
        AbilityDescription = "A basic attack that costs no mana";
        AbilityID = 1;
        AbilityPower = 10;
        AbilityCost = 0;
        AbilityStatusEffect = new EmptyStatusEffect();
        AbilityCritChance = 20;

    }

}
