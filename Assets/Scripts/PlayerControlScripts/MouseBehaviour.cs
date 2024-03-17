using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehaviour : MonoBehaviour
{
    public float mouseSensX;
    public float mouseSensY;
    private float xRotation = 0f;
    private float yRotation = 0f;
    void Start()
    {
        //Lock Cursor
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        // Get Inputs of mouse (Position)
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensY;
        //Rotate According the movement
        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation,yRotation,0f);

    }
}
