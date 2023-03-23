using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FreezeOnCollision : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    [SerializeField] float minX = -0.011f;
    [SerializeField] float maxX = 0.08f;

    private void Clamp()
    {
        Vector3 clampedPosition = transform.localPosition;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        transform.localPosition = clampedPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("AnotherGameObject"))
        {
            Clamp();
            Debug.Log("Clap activated at position ");
        }
    }
}


