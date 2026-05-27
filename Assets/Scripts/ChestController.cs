using UnityEngine;

/// <summary>
/// Avaa arkun
/// </summary>
public class ChestController : MonoBehaviour
{
    [SerializeField] private Animator chestAnimator;

    // Metodi jota muut oliot voivat kutsua
    public void OpenChest() 
    {
        Debug.Log("Arkku avattu!");
    }
}