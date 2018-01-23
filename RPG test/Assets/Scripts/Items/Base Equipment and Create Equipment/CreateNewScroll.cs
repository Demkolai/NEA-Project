using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewScroll : MonoBehaviour {
    private BaseScroll newScroll;

	// Use this for initialization
	void Start () {
        CreateScroll();
        Debug.Log(newScroll.ItemName);
        Debug.Log(newScroll.ItemDescription);
        Debug.Log(newScroll.ItemID);
        Debug.Log(newScroll.SpellEffectID);
    }

    private void CreateScroll()
    {
        newScroll = new BaseScroll();
        newScroll.ItemName = "Some scroll";
        newScroll.ItemDescription = "A scroll.";
        newScroll.ItemID = Random.Range(1, 101);
        newScroll.SpellEffectID = Random.Range(1, 501);
    }

}
