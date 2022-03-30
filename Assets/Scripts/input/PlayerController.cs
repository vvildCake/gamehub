using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    private Rigidbody playerRigidbody;
    private Vector3 startPosition;

    [SerializeField]
    private float moveSpeed = 600f;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerRigidbody = GetComponent<Rigidbody>();
        startPosition = transform.position;

        playerInputActions.Kart.ResetPosition.performed += context => ResetPosition();

    }

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }
    private void FixedUpdate()
    {
        Vector2 moveDirection = playerInputActions.Kart.Move.ReadValue<Vector2>();

        Move(moveDirection);
        
    }
    

    private void Move(Vector2 direction)
    {
        playerRigidbody.velocity = new Vector3(direction.x * moveSpeed * Time.fixedDeltaTime, 0f, direction.y * moveSpeed * Time.fixedDeltaTime);
    }

    

    private void ResetPosition()
    {
        playerRigidbody.MovePosition(startPosition);
        playerRigidbody.MoveRotation(Quaternion.identity);

    }

}
