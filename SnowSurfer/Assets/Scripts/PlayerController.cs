using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    Rigidbody2D rigidBody;
    [SerializeField] float torqueAmount = 1f;
    //[SerializeField] ParticleSystem flipParticleSystem;
    Boolean isPlayerControllable = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rigidBody = GetComponent<Rigidbody2D>();
        isPlayerControllable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerControllable)
        {
            Vector2 moveVector = moveAction.ReadValue<Vector2>();
            rigidBody.AddTorque(-torqueAmount * moveVector.x * Time.deltaTime);
        }
    }

    public void CancelControl()
    {
        isPlayerControllable = false;
    }
}