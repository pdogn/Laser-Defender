using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30f; // T?c �? xoay

    void Update()
    {
        // Xoay theo tr?c Y v?i t?c �? �? �?t
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
