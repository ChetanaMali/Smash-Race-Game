using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwardMove : MonoBehaviour
{
    Rigidbody rb;
    float movespeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * movespeed * Time.deltaTime);
    }
}
