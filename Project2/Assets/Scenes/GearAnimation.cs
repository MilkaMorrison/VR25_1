using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearAnimation : MonoBehaviour
{
    private bool isRotating = false;
    public float rotationSpeed = 50f;

    private void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    public void StartRotation()
    {
        isRotating = true;
    }
}