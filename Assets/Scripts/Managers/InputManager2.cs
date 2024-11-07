using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager2 : MonoBehaviour
{
    //single references to the input manager
    public static InputManager2 instance;
    public static PlayerInput playerInput;

    public bool pressInput { get; private set; } //to be called by other scripts
    private bool pressedInput; //to update pressInput

    public Vector2 moveInput { get; private set; }

    private InputAction pressAction;
    private InputAction moveAction;

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
        pressAction = playerInput.actions["Cast"];
        pressedInput = false;
        pressInput = false;

        moveAction = playerInput.actions["Move"];
    }

    private void UpdateInputActions()
    {
        pressedInput = pressAction.triggered;
        if(pressedInput)
        {
            pressInput = !pressInput;
        }

        moveInput = moveAction.ReadValue<Vector2>();
    }
}