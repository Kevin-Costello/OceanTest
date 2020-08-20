using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Camera camera;
    public Transform target;
    private Vector3 previousPosition;


    public float rotateSpeed = 1.5f;
    public float limit = 180.0f;

    // Update is called once per frame

    private void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = camera.ScreenToViewportPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direction = previousPosition - camera.ScreenToViewportPoint(Input.mousePosition);
            camera.transform.position = target.position;

            camera.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
            camera.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
            camera.transform.Translate(new Vector3(0, 0, -60));

            previousPosition = camera.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log(previousPosition);
        }
    }

}
