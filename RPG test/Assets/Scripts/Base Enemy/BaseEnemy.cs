using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy {

    private string enemyName;
    private int enemyLevel;
    private BaseCharacterClass enemyClass;
    private int stamina;      //health modifier
    private int strength;     //physical damage modifier
    private int intellect;    //magical damage modifier
    private int dexterity;    //haste and crit modifier
    private int charisma;     //buff duration and heal power (for a bard)
    private int wisdom;       //mana regen and mana pool
    private int armor;        //damage reduction

    public string EnemyName { get; set; }
    public int EnemyLevel { get; set; }
    public BaseCharacterClass EnemyClass { get; set; }
    public int Stamina { get; set; }
    public int Strength { get; set; }
    public int Intellect { get; set; }
    public int Dexterity { get; set; }
    public int Charisma { get; set; }
    public int Wisdom { get; set; }
    public int Armor { get; set; }


}
