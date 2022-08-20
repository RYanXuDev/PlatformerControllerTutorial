using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGem : MonoBehaviour
{
    [SerializeField] float resetTime = 3.0f;
    [SerializeField] AudioClip pickUpSFX;
    [SerializeField] ParticleSystem pickUpVFX;

    new Collider collider;

    MeshRenderer meshRenderer;

    WaitForSeconds waitResetTime;

    void Awake()
    {
        collider = GetComponent<Collider>();
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        waitResetTime = new WaitForSeconds(resetTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.CanAirJump = true;

            collider.enabled = false;
            meshRenderer.enabled = false;

            SoundEffectsPlayer.AudioSource.PlayOneShot(pickUpSFX);
            Instantiate(pickUpVFX, transform.position, transform.rotation);

            // Invoke(nameof(Reset), resetTime);
            StartCoroutine(ResetCoroutine());
        }
    }

    void Reset()
    {
        collider.enabled = true;
        meshRenderer.enabled = true;
    }

    IEnumerator ResetCoroutine()
    {
        yield return waitResetTime;

        Reset();
    }
}