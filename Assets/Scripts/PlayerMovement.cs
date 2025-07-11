using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float moveSpeed;
    [SerializeField] InputAction wasdAction;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        wasdAction.Enable();
    }
    void Update()
    {
        Vector2 move = wasdAction.ReadValue<Vector2>();
        Vector3 newVelocity = rigidbody.linearVelocity;
        newVelocity.x = move.x * moveSpeed;
        newVelocity.z = move.y * moveSpeed;
        rigidbody.linearVelocity = newVelocity;
    }
}
