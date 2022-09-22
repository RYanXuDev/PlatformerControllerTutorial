using UnityEngine;

public class Spike : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController player))
        {
            player.OnDefeated();
        }
    }
}