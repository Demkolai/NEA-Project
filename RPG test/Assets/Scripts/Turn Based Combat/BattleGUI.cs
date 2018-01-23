using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleGUI : MonoBehaviour {

    private Text playerName;
    private Text playerHealth;
    public Slider playerHealthImage;
    private Text playerMana;
    public Slider playerManaImage;
    private Text playerLevel;

    private Text enemyName;
    private Text enemyHealth;
    public Slider enemyHealthImage;
    private Text enemyMana;
    public Slider enemyManaImage;
    private Text enemyLevel;

    private Text Attack1;
    private Text Attack1Description;
    private Text Attack2;
    private Text Attack2Description;
    private Text Attack2ManaCost;
    private Text Attack2StatusEffect;

    private Text AmountOfXPDefeat;
    private Text AmountOfXPVictory;

    private Text DamageLogText1;
    private Text DamageLogText2;
    private Text DamageLogText3;
    private Text DamageLogText4;
    private Text DamageLogText5;
    private Text DamageLogText6;

    public LogQueue damageLogQueue = new LogQueue();
    public static string playerDamageValue;
    public static bool isPlayerDamage;
    public static string enemyDamageValue;
    public static bool isEnemyDamage;

    // Use this for initialization
    void Start () {
        playerName = transform.Find("PlayerInfoContainer").Find("PlayerPortrait").Find("PlayerName").GetComponent<Text>();
        playerHealth = transform.Find("PlayerInfoContainer").Find("PlayerHealthBar").Find("PlayerHealthValue").GetComponent<Text>();
        playerLevel = transform.Find("PlayerInfoContainer").Find("PlayerPortrait").Find("PlayerLevel").GetComponent<Text>();
        playerMana = transform.Find("PlayerInfoContainer").Find("PlayerManaBar").Find("PlayerManaValue").GetComponent<Text>();

        enemyName = transform.Find("EnemyInfoContainer").Find("EnemyPortrait").Find("EnemyName").GetComponent<Text>();
        enemyHealth = transform.Find("EnemyInfoContainer").Find("EnemyHealthBar").Find("EnemyHealthValue").GetComponent<Text>();
        enemyLevel = transform.Find("EnemyInfoContainer").Find("EnemyPortrait").Find("EnemyLevel").GetComponent<Text>();
        enemyMana = transform.Find("EnemyInfoContainer").Find("EnemyManaBar").Find("EnemyManaValue").GetComponent<Text>();

        FindDamageLogTextLocation();
    }
	
	// Update is called once per frame
	void Update () {
        playerName.text = GameInformation.PlayerName;
        playerHealth.text = GameInformation.PlayerHealth.ToString();
        playerHealthImage.value = GameInformation.PlayerHealth / GameInformation.MaxPlayerHealth;
        playerLevel.text = GameInformation.PlayerLevel.ToString();
        playerMana.text = GameInformation.PlayerMana.ToString();
        playerManaImage.value = GameInformation.PlayerMana / GameInformation.MaxPlayerMana;

        enemyName.text = EnemyInformation.EnemyName;
        enemyHealth.text = EnemyInformation.Health.ToString();
        enemyHealthImage.value = EnemyInformation.Health / EnemyInformation.MaxHealth;
        enemyLevel.text = EnemyInformation.EnemyLevel.ToString();
        enemyMana.text = EnemyInformation.Mana.ToString();
        enemyManaImage.value = EnemyInformation.Mana / EnemyInformation.MaxMana;


        if (StateMachine.currentState == StateMachine.BattleStates.LOSE)
        {
            CalculateHowMuchXP();
        }
        else if (StateMachine.currentState == StateMachine.BattleStates.WIN)
        {
            CalculateHowMuchXP();
        }

        DamageLogText1.text = damageLogQueue.queueArray[0];
        DamageLogText2.text = damageLogQueue.queueArray[1];
        DamageLogText3.text = damageLogQueue.queueArray[2];
        DamageLogText4.text = damageLogQueue.queueArray[3];
        DamageLogText5.text = damageLogQueue.queueArray[4];
        DamageLogText6.text = damageLogQueue.queueArray[5];

        if (isPlayerDamage == true)
        {
            Debug.Log(damageLogQueue.front);
            Debug.Log(damageLogQueue.rear);
            damageLogQueue.Enqueue(playerDamageValue);
            isPlayerDamage = false;
        }
        else if (isEnemyDamage == true)
        {
            Debug.Log(damageLogQueue.front);
            Debug.Log(damageLogQueue.rear);
            damageLogQueue.Enqueue(enemyDamageValue);
            isEnemyDamage = false;
        }

        if (damageLogQueue.rear == 5)
        {
            InvokeRepeating("DequeueFuncion", 0.5f , 6);
        }

    }

    public void DequeueFuncion()
    {
        damageLogQueue.Dequeue();
    }

    public void AbilityOne()
    {
        StateMachine.playerUsedAbility = GameInformation.PlayerMoveOne;
        StateMachine.currentState = StateMachine.BattleStates.ADDSTATUSEFFECTS;
    }

    public void AbilityTwo()
    {
        StateMachine.playerUsedAbility = GameInformation.PlayerMoveTwo;
        GameInformation.PlayerMana = GameInformation.PlayerMana - GameInformation.PlayerMoveTwo.AbilityCost;
        StateMachine.currentState = StateMachine.BattleStates.ADDSTATUSEFFECTS;
    }

    public void SkipTurn()
    {
        StateMachine.currentState = StateMachine.BattleStates.ENEMYCHOICE;
    }

    public void DisplayAbilityOne()
    {
        Attack1 = transform.Find("AttackSelectionMenu").Find("Attack1").Find("Text").GetComponent<Text>();
        Attack1.text = GameInformation.PlayerMoveOne.AbilityName;
        Attack1Description = transform.Find("AttackSelectionMenu").Find("Attack1PopUPInfo").Find("DescriptionOfMove").GetComponent<Text>();
        Attack1Description.text = GameInformation.PlayerMoveOne.AbilityDescription;
    }

    public void DisplayAbilityTwo()
    {
        Attack2 = transform.Find("AttackSelectionMenu").Find("Attack2").Find("Text").GetComponent<Text>();
        Attack2.text = GameInformation.PlayerMoveTwo.AbilityName;

        Attack2Description = transform.Find("AttackSelectionMenu").Find("Attack2PopUPInfo").Find("DescriptionOfMove").GetComponent<Text>();
        Attack2Description.text = GameInformation.PlayerMoveTwo.AbilityDescription;
        Attack2ManaCost = transform.Find("AttackSelectionMenu").Find("Attack2PopUPInfo").Find("ManaCost").GetComponent<Text>();
        Attack2ManaCost.text = "This ability costs " + (GameInformation.PlayerMoveTwo.AbilityCost.ToString()) + " mana";
        Attack2StatusEffect = transform.Find("AttackSelectionMenu").Find("Attack2PopUPInfo").Find("StatusEffect").GetComponent<Text>();
        Attack2StatusEffect.text = "This ability has a chance to apply " + GameInformation.PlayerMoveTwo.AbilityStatusEffect.StatusEffectName;
    }

    public void CalculateHowMuchXP()
    {
        AmountOfXPDefeat = transform.Find("DeathScreen").Find("XPText").GetComponent<Text>();
        AmountOfXPDefeat.text = "You have gained " + IncreaseExperience.xpToGive + " xp.";
        AmountOfXPDefeat = transform.Find("VictoryScreen").Find("XPText").GetComponent<Text>();
        AmountOfXPDefeat.text = "You have gained " + IncreaseExperience.xpToGive + " xp.";

    }

    public void FindDamageLogTextLocation()
    {
        DamageLogText1 = transform.Find("DamageLog").Find("DamageText1").GetComponent<Text>();
        DamageLogText2 = transform.Find("DamageLog").Find("DamageText2").GetComponent<Text>();
        DamageLogText3 = transform.Find("DamageLog").Find("DamageText3").GetComponent<Text>();
        DamageLogText4 = transform.Find("DamageLog").Find("DamageText4").GetComponent<Text>();
        DamageLogText5 = transform.Find("DamageLog").Find("DamageText5").GetComponent<Text>();
        DamageLogText6 = transform.Find("DamageLog").Find("DamageText6").GetComponent<Text>();
    }

    public void ReturnToPreviousScene()
    {
        string sceneName = PlayerPrefs.GetString("lastLoadedScene");
        SceneManager.LoadScene(sceneName);//back to previous scene
    }
    
}
