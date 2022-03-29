using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    private Rigidbody playerRigidbody;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        playerInputSystem.Enable();
    }

    private void OnDisable()
    {
        playerInputSystem.OnDisable();
    }


    private void Move(Vector2 direction)
    {

    }
}
