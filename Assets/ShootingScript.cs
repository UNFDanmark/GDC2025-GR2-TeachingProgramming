using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    static readonly int Shoot = Animator.StringToHash("Shot");
    public GameObject bullet;
    public float bulletSpeed = 5f;

    public InputAction shoot;

    public float cooldown = 0.5f;
    float cooldownLeft;
    Animator animator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        animator = transform.parent.GetComponentInChildren<Animator>();
        
        int b = 8;
        int a = 5;
        int c = 0;
        // 
        c = b;
        b = a;
        a = c;
        print(a);
        print(b);
    }

    void Start()
    {
        shoot.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        cooldownLeft -= Time.deltaTime;
        if (shoot.WasPressedThisFrame() && cooldownLeft <= 0)
        {
            GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody bulletRb = bulletClone.GetComponent<Rigidbody>();
            bulletRb.linearVelocity = transform.forward * bulletSpeed;
            animator.SetTrigger(Shoot);
            
            
            cooldownLeft = cooldown;
        }
        
    }
}
