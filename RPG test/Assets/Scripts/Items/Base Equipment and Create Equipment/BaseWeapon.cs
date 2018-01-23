using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseItems {     //BaseWeapon <- BaseStatItem <- BaseItem

    public enum WeaponTypes
    {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        HARP,
        SHIELD
    }

    private WeaponTypes weaponType;
    private int spellEffectID;

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
