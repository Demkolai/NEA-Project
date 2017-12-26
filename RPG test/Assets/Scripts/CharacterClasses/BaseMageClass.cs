using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharacterClass {

    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "A powerful wielder of the arcane.";
        Stamina = 11;
        Strength = 8;
        Dexterity = 10;
        Intellect = 15;
        Charisma = 10;
        Wisdom = 13;
        playerAbilities.Add(new RangedAutoAttack());
        playerAbilities.Add(new Fireblast());
    }


}
