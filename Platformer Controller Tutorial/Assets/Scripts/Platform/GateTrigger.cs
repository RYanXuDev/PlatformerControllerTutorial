using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    [SerializeField] VoidEventChannel gateTriggeredEventChannel;
    [SerializeField] AudioClip pickUpSFX;
    [SerializeField] ParticleSystem pickUpVFX;

    void OnTriggerEnter(Collider other)
    {
        gateTriggeredEventChannel.Broadcast();
        SoundEffectsPlayer.AudioSource.PlayOneShot(pickUpSFX);
        Instantiate(pickUpVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}