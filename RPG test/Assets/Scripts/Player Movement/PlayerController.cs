using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotateSpeed;
    public float forwardSpeed;
    private CharacterController playerController;

	// Use this for initialization
	void Start () {

        playerController = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

        if ( Input.GetKeyDown("space") && playerController.isGrounded )
        {
            playerController.Move(Vector3.up);
        }

        transform.Rotate(0, Input.GetAxis("RotationQE") * rotateSpeed, 0); //vector3 = (0,0,0) = (x,y,z)
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 horizontal = transform.TransformDirection(Vector3.right);
        float FSpeed = forwardSpeed * Input.GetAxis("WAndS");
        float HSpeed = forwardSpeed * Input.GetAxis("AAndD");
        playerController.SimpleMove(FSpeed * forward);
        playerController.SimpleMove(HSpeed * horizontal);

	}
}
