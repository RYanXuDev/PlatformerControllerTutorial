using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "PlayerState_Run")]
public class PlayerState_Run : PlayerState
{
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float acceration = 5f;

    public override void Enter()
    {
        animator.Play("Run");

        currentSpeed = player.MoveSpeed;
    }

    public override void LogicUpdate()
    {
        if (!input.Move)
        {
            stateMachine.SwitchState(typeof(PlayerState_Idle));
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed, runSpeed, acceration * Time.deltaTime);
    }

    public override void PhysicUpdate()
    {
        player.Move(currentSpeed);
    }
}