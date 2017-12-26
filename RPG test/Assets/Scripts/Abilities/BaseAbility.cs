using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseAbility {

    private string abilityName;
    private string abilityDescription;
    private int abilityID;
    private int abilityPower;
    private int abilityCost;
    private BaseStatusEffect abilityStatusEffect;
    //private List<BaseStatusEffect> abilityStatusEffects = new List<BaseStatusEffect>();
    private int abilityCritChance;

    public string AbilityName { get; set; }
    public string AbilityDescription { get; set; }
    public int AbilityID { get; set; }
    public int AbilityPower { get; set; }
    public int AbilityCost { get; set; }
    //public List<BaseStatusEffect> AbilityStatusEffects { get; set; }
    public BaseStatusEffect AbilityStatusEffect { get; set; }
    public int AbilityCritChance { get; set; }
}
