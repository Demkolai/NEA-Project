using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int stamina;      //health modifier
    private int strength;     //physical damage modifier
    private int intellect;    //magical damage modifier
    private int dexterity;    //haste and crit modifier
    private int charisma;     //buff duration and heal power (for a bard)
    private int wisdom;       //mana regen and mana pool
    private int armor;        //damage reduction

    private int gold;         //in game currency

    private int currentXP;
    private int requiredXP;
    private int statPointsToAllocate;

    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }
    public int StatPointsToAllocate { get; set; }

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }
    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
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
    public int Armor
    {
        get { return armor; }
        set { armor = value; }
    }
    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }
}
