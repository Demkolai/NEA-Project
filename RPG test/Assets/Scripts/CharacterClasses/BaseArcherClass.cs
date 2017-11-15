using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArcherClass : BaseCharacterClass {

    public BaseArcherClass()
    {
        CharacterClassName = "Archer";
        CharacterClassDescription = "A stealthy bow wielding marksman that takes down foes from a distance.";
        Stamina = 8;
        Strength = 5;
        Dexterity = 15;
        Intellect = 6;
        Charisma = 9;
        Wisdom = 6;
    }

}
