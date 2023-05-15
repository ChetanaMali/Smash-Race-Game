using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringMovementManagerScript : MonoBehaviour
{
    public float springForce = 10f;
    private List<Rigidbody> rbs;

    void Start()
    {
        rbs = new List<Rigidbody>();
        foreach (Transform child in transform)
        {
            Rigidbody rb = child.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rbs.Add(rb);
            }
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Rigidbody rb in rbs)
            {
                rb.AddForce(transform.up * springForce, ForceMode.Impulse);
            }
        }
    }
}
