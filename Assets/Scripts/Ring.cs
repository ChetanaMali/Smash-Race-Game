using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    Rigidbody rb;
    float m_MotionTimer = 0;
    float m_JumpTimer = 0;

    [SerializeField] float m_JumpSpeed, m_ForwardSpeed, m_DownSpeed;
    //[SerializeField] LayerMask m_WhatIsIt;
    [SerializeField] bool m_IsOnGround = false;
    [SerializeField] float m_MotionTime;
    [SerializeField] float m_JumpTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    /*void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && m_IsOnGround)
        {
            rb.AddForce(transform.up * m_JumpSpeed, ForceMode.Impulse);
            m_MotionTimer = m_MotionTime;
        }

        if (m_MotionTimer > 0)
        {
            rb.AddForce(transform.forward * m_ForwardSpeed);
            m_MotionTimer -= Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            Debug.Log("Ring is on ground");
            m_IsOnGround = true;

        }

    }*/

    void Update()
    {
        // Forward movement
        if (m_MotionTimer > 0)
        {
            rb.AddForce(transform.forward * m_ForwardSpeed);
            m_MotionTimer -= Time.deltaTime;    //Motion Timer
        }
        // Jump timer
        m_JumpTimer -= Time.deltaTime;

        // Automatic jump
        if (m_IsOnGround && m_JumpTimer < 0f)
        {
            rb.AddForce(Vector3.up * m_JumpSpeed, ForceMode.Impulse);
            m_IsOnGround = false;
            m_JumpTimer = m_JumpTime;
            m_MotionTimer = m_MotionTime;
        }
        //Ring goes down Down on click
        if (Input.GetButton("Fire1") && !m_IsOnGround)
        {
            rb.AddForce(-transform.up * m_DownSpeed);
        }

            // Spring force control
            if (m_IsOnGround)
        {
            //springJoint.spring = 0f;
        }

        else
        {
            //springJoint.spring = springForce;
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Debug.Log("Ring is on ground");
            m_IsOnGround = true;

        }

    }
}
  