using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {

    private string characterClassName;
    private string characterClassDescription;
    //Stats
    private int stamina;
    private int strength;
    private int intellect;
    private int dexterity;
    private int charisma;
    private int wisdom;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }
    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }

    public int Wisdom
    {
        get { return wisdom; }
        set { wisdom = value; }
    }

}
