using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRogueClass : BaseCharacterClass {

    public BaseRogueClass()
    {
        CharacterClassName = "Rogue";
        CharacterClassDescription = "An agile swashbuckler which excells at using stealth and speed to take advantage of their opposition.";
        Stamina = 8;
        Strength = 6;
        Dexterity = 15;
        Intellect = 5;
        Charisma = 10;
        Wisdom = 6;
    }

}
