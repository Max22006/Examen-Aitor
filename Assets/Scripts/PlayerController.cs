using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    private InputAction _moveAction;
    private Vector2 _moveDirection;

     

    private Rigidbody2D _rbody2D;
    private InputAction _jumpAction;
    public GroundSensor sensor;
    private float movementSpeed = 6f;
    private SpriteRenderer  render;
    private float _jumpForce = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        render = GetComponent<SpriteRenderer>();
        _rbody2D = GetComponent<Rigidbody2D>();
        _moveAction = InputSystem.actions["Move"];
        _jumpAction = InputSystem.actions["Jump"];
        sensor = GetComponentInChildren<GroundSensor>();
     
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = _moveAction.ReadValue<Vector2>();
       
        if (_jumpAction.WasPressedThisFrame() && sensor.isGrounded)
        {
          _rbody2D.AddForce(Vector2.up *_jumpForce, ForceMode2D.Impulse);
        }
       
        
        if (_moveDirection.x < 0)
        {
               render.flipX = true;
        }
       
        else if (_moveDirection.x > 0)
        {
             render.flipX = false;
        }
    }
    void FixedUpdate()
    {
        _rbody2D.linearVelocity = new Vector2(_moveDirection.x * movementSpeed, _rbody2D.linearVelocity.y);
    }
}
