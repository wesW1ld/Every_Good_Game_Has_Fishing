using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    //single references to the input manager
    public static InputManager instance;
    public static PlayerInput playerInput;

    public bool pressInput { get; private set; } //to be called by other scripts

    private bool pressedInput; //to update pressInput

    private InputAction pressAction;

    private void Awake()
    {
        // Set singleton ref.
        if (instance == null)
        {
            instance = this;
        }

        // Player input ref.
        playerInput = GetComponent<PlayerInput>();

        SetupInputActions();
    }

    void Update()
    {
        UpdateInputActions();
    }

    private void SetupInputActions()
    {
        pressAction = playerInput.actions["Input"];
        pressedInput = false;
        pressInput = false;
    }

    private void UpdateInputActions()
    {
        pressedInput = pressAction.triggered;
        if(pressedInput)
        {
            pressInput = !pressInput;
        }
    }
}