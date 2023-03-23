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
        float zRotation = relativeRotation.eulerAngles.z;
        int zRotationInt = Mathf.RoundToInt(zRotation) % 360;
        if (zRotationInt < 0)
        {
            zRotationInt += 360;
        }
        Debug.Log("Z Rotation: " + zRotationInt);
    }

}
