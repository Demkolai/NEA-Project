using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PowerShot : BaseAbility {

    public PowerShot()
    {
        AbilityName = "Power Shot";
        AbilityDescription = "The archer pulls back the string and releases a powerful shot";
        AbilityID = 5;
        AbilityPower = 20;
        AbilityCost = 5;
        AbilityStatusEffect = new BleedStatusEffect();
        AbilityCritChance = 30;

    }

}
