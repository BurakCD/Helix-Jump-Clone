using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    [Header("Settings")]
    public Transform ball;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (transform.position.y > ball.position.y) {

            Destroy(gameObject);
            gameManager.GameScore(25);
        }
    }
}
