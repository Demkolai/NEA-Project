using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbilityChoice {

    private BaseAbility enemyUsedAbility;
    private BattleStateStart battleStateStartScript;
    private BaseAbility SwordSlashManaCost = new SwordSlash();

    public BaseAbility ChooseEnemyAbility()
    {
        int temp = Random.Range(1, 21);
        if (temp < 11)
        {
            enemyUsedAbility = new AutoAttack(); //or battleStateStartScript.newEnemy.AbilityOne
            return enemyUsedAbility;
        }
        else if (temp > 11)
        {
            if(battleStateStartScript.newEnemy.Mana >= SwordSlashManaCost.AbilityCost) //battleStateStartScript.newEnemy.AbilityTwo.AbilityCost doesnt work
            {
                enemyUsedAbility = new SwordSlash(); //or battleStateStartScript.newEnemy.AbilityTwo;
                return enemyUsedAbility;
            }
            else
            {
                enemyUsedAbility = new AutoAttack(); //or battleStateStartScript.newEnemy.AbilityOne;
                return enemyUsedAbility;
            }
        }
        return null;
    }

}