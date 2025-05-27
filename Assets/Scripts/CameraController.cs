using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 currentPosition;
    Camera cam;
    [SerializeField] float speed;

    private void Start()
    {
        cam = Camera.main;
        currentPosition = cam.transform.position;
    }

    private void FixedUpdate()
    {
        currentPosition += Vector3.right * speed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        transform.position = currentPosition;
    }
}
