using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensX;
    public float sensY;

    [SerializeField] private Transform orientation;

    private float _xRotation;
    private float _yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        _yRotation += mouseX;
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0f);
        orientation.rotation = Quaternion.Euler(0f, _yRotation, 0f);
    }
}
