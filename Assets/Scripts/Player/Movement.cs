using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public VariableJoystick variableJoystick;
    public Animator animatorController;

    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;

    void Update()
    {
        if (variableJoystick == null)
            return;

        if (animatorController == null)
            return;

        Vector2 joystickInputDirection = variableJoystick.Direction;
        Vector3 movementVector = new Vector3(joystickInputDirection.x, 0, joystickInputDirection.y);

        movementVector = movementVector * Time.deltaTime * moveSpeed;
        transform.position += movementVector;

        if (movementVector.magnitude != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movementVector, Vector3.up), Time.deltaTime * rotationSpeed);
        }

        bool isWalking = joystickInputDirection.magnitude > 0;
        animatorController.SetBool("isWalking", isWalking);
        animatorController.SetFloat("SpeedValue", joystickInputDirection.magnitude);

    }
}
