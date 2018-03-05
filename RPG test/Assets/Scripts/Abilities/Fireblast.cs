using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Fireblast : BaseAbility {

    public Fireblast()
    {
        AbilityName = "Fireblast";
        AbilityDescription = "The mage casts a powerful fireblast at the target";
        AbilityID = 6;
        AbilityPower = 15 * GameInformation.PlayerLevel;
        AbilityCost = 30 + (int)(0.5 * GameInformation.PlayerLevel);
        AbilityStatusEffect = new BurnStatusEffect();
        AbilityCritChance = 30;

    }
}
