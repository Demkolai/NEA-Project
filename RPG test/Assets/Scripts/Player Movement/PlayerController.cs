using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {

    public float rotateSpeed;
    public float forwardSpeed;
    private CharacterController playerController;

    Camera cam;

    public Interactable focus;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        playerController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if ( Input.GetKeyDown("space") && playerController.isGrounded )
        {
            playerController.Move(Vector3.up);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable!= null)
                {
                    SetFocus(interactable);
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    RemoveFocus();
                }
            }
        }


        transform.Rotate(0, Input.GetAxis("RotationQE") * rotateSpeed, 0); //vector3 = (0,0,0) = (x,y,z)
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 horizontal = transform.TransformDirection(Vector3.right);
        float FSpeed = forwardSpeed * Input.GetAxis("WAndS");
        float HSpeed = forwardSpeed * Input.GetAxis("AAndD");
        playerController.SimpleMove(FSpeed * forward);
        playerController.SimpleMove(HSpeed * horizontal);

	}

    void SetFocus(Interactable newFocus)
    {
        if(newFocus != focus)
        {
            if (focus != null)
            {
                focus.OnDefocused();
            }
            focus = newFocus;
        }

        newFocus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if (focus != null)
        {
            focus.OnDefocused();
        }
        focus.OnDefocused();
        focus = null;
    }
}
