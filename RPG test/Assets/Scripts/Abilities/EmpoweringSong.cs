using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EmpoweringSong : BaseAbility {

    public EmpoweringSong()
    {
        AbilityName = "Empowering Song";
        AbilityDescription = "The bard sings an empowering song that boosts morale, increasing the strength, dexterity and intellect of his allies";
        AbilityID = 8;
        AbilityPower = 5;
        AbilityStatusEffect = new EmptyStatusEffect();
        AbilityCost = 5;


    }
}
