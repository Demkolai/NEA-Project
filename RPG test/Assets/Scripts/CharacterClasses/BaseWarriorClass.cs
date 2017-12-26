using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass {

    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A mighty class which excells at close quater combat using sword and shield.";
        Stamina = 13;
        Strength = 15;
        Dexterity = 10;
        Intellect = 8;
        Charisma = 7;
        Wisdom = 6;
        playerAbilities.Add(new AutoAttack());
        playerAbilities.Add(new SwordSlash());
    }

}
