using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItems {

    private string itemName;
    private string itemDescription;
    private int itemID;
    private int stamina;
    private int strength;
    private int intellect;
    private int dexterity;
    private int charisma;
    private int wisdom;


    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION

    }
    private ItemTypes itemType;

    public BaseItems(Dictionary<string, string> itemsDictionary){
        ItemName = itemsDictionary["ItemName"];
        ItemDescription = itemsDictionary["ItemDescription"];
        ItemID = int.Parse(itemsDictionary["ItemID"]);
        itemType = (ItemTypes)System.Enum.Parse (typeof(BaseItems.ItemTypes), itemsDictionary["ItemType"].ToString());
    }

    public BaseItems() { }


    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public ItemTypes Itemtype
    {
        get { return itemType; }
        set { itemType = value; }
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
