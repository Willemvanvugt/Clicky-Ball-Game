using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 turn;
    public float mouseSensitivity;

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * mouseSensitivity;
        turn.y += Input.GetAxis("Mouse Y") * mouseSensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
