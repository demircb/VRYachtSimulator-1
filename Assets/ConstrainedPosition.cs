using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstrainedPosition : MonoBehaviour
{
    [SerializeField] private float localPosition1X = 1f;
    [SerializeField] private float localPosition2X = 2f;

    private void Update()
    {
        // Get the current local position of the object
        Vector3 currentLocalPosition = transform.localPosition;

        // Constrain the x-axis position of the object
        currentLocalPosition.x = Mathf.Clamp(currentLocalPosition.x, localPosition1X, localPosition2X);

        // Update the local position of the object
        transform.localPosition = currentLocalPosition;
    }
}