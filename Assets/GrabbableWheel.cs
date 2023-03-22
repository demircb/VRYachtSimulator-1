using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabbableWheel : XRGrabInteractable
{
    public GameObject targetObject; // The game object to track the rotation of

    void Update()
    {
        float xRotation = targetObject.transform.rotation.eulerAngles.x;
        Debug.Log("X Rotation: " + xRotation);
    }
}