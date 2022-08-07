using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Settings")]
    public Rigidbody rb;
    public float jumpForce;


    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);
    }
}
