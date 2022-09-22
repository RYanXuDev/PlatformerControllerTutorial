using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Victory", fileName = "PlayerState_Victory")]
public class PlayerState_Victory : PlayerState
{
    [SerializeField] AudioClip[] voice;

    public override void Enter()
    {
        base.Enter();

        input.DisableGameplayInputs();

        player.VoicePlayer.PlayOneShot(voice[Random.Range(0, voice.Length)]);
    }
}