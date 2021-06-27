using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotation : MonoBehaviour
{
    private Camera ar_camera;
    private GameObject canvas;
    private Vector3 tempRotation;
    public Vector3 Offset;

    public void Start()
    {
        ar_camera = Camera.main;
        canvas = gameObject;
    }

    public void Update()
    {
        if (ar_camera.transform != null)
        {
            transform.LookAt(ar_camera.transform);
            tempRotation = transform.eulerAngles;
            tempRotation.x = 0.0f;
            tempRotation.z = 0.0f;
            tempRotation += Offset;
            transform.eulerAngles = tempRotation;
        }
    }
}
