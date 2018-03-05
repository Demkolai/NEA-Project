using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySwordSlash : BaseAbility {

    public EnemySwordSlash()
    {
        AbilityName = "Sword Slash";
        AbilityDescription = "A swift slash that deals moderate damage and uses mana";
        AbilityID = 3;
        AbilityPower = 15*EnemyInformation.EnemyLevel;
        AbilityCost = 30+(int)(0.3*EnemyInformation.EnemyLevel);
        AbilityStatusEffect = new BleedStatusEffect();
        AbilityCritChance = 30;
    }

}
