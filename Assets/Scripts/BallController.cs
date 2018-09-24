using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BallController : MonoBehaviour
{
    float tapRate = 0.1f;
    public float forwardSpeed = 5.0f, radius = 1.0f;
    bool doubleTap = false;
    CharacterController controller;
    
    public GameObject ball, topLevel;
    private float rotationSpeed;
    float fallSpeed;
    float jumpSpeed = 3.0f;

    // Use this for initialization
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        rotationSpeed = forwardSpeed * Time.deltaTime / (2 * Mathf.PI * radius) * 360.0f;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 moveVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W) == true)
        {
           
            moveVector = transform.forward * forwardSpeed * Time.deltaTime;
            ball.gameObject.transform.RotateAround(ball.transform.position, Vector3.Cross(-topLevel.transform.forward, Vector3.up).normalized, rotationSpeed);
        }
        
        else if (Input.GetKey(KeyCode.D) == true)
        {
            moveVector = transform.right * forwardSpeed * Time.deltaTime;
            ball.gameObject.transform.RotateAround(ball.transform.position, -topLevel.transform.forward, rotationSpeed);

        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            moveVector = -transform.right * forwardSpeed * Time.deltaTime;
            ball.gameObject.transform.RotateAround(ball.transform.position, topLevel.transform.forward, rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            moveVector = -transform.forward * forwardSpeed * Time.deltaTime;
            ball.gameObject.transform.RotateAround(ball.transform.position, Vector3.Cross(topLevel.transform.forward, Vector3.up).normalized, rotationSpeed);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            fallSpeed = jumpSpeed;
        }
        else if (controller.isGrounded == false)
        {
            fallSpeed += Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            fallSpeed = 0;
        }
        moveVector.y = fallSpeed;

        controller.Move(moveVector);

    }
}
