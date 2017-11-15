using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp {

    public int maxPlayerLevel = 50;

    public void LevelUpCharacter()
    {

        //check to see if currentxp > requiredxp and carry over xp when leveled up.
        if(GameInfromation.CurrentXP > GameInfromation.RequiredXP)
        {
            GameInfromation.CurrentXP -= GameInfromation.RequiredXP;
        }
        else
        {
            GameInfromation.CurrentXP = 0;
        }



        //add to player level
        if(GameInfromation.PlayerLevel < maxPlayerLevel)
        {
            GameInfromation.PlayerLevel += 1;
        }
        else
        {
            GameInfromation.PlayerLevel = maxPlayerLevel;
        }



        //give stat points



        //determine next amount of required xp
        DetermineRequiredXP();


    }

    private void DetermineRequiredXP()
    {
        //Quadratic used for xp curve is    x^2 + x + 1
        float temp = (GameInfromation.PlayerLevel ^ 2 + GameInfromation.PlayerLevel + 1) * 100;
        GameInfromation.RequiredXP = (int) temp;
    }


}
