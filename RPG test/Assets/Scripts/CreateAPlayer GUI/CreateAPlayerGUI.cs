using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAPlayerGUI : MonoBehaviour {

    public enum CreateAPlayerStates
    {
        CLASSSELECTION, //display list of classes
        STATALLOCATION, //allocate bonus stats
        FINALSETUP,     //add name and misc stuff...
    }

    public static CreateAPlayerStates currentState;
    private DisplayCreatePlayerFuntions displayFunctions = new DisplayCreatePlayerFuntions();

	// Use this for initialization
	void Start () {
        currentState = CreateAPlayerStates.CLASSSELECTION;

	}
	
	// Update is called once per frame
	void Update () {

        switch (currentState)
        {
            case (CreateAPlayerStates.CLASSSELECTION):
                break;
            case (CreateAPlayerStates.STATALLOCATION):
                break;
            case (CreateAPlayerStates.FINALSETUP):
                break;
        }

	}

    void OnGUI()
    {
        displayFunctions.DisplayMainItems();
        if(currentState == CreateAPlayerStates.CLASSSELECTION)
        {
            //display selected function
            displayFunctions.DisplayClassSelections();
        }
        if (currentState == CreateAPlayerStates.STATALLOCATION)
        {
            //display selected function
            displayFunctions.DisplayStatAllocation();
        }
        if (currentState == CreateAPlayerStates.FINALSETUP)
        {
            //display selected function
            displayFunctions.DisplayFinalSetup();
        }

    }
}

