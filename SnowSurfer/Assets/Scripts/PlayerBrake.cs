using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBrake : MonoBehaviour
{
    InputAction brakeAction;
    [SerializeField] float normalSpeed = 50f;
    [SerializeField] float slowSpeed = 5f;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        brakeAction = InputSystem.actions.FindAction("Sprint"); //use left shift
        surfaceEffector2D = GetComponent<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (brakeAction.WasPerformedThisFrame())
        {
            surfaceEffector2D.speed = slowSpeed;
        }
        else if (brakeAction.WasCompletedThisFrame())
        {
            surfaceEffector2D.speed = normalSpeed;
        }
    }
}
