using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Health health;
    private Rigidbody rb;

    void Awake()
    {
        health = GetComponent<Health>();
        rb = GetComponent<Rigidbody>();

        if (health == null)
        {
            Debug.LogError("Health component missing!");
        }
    }

    void Update()
    {
        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            TakeDamage(3);
        }
    }

    public void TakeDamage(int amount)
    {
        if (health != null)
        {
            health.Modify(-amount);
        }
    }
}