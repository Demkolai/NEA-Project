using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseItems {

    public enum PotionTypes
    {
        HEALTH,
        MANA,
        STRENGTH,
        INTELLECT,
        DEXTERITY,
        STAMINA,
    }

    private PotionTypes potionType;
    private int spellEffectID;

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
