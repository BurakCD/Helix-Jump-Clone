using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Settings")]
    public GameObject ballObject;
    public float jumpForce;


    private void OnCollisionEnter(Collision collision)
    {
        ballObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
    }
}
