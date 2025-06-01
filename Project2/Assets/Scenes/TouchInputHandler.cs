using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class TouchInputHandler : MonoBehaviour
{
    private ARRaycastManager arRaycastManager;
    private Camera arCamera;

    void Start()
    {
        arCamera = GetComponentInChildren<Camera>();
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = arCamera.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                hit.collider.GetComponent<GearAnimation>()?.StartRotation();
            }
        }
    }
}