using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] InputAction leftRightAction;

    void Awake()
    {
        leftRightAction.Enable();
    }
    void Update()
    {
        transform.Rotate(0,leftRightAction.ReadValue<float>()*rotationSpeed,0);
    }
}
