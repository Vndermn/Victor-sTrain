using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public float mouseSens = 10000f;
    public Transform playerBody;
    float cameraX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        
        cameraX -= mouseY;
        cameraX = Mathf.Clamp(cameraX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(cameraX, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
