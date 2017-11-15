using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //public GameObject player;
    //private Vector3 offset;  //used to calculate starting distance from camera.

    public Transform cameraTarget;
    private float x = 0.0f;
    private float y = 0.0f;

    private int mouseXSpeedMod = 5;
    private int mouseYSpeedMod = 3;

    public float maxViewDistance = 25.0f; //how far the camera can zoom out
    public float minViewDistance = 1.0f; //how close the camera can zoom in
    public int zoomRate = 30; //how fast the camera zooms
    private int lerpRate = 5;

    private float distance = 15.0f; //starting distance
    private float desiredDistance; //used for calculations
    private float correctedDistance; //used for calculations

    private float cameraTargetHeight = 1.0f;
    private float currentDistance;

	void Start () {

        //offset = transform.position - player.transform.position;

        Vector3 angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;

        currentDistance = distance;
        desiredDistance = distance;
        correctedDistance = distance;

	}
	
	// Late update is called after update.
	void LateUpdate () {

        if (Input.GetMouseButton(0)) { // 0 = left mouse button, 1 = right mouse button
            x += Input.GetAxis("Mouse X") * mouseXSpeedMod;
            y -= Input.GetAxis("Mouse Y") * mouseYSpeedMod;
        }

        else if (Input.GetAxis("WAndS") != 0 || Input.GetAxis("AAndD") != 0) {
            float targetRotationAngle = cameraTarget.eulerAngles.y;
            float cameraRotationAngle = transform.eulerAngles.y;
            x = Mathf.LerpAngle(cameraRotationAngle, targetRotationAngle, lerpRate * Time.deltaTime);
        }

        y = ClampAngle(y, -50, 80);

        Quaternion rotation = Quaternion.Euler(y, x, 0);


        desiredDistance -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * zoomRate * Mathf.Abs(desiredDistance);  //calculates the distance the player wants their camera
        desiredDistance = Mathf.Clamp(desiredDistance, minViewDistance, maxViewDistance);
        correctedDistance = desiredDistance;

        Vector3 position = cameraTarget.position - (rotation * Vector3.forward * desiredDistance);

        RaycastHit collisionHit;
        Vector3 cameraTargetPosition = new Vector3(cameraTarget.position.x, cameraTarget.position.y + cameraTargetHeight, cameraTarget.position.z);

        bool isCorrected = false;
        if (Physics.Linecast(cameraTargetPosition, position, out collisionHit)){
            position = collisionHit.point;
            correctedDistance = Vector3.Distance(cameraTargetPosition, position);
            isCorrected = true;
        }

        //conditional operators: used in the form ==>  condition ? first_expression (if condition is met) : second_expression (else);
        //if currentdistance is not corrected distance or correct distance > current distance then mathf.lerp... else corrected distance.
        currentDistance = !isCorrected || correctedDistance > currentDistance ? Mathf.Lerp(currentDistance, correctedDistance, Time.deltaTime * zoomRate) : correctedDistance;

        position = cameraTarget.position - (rotation * Vector3.forward * currentDistance + new Vector3(0, -cameraTargetHeight));

        transform.rotation = rotation; //when you call transform within the script, the script looks for the transform the script is attached to
        transform.position = position;

    }

    private static float ClampAngle(float angle, float min, float max)
    {
        if(angle < -360)
        {
            angle += 360;
        }
        if (angle > 360)
        {
            angle -= 360;
        }
        return Mathf.Clamp(angle, min, max);
    }

}
