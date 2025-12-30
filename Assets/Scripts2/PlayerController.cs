using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    public float playerSpeed;
    public float rotationSpeed = 0.1f;
    public float turnDirection;

    public float speed = 0.1f;

    


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        
        speed = 0.1f;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        _rigidbody.AddTorque(rotationSpeed * turnDirection);
        if (_joystick.Direction.y != 0)
        {
            _rigidbody.velocity = new Vector2(_joystick.Direction.x * playerSpeed, _joystick.Direction.y * playerSpeed);
            
        }
        else
        {
            _rigidbody.velocity = Vector2.zero;
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical) * speed;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.MovePosition(_rigidbody.position + movement);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.MovePosition(_rigidbody.position + movement);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.MovePosition(_rigidbody.position + movement);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.MovePosition(_rigidbody.position + movement);
        }

        /*if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }*/


    }

   

  

}

