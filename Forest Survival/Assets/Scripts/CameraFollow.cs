using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform PlayerTrans;

    public float CamSpeed;

    private void Start()
    {
        PlayerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    private void FixedUpdate()
    {
        CameraPositionTransform();
    }




    private void CameraPositionTransform()
    {
        CamSpeed = PlayerController._playerSpeed;
        transform.position = Vector2.MoveTowards(transform.position, PlayerTrans.position, CamSpeed * Time.deltaTime);
    }
}
