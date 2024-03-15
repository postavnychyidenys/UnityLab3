using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWASDMovement : MonoBehaviour
{
    public float rollSpeed = 5f; 
    public float moveSpeed = 5f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        Vector3 rollForce = new Vector3(horizontalInput, 0f, verticalInput) * rollSpeed;
        rb.AddForce(rollForce);

        rb.MovePosition(transform.position + movement);
    }
}
