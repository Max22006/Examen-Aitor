using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour

{
    private InputAction _moveAction;
    private Vector2 _moveDirection;

    private InputAction _jumpForce;

    private RigidBody2D _rbody2D;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rbody2D = GetComponent<RigidBody2D>();
        _moveAction = InputSystem ["Move"];
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = _moveAction;
    }
}
