using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    Animator animator;

    void Awake()
    {
        animator = GetComponentInChildren<Animator>();

        // Do player states initialization here
    }
}