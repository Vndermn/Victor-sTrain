using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    //public float gravity = -9f;

    Vector3 velocity;
    // bool touchingGround;

    #region Singleton

    public static PlayerMovement instance;

    void Awake () 
    { 
        instance = this; 
    }

    #endregion

    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        //gets input from axis and puts to float
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //applies vector move in dicrection
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

      //  velocity.y += gravity * Time.deltaTime;

      //  controller.Move(velocity * Time.deltaTime);

    }
}
