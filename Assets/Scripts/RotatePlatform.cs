using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    [Header("Settings")]
    public GameObject Platform;
    public float Rotate_Speed;

    private float MoveX;


    void Update()
    {
        MoveX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0))
        {
            Platform.transform.Rotate(0f, MoveX * Rotate_Speed * Time.deltaTime, 0f);
        }
    }
}
