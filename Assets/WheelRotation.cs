using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public GameObject targetObject; // The game object to track the rotation of

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = targetObject.transform.rotation;
    }

    void Update()
    {
        Quaternion relativeRotation = Quaternion.Inverse(initialRotation) * targetObject.transform.rotation;
        float xRotation = relativeRotation.eulerAngles.x;
        int xRotationInt = Mathf.RoundToInt(xRotation) % 360;
        if (xRotationInt < 0)
        {
            xRotationInt += 360;
        }
        Debug.Log("X Rotation: " + xRotationInt);
    }

}
