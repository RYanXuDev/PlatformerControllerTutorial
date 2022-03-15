using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Animator animator;

    // void Awake()
    // {
    //     animator = GetComponentInChildren<Animator>();
    // }

    // bool IsFalling;
    // bool IsGrounded;
    // bool IsRunning;

    // void Update()
    // {
    //     // 只有当接地时才能进行这些状态转换
    //     if (IsGrounded)
    //     {
    //         IsFalling = false;

    //         if (Keyboard.current.aKey.isPressed || Keyboard.current.dKey.isPressed)
    //         {
    //             IsRunning = true;
    //             animator.Play("Run");
    //         }
    //         else if (IsRunning) // 只有当正在跑步时松开A键或D键
    //         {
    //             IsRunning = false;
    //             animator.Play("Idle");
    //         }

    //         // 当按下当前键盘的空格键时
    //         if (Keyboard.current.spaceKey.wasPressedThisFrame)
    //         {
    //             IsGrounded = false;
    //             // 切换到跳跃状态
    //             animator.Play("Jump");
    //         }
    //     }
    //     else 
    //     {
    //         // 如果玩家正在往下掉落
    //         if (IsFalling)
    //         {
    //             // 切换到掉落状态
    //             animator.Play("Fall");
    //         }
    //     }
    // }
}