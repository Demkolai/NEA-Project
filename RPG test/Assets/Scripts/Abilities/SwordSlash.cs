using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SwordSlash : BaseAbility {

    public SwordSlash()
    {
        AbilityName = "Sword Slash";
        AbilityDescription = "A swift slash that deals moderate damage and uses mana";
        AbilityID = 3;
        AbilityPower = 15 * GameInformation.PlayerLevel;
        AbilityCost = 30 + (int)(0.3 * GameInformation.PlayerLevel);
        AbilityStatusEffect = new BleedStatusEffect();
        AbilityCritChance = 30;
    }

}
