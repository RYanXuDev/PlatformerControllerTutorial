using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "PlayerState_Run")]
public class PlayerState_Run : PlayerState
{
    public override void Enter()
    {
        animator.Play("Run");
    }

    public override void LogicUpdate()
    {
        if (!(Keyboard.current.aKey.isPressed || Keyboard.current.dKey.isPressed))
        {
            stateMachine.SwitchState(typeof(PlayerState_Idle));
        }
    }
}