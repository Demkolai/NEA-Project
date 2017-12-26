using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RangedAutoAttack : BaseAbility {

    public RangedAutoAttack()
    {
        AbilityName = "Ranged Auto Attack";
        AbilityDescription = "A ranged basic attack that costs no mana";
        AbilityID = 2;
        AbilityPower = 10;
        AbilityCost = 0;
        AbilityStatusEffect = new EmptyStatusEffect();
        AbilityCritChance = 20;
    }

}
