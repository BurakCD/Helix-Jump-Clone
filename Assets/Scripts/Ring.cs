using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    [Header("Settings")]
    public Transform ball;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y > ball.position.y) {

            Destroy(gameObject);
        }
    }
}
