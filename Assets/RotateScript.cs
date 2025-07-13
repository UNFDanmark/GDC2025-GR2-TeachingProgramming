using UnityEngine;
using UnityEngine.InputSystem;

public class RotateScript : MonoBehaviour
{
    public InputAction turnAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, turnAction.ReadValue<float>(), 0f);
    }
}
