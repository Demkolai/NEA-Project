using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp {

    public int maxPlayerLevel = 50;

    public void LevelUpCharacter()
    {

        //check to see if currentxp > requiredxp and carry over xp when leveled up.
        if(GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }



        //add to player level
        if(GameInformation.PlayerLevel < maxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }



        //give stat points



        //determine next amount of required xp
        DetermineRequiredXP();


    }

    private void DetermineRequiredXP()
    {
        //Quadratic used for xp curve is    x^2 + x + 1
        float temp = (GameInformation.PlayerLevel ^ 2 + GameInformation.PlayerLevel + 1) * 100;
        GameInformation.RequiredXP = (int) temp;
    }


}
