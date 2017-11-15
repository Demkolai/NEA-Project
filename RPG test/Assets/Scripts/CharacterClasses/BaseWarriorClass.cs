using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass {

    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A strong and mighty hero.";
        Stamina = 13;
        Strength = 15;
        Dexterity = 10;
        Intellect = 8;
        Charisma = 7;
        Wisdom = 6;
    }

}
