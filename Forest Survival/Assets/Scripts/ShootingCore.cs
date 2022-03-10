using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCore : MonoBehaviour
{
    [SerializeField]
    private FixedJoystick _joystick;


    private void FixedUpdate()
    {
        LookRotation();
    }

    private void LookRotation()
    {

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            float AngleA = Mathf.Atan2(-1 * _joystick.Horizontal, _joystick.Vertical) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, AngleA);
        }
    }
}
