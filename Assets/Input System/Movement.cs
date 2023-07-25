using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    Vector2 inputVector;
    [SerializeField]
    private float movementSpeed;

    private void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        
    }
    public void Jump(InputAction.CallbackContext context) 
    {
        if (context.performed)
        {
            Debug.Log("Jump");
            playerRigidBody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
    public void Update()
    {
        Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y) * movementSpeed * Time.fixedDeltaTime;

        // Move the player using the calculated movement vector
        playerRigidBody.MovePosition(playerRigidBody.position + movement);
        //playerRigidBody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * movementSpeed, ForceMode.Force);
    }

    public void Moving(InputAction.CallbackContext context) 
    {
        inputVector = context.ReadValue<Vector2>();
        Debug.Log(context);
    }
}
