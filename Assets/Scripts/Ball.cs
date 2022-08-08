using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [Header("Settings")]
    public Rigidbody rb;
    public float jumpForce;
    public GameObject SplashPrefab;


    private string materialName;


    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);

        GameObject Splash = Instantiate(SplashPrefab, transform.position + new Vector3(0f, -0.29f, 0f), transform.rotation);
        Splash.transform.SetParent(collision.gameObject.transform);

        materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(materialName);


        if (materialName == "SafeColor (Instance)")
        {
            Debug.Log("safe");

        }
        if (materialName == "UnSafeColor (Instance)")
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("unsafe");
        }
        if (materialName == "Finish (Instance)")
        {
            Debug.Log("finish");
        }

    }
}
