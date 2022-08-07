using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    [Header("Settings")]
    public GameObject MainCamera;
    public Transform ballTransform;
    private Vector3 offset;
    public float smoothSpeed;

    void Start()
    {
        offset = MainCamera.transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(MainCamera.transform.position, offset + ballTransform.position, smoothSpeed);
        MainCamera.transform.position = newPos;
    }
}
