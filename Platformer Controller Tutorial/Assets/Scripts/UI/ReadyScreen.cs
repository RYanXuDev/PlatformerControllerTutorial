using UnityEngine;

public class ReadyScreen : MonoBehaviour
{
    [SerializeField] AudioClip startVoice;
    [SerializeField] VoidEventChannel levelStartedEventChannel;

    // Animation Event Function
    void LevelStart()
    {
        levelStartedEventChannel.Broadcast();

        GetComponent<Canvas>().enabled = false;
        GetComponent<Animator>().enabled = false;
    }

    void PlayStartVoice()
    {
        SoundEffectsPlayer.AudioSource.PlayOneShot(startVoice);
    }
}