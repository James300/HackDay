using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;
    public float speed;
    private Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
        transform.forward = -Camera.main.transform.forward;
        rb.velocity = transform.forward * speed;
    }
}
