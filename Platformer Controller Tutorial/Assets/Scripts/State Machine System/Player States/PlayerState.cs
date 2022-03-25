using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    protected Animator animator;

    protected PlayerInput input;
    protected PlayerStateMachine stateMachine;

    public void Initialize(Animator animator, PlayerInput input, PlayerStateMachine stateMachine)
    {
        this.animator = animator;
        this.input = input;
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {
        
    }

    public virtual void Exit()
    {
        
    }

    public virtual void LogicUpdate()
    {
        
    }

    public virtual void PhysicUpdate()
    {
        
    }
}