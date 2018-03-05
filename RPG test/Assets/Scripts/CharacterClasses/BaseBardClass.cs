using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBardClass : BaseCharacterClass {

    public BaseBardClass()
    {
        CharacterClassName = "Bard";
        CharacterClassDescription = "A master of the harp which excells at increasing the morale of his team.";
        Stamina = 7;
        Strength = 5;
        Dexterity = 7;
        Intellect = 9;
        Charisma = 15;
        Wisdom = 9;
    }

}
