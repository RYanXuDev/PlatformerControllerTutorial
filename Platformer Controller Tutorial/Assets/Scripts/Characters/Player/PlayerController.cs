using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput input;

    void Awake()
    {
        input = GetComponent<PlayerInput>();
    }

    void Start()
    {
        input.EnableGameplayInputs();
    }
}