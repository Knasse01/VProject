using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody playerRigidBody;

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
    public void Moving(InputAction.CallbackContext context) 
    {
        Debug.Log(context);
    }
}
