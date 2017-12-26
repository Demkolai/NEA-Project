using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HealingSong : BaseAbility {

    public HealingSong()
    {
        AbilityName = "Healing Song";
        AbilityDescription = "The bard sings a song that heals nearby allies";
        AbilityID = 7;
        AbilityPower = 20;
        AbilityStatusEffect = new EmptyStatusEffect();
        AbilityCost = 5;

    }
}
