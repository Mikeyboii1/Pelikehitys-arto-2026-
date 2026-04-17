using UnityEngine;
using static UnityEngine.InputSystem.Controls.AxisControl;

public class LIghtController : MonoBehaviour
{
    Light lamplight;

    private void Awake()
    {
        lamplight = GetComponent<Light>();
    }

    public void TurnOn()
    {
        lamplight.enabled = true;
    }

    public void TurnOff()
    {
        lamplight.enabled = false;
    }

}
