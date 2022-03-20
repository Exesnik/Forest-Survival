using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCore : MonoBehaviour
{
    [SerializeField]
    private FixedJoystick _joystick;
    [SerializeField]
    private Rigidbody2D _rbShootingCore;
    private Vector2 _rotation;

    public float speed = 10; // скорость пули
    public Rigidbody2D bullet; // префаб нашей пули
    public Transform gunPoint; // точка рождения
    public float fireRate = 1; // скорострельность
    private float curTimeout;

    private void Start()
    {
        
    }


    private void FixedUpdate()
    {
        LookRotation();
        Fire();


    }

    private void LookRotation()
    {

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            float AngleA = Mathf.Atan2(_joystick.Horizontal, _joystick.Vertical) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, AngleA);


        }



    }
    void Fire()
    {
        curTimeout += Time.deltaTime;
        if (curTimeout > fireRate)
        {
            curTimeout = 0;
            Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(gunPoint.up * speed);
            clone.transform.up = gunPoint.up;
        }
    }
}
