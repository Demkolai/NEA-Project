using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStartMenuScript : MonoBehaviour {

    public void LoadLevel1()
    {
        LoadInformation.LoadAllInfromation();
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        LoadInformation.LoadAllInfromation();
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        LoadInformation.LoadAllInfromation();
        SceneManager.LoadScene("Level 3");
    }

    public void LoadCharacterCreation()
    {
        SceneManager.LoadScene("Character Creation");
    }

    public void EndGame()
    {
        Debug.Log("Closing Application.");
        Application.Quit();
    }

}
