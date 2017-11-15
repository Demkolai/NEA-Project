using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfromation : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static BaseEquipment EquipmentOne { get; set; }
    public static string PlayerName { get; set; }
    public static string CharacterBio { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Stamina { get; set; }
    public static int Strength { get; set; }
    public static int Intellect { get; set; }
    public static int Dexterity { get; set; }
    public static int Charisma { get; set; }
    public static int Wisdom { get; set; }
    public static int CurrentXP { get; set; }
    public static int RequiredXP { get; set; }
    public static int Armor { get; set; }
    public static int Gold { get; set; }

}
