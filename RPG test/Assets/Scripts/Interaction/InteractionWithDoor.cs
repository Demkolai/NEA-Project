using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionWithDoor : Interactable {

    public override void Interact()
    {
        base.Interact();

        SceneManager.LoadScene("Level 2");
    }

}
