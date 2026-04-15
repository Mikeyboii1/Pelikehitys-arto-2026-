using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchController : MonoBehaviour
{
    [SerializeField] private LIghtController lamp;


    void Update()
    {
        // (L)
        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            lamp.TurnOn();
        }

        // (K)
        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            lamp.TurnOff();
        }
    }
}