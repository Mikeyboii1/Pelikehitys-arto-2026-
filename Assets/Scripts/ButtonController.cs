using UnityEngine;

/// <summary>
/// Luokka on vuorovaikutuksessa painikkeen kanssa.
/// </summary>
public class ButtonController : MonoBehaviour
{
    // Referenssi avattavaan arkkuun
    [SerializeField] private ChestController chest;

    // P‰ivittyy joka frame
    private void Update()
    {
        // Kun painetaan E
        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenChest();
        }
    }

    // Metodi arkun avaamiseen
    private void OpenChest()
    {
        // Pyydet‰‰n arkkua avautumaan
        chest.OpenChest();
    }
}