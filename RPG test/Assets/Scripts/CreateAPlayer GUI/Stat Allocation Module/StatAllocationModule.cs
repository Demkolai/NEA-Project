using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule {

    private string[] statNames = new string[6] { "Stamina", "Strength", "Intellect","Dexterity","Charisma","Wisdom" };
    private string[] statDesc = new string[6] { "Health modifier", "Physical Damage modifier", "Magic Damage modifier", "Speed and Critical strike modifier", "Effectiveness of buffs", "Mana and Mana regen modifier" };
    private bool[] statSelections = new bool[6];

    public int[] pointsToAllocate = new int[6]; //how many points to allocate
    private int[] baseStatPoints = new int[6]; //starting stat values

    public int availablePoints = 5;
    public bool didRunOnce = false;

    public void DisplayStatAllocationModule()
    {
        if (!didRunOnce)
        {
            RetrieveBaseStatPoints();
            didRunOnce = true;
        }

        DisplayStatToggleSwitches();
        DisplayStatManagementButtons();
    }

    private void DisplayStatToggleSwitches()
    {
        for (int i = 0; i < statNames.Length; i++)
        {
            statSelections[i] = GUI.Toggle(new Rect(10, 60 * i + 30, 100, 50), statSelections[i], statNames[i]);
            GUI.Label(new Rect(235, 60 * i + 30, 30, 30), pointsToAllocate[i].ToString());
            if (statSelections[i])
            {
                GUI.Label(new Rect(20, 60 * i + 50, 150, 100), statDesc[i]);
            }
        }
    }


    private void DisplayStatManagementButtons()
    {
        GUI.Label(new Rect(180, 375, 150, 50), "Available points: " + availablePoints);

        for(int i = 0; i < pointsToAllocate.Length; i++)
        {
            if (availablePoints > 0)
            {
                if (GUI.Button(new Rect(260, 60 * i + 30, 25, 25), "+"))
                {
                    pointsToAllocate[i] += 1;
                    --availablePoints;
                }
            }

            if (pointsToAllocate[i] > 5)
            {
                if (GUI.Button(new Rect(200, 60 * i + 30, 25, 25), "-"))
                {
                    pointsToAllocate[i] -= 1;
                    ++availablePoints;
                }
            }

        }
    }


    private void RetrieveBaseStatPoints()
    {
        BaseCharacterClass cClass = GameInfromation.PlayerClass;

        pointsToAllocate[0] = cClass.Stamina;
        baseStatPoints[0] = cClass.Stamina;

        pointsToAllocate[1] = cClass.Strength;
        baseStatPoints[1] = cClass.Strength;

        pointsToAllocate[2] = cClass.Intellect;
        baseStatPoints[2] = cClass.Intellect;

        pointsToAllocate[3] = cClass.Dexterity;
        baseStatPoints[3] = cClass.Dexterity;

        pointsToAllocate[4] = cClass.Charisma;
        baseStatPoints[4] = cClass.Charisma;

        pointsToAllocate[5] = cClass.Wisdom;
        baseStatPoints[5] = cClass.Wisdom;
    }

}
