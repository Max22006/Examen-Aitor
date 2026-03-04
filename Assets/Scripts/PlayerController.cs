using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    private InputAction _moveAction;
    private Vector2 _moveDirection;

     

    private Rigidbody2D _rbody2D;
    private InputAction _jumpAction;
    public GroundSensor sensor;
    private float movementSpeed = 3;
    private SpriteRenderer  render;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        render = GetComponent<SpriteRenderer>();
        _rbody2D = GetComponent<Rigidbody2D>();
        _moveAction = InputSystem.actions["Move"];
        _jumpAction = InputSystem.actions["Jump"];
     
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = _moveAction.ReadValue(Vector2);
       


       if (_jumpForce.WasPressedThisFrame && sensor.isGrounded)
       {
          
       }
        if (_moveDirection.x < 0)
           {
               render.flipX = false;
           }
        else if (_moveDirection.x > 0)
        {
             render.flipX = true;
        }
    }
    void FixedUpdate()
    {
        _rbody2D.linearVelocity = new Vector2(_moveDirection.x * movementSpeed, _rbody2D.linearVelocity.y);
    }
}
