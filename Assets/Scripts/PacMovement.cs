using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Terresquall;

public class PacMovement : MonoBehaviour
{
    public float moveSpeed, boostSpeed, rotationSpeed;
    public Vector3 velocity;
    public Vector3 moveDirection, lookDirection;

    public bool isGrounded;
    public float gravity, groundCheckDistance;
    public LayerMask groundMask;

    public CharacterController controller;

    // Joystick baðlantýsý
    public VirtualJoystick joystick;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        moveDirection = new Vector3(0, 0, 1);
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);

        if (isGrounded)
        {
            velocity.y = -2f;
        }

        // Joystick'ten deðerleri alýyoruz
        float lookx = joystick.axis.x;
        float lookz = joystick.axis.y;

        // Yönlendirme ve hareket hesaplamasý
        lookDirection = new Vector3(lookx, 0, lookz);
        lookDirection.Normalize();

        moveDirection = lookDirection;

        // Oyuncuyu yönlendirme
        if (moveDirection != Vector3.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
        }

        // Hýz ve hareket
        moveSpeed = Input.GetKey(KeyCode.LeftShift) ? boostSpeed : 9;
        moveDirection *= moveSpeed;

        controller.Move(moveDirection * Time.deltaTime);

        // Yerçekimi
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
