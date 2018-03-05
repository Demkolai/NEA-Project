using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuUI : MonoBehaviour {
	
    public static bool isGamePaused;

    public GameObject PauseMenu;

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

	}

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void SaveGame()
    {
        SaveInformation.SaveAllInfromation();
    }

    public void ReturnToMainMenu()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        SceneManager.LoadScene("Main Menu");
    }
}
