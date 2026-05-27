using UnityEngine;
/// <summary>
/// Kerättävä esine
/// </summary>
public class Item : MonoBehaviour
{
    // Suoritetaan pelaajan osuessa esineeseen.
    private void OnTriggerEnter(Collider other)
    {
        // Onko törmääjä pelaaja?
        if (other.CompareTag("Player"))
        {
            // Lisää esine inventoriin
            other.GetComponent<Inventory>().AddItem();
            // Poista esine
            Destroy(gameObject);
        }
    }
}