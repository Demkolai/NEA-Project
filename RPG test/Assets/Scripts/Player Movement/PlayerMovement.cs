using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 15.0f;
    public float rotateSpeed = 5.0f;

	void Start () {
		
	}
	
	void Update () {

        if (Input.GetButton("WAndS"))
        {
            if (Input.GetAxis("WAndS") == 1)
            {
                transform.Translate((Vector3.forward)* moveSpeed * Time.deltaTime);
                //Debug.Log("Pressing w key");
            }
            else if(Input.GetAxis("WAndS") == -1)
            {
                transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
                //Debug.Log("Pressing s key");
            }
          
        }

        if (Input.GetButton("AAndD"))
        {
            if (Input.GetAxis("AAndD") == 1)
            {
                transform.Translate((Vector3.left) * moveSpeed * Time.deltaTime);
                //Debug.Log("Pressing a key");
            }
            else if (Input.GetAxis("AAndD") == -1)
            {
                transform.Translate((Vector3.right) * moveSpeed * Time.deltaTime);
                //Debug.Log("Pressing d key");
            }

        }

        if (Input.GetButton("RotationQE"))
        {
            if (Input.GetAxis("RotationQE") == 1)
            {
                transform.Rotate((Vector3.down) * rotateSpeed);
                //Debug.Log("Pressing q key");
            }
            else if (Input.GetAxis("RotationQE") == -1)
            {
                transform.Rotate((Vector3.up) * rotateSpeed);
                //Debug.Log("Pressing e key");
            }

        }



        //The following if statements are used for sprinting with shift.
        if (Input.GetKey("left shift"))
        {
            moveSpeed = 25.0f;
        }

        if (!Input.GetKey("left shift"))
        {
            moveSpeed = 15.0f;
        }
    }
}
