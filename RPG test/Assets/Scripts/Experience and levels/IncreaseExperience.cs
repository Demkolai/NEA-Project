using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience {

    private static float xpToGive;
    private static LevelUp levelUpScript = new LevelUp();

    public static void AddExperienceWin()
    {
        xpToGive = (GameInformation.PlayerLevel * 2) * 100;
        GameInformation.CurrentXP += (int) xpToGive;
        CheckIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    public static void AddExperienceLose()
    {
        xpToGive = (GameInformation.PlayerLevel * 2) * 15;
        GameInformation.CurrentXP += (int)xpToGive;
        CheckIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    private static void CheckIfPlayerLeveled()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            //player level up
            levelUpScript.LevelUpCharacter();
        }
    }
}
