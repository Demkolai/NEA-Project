using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseStatusEffect  {

    private string statusEffectName;
    private string statusEffectDescription;
    private int statusEffectID;
    private int statusEffectPower;
    private int statusEffectApplyPercentage;
    private int statusEffectMinTurnApplied;
    private int statusEffectMaxTurnApplied;

    public string StatusEffectName { get; set; }
    public string StatusEffectDescription { get; set; }
    public int StatusEffectID { get; set; }
    public int StatusEffectPower { get; set; }
    public int StatusEffectApplyPercentage { get; set; }
    public int StatusEffectMinTurnApplied { get; set; }
    public int StatusEffectMaxTurnApplied { get; set; }

}