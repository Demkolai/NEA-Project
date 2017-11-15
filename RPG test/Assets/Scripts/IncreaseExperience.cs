using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience {

    private static float xpToGive;
    private static LevelUp levelUpScript = new LevelUp();

    public static void AddExperienceWin()
    {
        xpToGive = (GameInfromation.PlayerLevel * 2) * 100;
        GameInfromation.CurrentXP += (int) xpToGive;
        CheckIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    public static void AddExperienceLose()
    {
        xpToGive = (GameInfromation.PlayerLevel * 2) * 15;
        GameInfromation.CurrentXP += (int)xpToGive;
        CheckIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    private static void CheckIfPlayerLeveled()
    {
        if (GameInfromation.CurrentXP >= GameInfromation.RequiredXP)
        {
            //player level up
            levelUpScript.LevelUpCharacter();
        }
    }
}
