using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour
{

    private BaseEquipment newEquipment;
    private string NameOfEquipment;

    // Use this for initialization
    void Start()
    {
        CreateEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.Strength.ToString());
        Debug.Log(newEquipment.Stamina.ToString());
        Debug.Log(newEquipment.Dexterity.ToString());
        Debug.Log(newEquipment.Intellect.ToString());
        Debug.Log(newEquipment.Wisdom.ToString());
        Debug.Log(newEquipment.Charisma.ToString());
    }

    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();

        //choose type of equipment
        ChooseEquipmentType();

        //function to assign the name, description and stats based on the enchantment type.
        ChooseEquipmentNameAndStats();

        //equipment id
        newEquipment.ItemID = Random.Range(1, 101);

        //spell effect id
        newEquipment.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseEquipmentNameAndStats()
    {
        int randomNum = Random.Range(1, 4);
        if (randomNum == 1)
        {
            newEquipment.ItemName = NameOfEquipment + " of the Bear";
            newEquipment.ItemDescription = "A " + NameOfEquipment + " piece enchanted with the power of the Bear.";
            newEquipment.Strength = Random.Range(4, 11);
            newEquipment.Stamina = Random.Range(4, 11);
            newEquipment.Dexterity = Random.Range(1, 4);
            newEquipment.Intellect = Random.Range(1, 3);
            newEquipment.Wisdom = Random.Range(1, 3);
            newEquipment.Charisma = Random.Range(1, 4);
        }
        else if (randomNum == 2)
        {
            newEquipment.ItemName = NameOfEquipment + " of the Cat";
            newEquipment.ItemDescription = "A " + NameOfEquipment + " piece enchanted with the power of the Cat.";
            newEquipment.Strength = Random.Range(1, 4);
            newEquipment.Stamina = Random.Range(1, 6);
            newEquipment.Dexterity = Random.Range(4, 11);
            newEquipment.Intellect = Random.Range(1, 3);
            newEquipment.Wisdom = Random.Range(1, 3);
            newEquipment.Charisma = Random.Range(3, 11);
        }
        else if (randomNum == 3)
        {
            newEquipment.ItemName = NameOfEquipment + " of the Owl";
            newEquipment.ItemDescription = "A " + NameOfEquipment + " piece enchanted with the power of the Owl.";
            newEquipment.Strength = Random.Range(1, 3);
            newEquipment.Stamina = Random.Range(1, 6);
            newEquipment.Dexterity = Random.Range(1, 3);
            newEquipment.Intellect = Random.Range(4, 11);
            newEquipment.Wisdom = Random.Range(3, 11);
            newEquipment.Charisma = Random.Range(1, 6);
        }
    }

    private void ChooseEquipmentType()
    {
        int randomNum = Random.Range(1, 9);
        if (randomNum == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
            NameOfEquipment = "Head";
        }
        else if (randomNum == 2)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
            NameOfEquipment = "Chest";
        }
        else if (randomNum == 3)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
            NameOfEquipment = "Shoulders";
        }
        else if (randomNum == 4)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
            NameOfEquipment = "Legs";
        }
        else if (randomNum == 5)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
            NameOfEquipment = "Feet";
        }
        else if (randomNum == 6)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HANDS;
            NameOfEquipment = "Hands";
        }
        else if (randomNum == 7)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
            NameOfEquipment = "Neck";
        }
        else if (randomNum == 8)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
            NameOfEquipment = "Ring";
        }
    }
}
