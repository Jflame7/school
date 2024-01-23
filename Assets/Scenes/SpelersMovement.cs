using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (gameObject.CompareTag("Monkey"))
        {
            MoveMonkey();
        }
        else if (gameObject.CompareTag("Camel"))
        {
            MoveCamel();
        }
    }

    void MoveMonkey()
    {
        float horizontalInput = Input.GetAxis("Horizontal_P1");
        float verticalInput = Input.GetAxis("Vertical_P1");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    void MoveCamel()
    {
        float horizontalInput = Input.GetAxis("Horizontal_P2");
        float verticalInput = Input.GetAxis("Vertical_P2");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}