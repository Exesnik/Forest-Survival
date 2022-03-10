using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D), typeof(BoxCollider2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private FixedJoystick _joystick;


    [SerializeField]
    private float playerSpeed; // менять его можно
    public static float _playerSpeed; // а его нет(наверное ;D)

    private void Start()
    {

    }

    private void Update()
    {
        RotationFlipPlayerTransform();
    }

    private void FixedUpdate()
    {
        PositionPlayerTransform();
    }




    private void PositionPlayerTransform()
    {
        _playerSpeed = playerSpeed;
        _rigidbody.velocity = new Vector2(_joystick.Horizontal * _playerSpeed, _joystick.Vertical * _playerSpeed);
    }

    private void RotationFlipPlayerTransform() 
    {
        if (_joystick.Horizontal > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (_joystick.Horizontal < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }



}
