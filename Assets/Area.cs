using UnityEngine;

public class Area : MonoBehaviour
{
    [SerializeField] private Guard guard;

    // Pelaaja tulee alueelle
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guard.ShowMessage("Pelaaja havaittu");
        }
    }

    // Pelaaja pysyy alueella
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guard.ShowMessage("Pelaaja yhä alueella!");
        }
    }

    // Pelaaja poistuu alueelta
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guard.ShowMessage("Pelaaja poistui alueelta");
        }
    }
}