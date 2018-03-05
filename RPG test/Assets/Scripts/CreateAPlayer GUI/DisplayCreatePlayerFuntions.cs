using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayCreatePlayerFuntions {

    private StatAllocationModule statAllocationModule = new StatAllocationModule();

    private int classSelection;
    private string[] classSelectionNames = new string[] { "Warrior", "Mage", "Rogue", "Archer" };
    private string playerFirstName = "Enter Name";
    private string playerLastName = "Enter Name";
    private string characterBio = "Enter description";

    public void DisplayClassSelections()
    {
        //The first step of creating a character, Selecting the class.
        classSelection = GUI.SelectionGrid(new Rect(50, 50, 250, 300), classSelection, classSelectionNames , 2);
        GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
        GUI.Label(new Rect(450, 125, 300, 300), FindClassStats(classSelection));
    }

    private string FindClassDescription(int classSelection)
    {
        //fucntion to show description of class.
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 2)
        {
            BaseCharacterClass tempClass = new BaseRogueClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 3)
        {
            BaseCharacterClass tempClass = new BaseArcherClass();
            return tempClass.CharacterClassDescription;
        }
        return "No class found";
    }

    private string FindClassStats(int classSelection)
    {
        //function to show stats of class chosen
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            string tempStats = "Stamina: " + tempClass.Stamina + "\n" + "Strength: " + tempClass.Strength + "\n" + "Intellect: " + tempClass.Intellect + "\n" + "Dexterity: " + tempClass.Dexterity + "\n" + "Charisma: " + tempClass.Charisma + "\n" + "Wisdom: " + tempClass.Wisdom;
            return tempStats;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            string tempStats = "Stamina: " + tempClass.Stamina + "\n" + "Strength: " + tempClass.Strength + "\n" + "Intellect: " + tempClass.Intellect + "\n" + "Dexterity: " + tempClass.Dexterity + "\n" + "Charisma: " + tempClass.Charisma + "\n" + "Wisdom: " + tempClass.Wisdom;
            return tempStats;
        }
        else if (classSelection == 2)
        {
            BaseCharacterClass tempClass = new BaseRogueClass();
            string tempStats = "Stamina: " + tempClass.Stamina + "\n" + "Strength: " + tempClass.Strength + "\n" + "Intellect: " + tempClass.Intellect + "\n" + "Dexterity: " + tempClass.Dexterity + "\n" + "Charisma: " + tempClass.Charisma + "\n" + "Wisdom: " + tempClass.Wisdom;
            return tempStats;
        }
        else if (classSelection == 3)
        {
            BaseCharacterClass tempClass = new BaseArcherClass();
            string tempStats = "Stamina: " + tempClass.Stamina + "\n" + "Strength: " + tempClass.Strength + "\n" + "Intellect: " + tempClass.Intellect + "\n" + "Dexterity: " + tempClass.Dexterity + "\n" + "Charisma: " + tempClass.Charisma + "\n" + "Wisdom: " + tempClass.Wisdom;
            return tempStats;
        }

        return "No stats found";
    }

    public void DisplayStatAllocation()
    {
        //second stage of character creation, selecting the desired stats.
        statAllocationModule.DisplayStatAllocationModule();
    }

    public void DisplayFinalSetup()
    {
        //name
        GUI.Label(new Rect(20, 55, 100, 50), "First Name:");
        playerFirstName = GUI.TextArea(new Rect(20, 75, 150, 25), playerFirstName, 25);
        GUI.Label(new Rect(20, 110, 100, 50), "Last Name:");
        playerLastName = GUI.TextArea(new Rect(20, 130, 150, 25), playerLastName, 25);

        //character bio
        GUI.Label(new Rect(20, 200, 100, 50), "Character Bio:");
        characterBio = GUI.TextArea(new Rect(20, 220, 300, 375), characterBio, 1000);

    }

    private void ChooseClass(int classSelection) //error here where it doesnt find the class in other scripts, more specifically the combat phase.
    {
        //class selection based on which block is chosen from the 5 available buttons.
        if (classSelection == 0)
        {
            GameInformation.PlayerClass = new BaseWarriorClass();
            GameInformation.PlayerClasss = "Warrior";
            GameInformation.PlayerMoveOne = new AutoAttack();
            GameInformation.PlayerMoveTwo = new SwordSlash();
        }
        else if (classSelection == 1)
        {
            GameInformation.PlayerClass = new BaseMageClass();
            GameInformation.PlayerClasss = "Mage";
            GameInformation.PlayerMoveOne = new RangedAutoAttack();
            GameInformation.PlayerMoveTwo = new Fireblast();
        }
        else if (classSelection == 2)
        {
            GameInformation.PlayerClass = new BaseRogueClass();
            GameInformation.PlayerClasss = "Rogue";
            GameInformation.PlayerMoveOne = new AutoAttack();
            GameInformation.PlayerMoveTwo = new Backstab();
        }
        else if (classSelection == 3)
        {
            GameInformation.PlayerClass = new BaseArcherClass();
            GameInformation.PlayerClasss = "Archer";
            GameInformation.PlayerMoveOne = new RangedAutoAttack();
            GameInformation.PlayerMoveTwo = new PowerShot();
        }
    }

    public void DisplayMainItems()
    {
        //rotate character model
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        GUI.Label(new Rect((Screen.width / 7) * 3, 20, 250, 250), "Create New Player");

        if (GUI.RepeatButton(new Rect(375, 540, 50, 50), "<<<"))
        {
            player.Rotate(Vector3.up);
        }
        if (GUI.RepeatButton(new Rect(575, 540, 50, 50), ">>>"))
        {
            player.Rotate(Vector3.down);
        }


        //button to go next in character creation.
        if (CreateAPlayerGUI.currentState != CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP)
        {
            if (GUI.Button(new Rect(750, 550, 50, 50), "Next"))
            {
                if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION)
                {
                    ChooseClass(classSelection);

                    CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
                }
                else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION)
                {
                    GameInformation.Stamina = statAllocationModule.pointsToAllocate[0];
                    GameInformation.Strength = statAllocationModule.pointsToAllocate[1];
                    GameInformation.Intellect = statAllocationModule.pointsToAllocate[2];
                    GameInformation.Dexterity = statAllocationModule.pointsToAllocate[3];
                    GameInformation.Charisma = statAllocationModule.pointsToAllocate[4];
                    GameInformation.Wisdom = statAllocationModule.pointsToAllocate[5];
                    CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP;
                }

            }
        }

        else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP)
        {
            if (GUI.Button(new Rect(750, 550, 50, 50), "Finish"))
            {
                //Final save here.

                GameInformation.PlayerName = playerFirstName + " " + playerLastName;
                GameInformation.CharacterBio = characterBio;
                GameInformation.PlayerLevel = 1;
                GameInformation.Gold = 100;
                GameInformation.Armor = 10;

                SaveInformation.SaveAllInfromation();
                Debug.Log("Final Save Complete");
                SceneManager.LoadScene("Level 1");
            }
        }


        //button to go back in character creation
        if (GUI.Button(new Rect(680, 550, 50, 50), "Back"))
        {
            if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP)
            {
                CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
            }
            if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION)
            {
                statAllocationModule.didRunOnce = false;
                statAllocationModule.availablePoints = 5;
                CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION;
            }
            else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION)
            {
                SceneManager.LoadScene("Main Menu");
            }

        }

    }

}
