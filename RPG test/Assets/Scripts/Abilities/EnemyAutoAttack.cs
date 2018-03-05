using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyAutoAttack : BaseAbility {

    public EnemyAutoAttack()
    {
        AbilityName = "Auto Attack";
        AbilityDescription = "A basic attack that costs no mana";
        AbilityID = 1;
        AbilityPower = 8*EnemyInformation.EnemyLevel;
        AbilityCost = 0;
        AbilityStatusEffect = new EmptyStatusEffect();
        AbilityCritChance = 20;

    }

}
