using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Player vastaa pelaajan toiminnasta (liikkuminen, hyökkäys).
/// </summary>
public class Player : MonoBehaviour
{
    private Health health;
    Rigidbody rb;

    void Awake()
    {
        // TODO: hae Health-komponentti
        health = GetComponent<Health>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Keyboard.current.tKey.isPressed)
        {

            TakeDamage(3);
        }
    }
    public void TakeDamage(int amount)
    {
        // TODO: vähennä elämää Healthin kautta
        health.Modify(-amount);
    }
}

