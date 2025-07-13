using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    // Dette er en kommentar
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // type navnet = startværdi;
    public int health = 10;
    public int speed = 18; 
    Rigidbody rb;

    public InputAction moveAction;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // læs input
        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        // kopi af nuværende hastighed
        Vector3 newVelocity = rb.linearVelocity;
        
        // opdater kopi værdierne
        newVelocity.x = moveInput.x * speed;
        newVelocity.z = moveInput.y * speed;
        
        // opdater rigtige hastighed
        rb.linearVelocity = newVelocity;
    }
}
