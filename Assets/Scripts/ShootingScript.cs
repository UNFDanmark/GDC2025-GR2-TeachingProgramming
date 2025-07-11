using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] InputAction shootAction;
    [SerializeField] float cooldown;
    float cooldownLeft;
    void Start()
    {
        shootAction.Enable();
    }
    void Update()
    {
        cooldownLeft -= Time.deltaTime;
        if (cooldownLeft <= 0 && shootAction.WasPressedThisFrame())
        {
            cooldownLeft = cooldown;
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
