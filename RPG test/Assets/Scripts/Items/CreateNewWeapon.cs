using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour
{

    private BaseWeapon newWeapon;
    private string NameOfWep;

    private void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.Strength.ToString());
        Debug.Log(newWeapon.Stamina.ToString());
        Debug.Log(newWeapon.Dexterity.ToString());
        Debug.Log(newWeapon.Intellect.ToString());
        Debug.Log(newWeapon.Wisdom.ToString());
        Debug.Log(newWeapon.Charisma.ToString());
    }

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();

        //choose type of wep
        ChooseWeaponType();

        //function to assign the name, description and stats based on the enchantment type.
        ChooseWeaponNameAndStats();

        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);

        //spell effect id
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseWeaponNameAndStats()
    {
        int randomNum = Random.Range(1, 4);
        if (randomNum == 1)
        {
            newWeapon.ItemName = NameOfWep + " of the Bear";
            newWeapon.ItemDescription = "A " + NameOfWep + " enchanted with the power of the Bear.";
            newWeapon.Strength = Random.Range(4, 11);
            newWeapon.Stamina = Random.Range(4, 11);
            newWeapon.Dexterity = Random.Range(1, 4);
            newWeapon.Intellect = Random.Range(1, 3);
            newWeapon.Wisdom = Random.Range(1, 3);
            newWeapon.Charisma = Random.Range(1, 4);
        }
        else if (randomNum == 2)
        {
            newWeapon.ItemName = NameOfWep + " of the Cat";
            newWeapon.ItemDescription = "A " + NameOfWep + " enchanted with the power of the Cat.";
            newWeapon.Strength = Random.Range(1, 4);
            newWeapon.Stamina = Random.Range(1, 6);
            newWeapon.Dexterity = Random.Range(4, 11);
            newWeapon.Intellect = Random.Range(1, 3);
            newWeapon.Wisdom = Random.Range(1, 3);
            newWeapon.Charisma = Random.Range(3, 11);
        }
        else if (randomNum == 3)
        {
            newWeapon.ItemName = NameOfWep + " of the Owl";
            newWeapon.ItemDescription = "A " + NameOfWep + " enchanted with the power of the Owl.";
            newWeapon.Strength = Random.Range(1, 3);
            newWeapon.Stamina = Random.Range(1, 6);
            newWeapon.Dexterity = Random.Range(1, 3);
            newWeapon.Intellect = Random.Range(4, 11);
            newWeapon.Wisdom = Random.Range(3, 11);
            newWeapon.Charisma = Random.Range(1, 6);
        }
    }
    private void ChooseWeaponType()
    {

        int randomNum = Random.Range(1, 7);
        if (randomNum == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
            NameOfWep = "Sword";
        }
        else if (randomNum == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
            NameOfWep = "Staff";
        }
        else if (randomNum == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
            NameOfWep = "Dagger";
        }
        else if (randomNum == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
            NameOfWep = "Bow";
        }
        else if (randomNum == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.HARP;
            NameOfWep = "Harp";
        }
        else if (randomNum == 6)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
            NameOfWep = "Shield";
        }

    }
}