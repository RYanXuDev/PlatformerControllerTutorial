using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    PlayerInputActions playerInputActions;

    Vector2 axes => playerInputActions.Gameplay.Axes.ReadValue<Vector2>();

    public bool Jump => playerInputActions.Gameplay.Jump.WasPressedThisFrame();
    public bool StopJump => playerInputActions.Gameplay.Jump.WasReleasedThisFrame();
    public bool Move => AxisX != 0f;

    public float AxisX => axes.x;

    void Awake()
    {
        playerInputActions = new PlayerInputActions();
    }

    public void EnableGameplayInputs()
    {
        playerInputActions.Gameplay.Enable();
        Cursor.lockState = CursorLockMode.Locked;
    }
}