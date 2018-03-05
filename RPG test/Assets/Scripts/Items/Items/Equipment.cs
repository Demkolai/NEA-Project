using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Equipment", menuName ="Inventory/Equipment")]
public class Equipment : Item {

    public EquipmentSlot equipSlot;

    public int Armour;
    public int Stamina;
    public int Strength;
    public int Dexterity;
    public int Intellect;
    public int Wisdom;

    public override void Use()
    {
        base.Use();
        EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }
}

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet }