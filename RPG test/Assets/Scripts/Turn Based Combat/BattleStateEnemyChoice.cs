using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateEnemyChoice {

    private EnemyAbilityChoice enemyAbilityChoiceScript = new EnemyAbilityChoice();

    public void EnemyCompleteTurn()
    {
        //choose ability
        StateMachine.enemyUsedAbility = enemyAbilityChoiceScript.ChooseEnemyAbility();
        Debug.Log("Enemy Choice: " + StateMachine.enemyUsedAbility);
        //calculate damage
        StateMachine.currentState = StateMachine.BattleStates.CALCULATEDAMAGE;
    }

}
