using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float JumpInputBufferTime = 0.5f;

    WaitForSeconds waitJumpInputBufferTime;

    PlayerInputActions playerInputActions;

    Vector2 axes => playerInputActions.Gameplay.Axes.ReadValue<Vector2>();

    public bool HasJumpInputBuffer { get; set; }
    public bool Jump => playerInputActions.Gameplay.Jump.WasPressedThisFrame();
    public bool StopJump => playerInputActions.Gameplay.Jump.WasReleasedThisFrame();
    public bool Move => AxisX != 0f;

    public float AxisX => axes.x;

    void Awake()
    {
        playerInputActions = new PlayerInputActions();

        waitJumpInputBufferTime = new WaitForSeconds(JumpInputBufferTime);
    }

    void OnEnable()
    {
        playerInputActions.Gameplay.Jump.canceled += delegate
        {
            HasJumpInputBuffer = false;
        };
    }

    // void OnGUI()
    // {
    //     Rect rect = new Rect(200, 200, 200, 200);
    //     string message = "Has Jump Input Buffer: " + HasJumpInputBuffer;
    //     GUIStyle style = new GUIStyle();

    //     style.fontSize = 20;
    //     style.fontStyle = FontStyle.Bold;

    //     GUI.Label(rect, message, style);
    // }

    public void EnableGameplayInputs()
    {
        playerInputActions.Gameplay.Enable();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SetJumpInputBufferTimer()
    {
        StopCoroutine(nameof(JumpInputBufferCoroutine));
        StartCoroutine(nameof(JumpInputBufferCoroutine));
    }

    IEnumerator JumpInputBufferCoroutine()
    {
        HasJumpInputBuffer = true;

        yield return waitJumpInputBufferTime;

        HasJumpInputBuffer = false;
    }
}