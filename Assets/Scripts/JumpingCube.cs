using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingCube : MonoBehaviour
{
    public float jumpForce = 5f; // Determines the height of the jump

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get a reference to the Rigidbody2D component attached to the GameObject
        StartCoroutine(JumpCoroutine());
    }

    IEnumerator JumpCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // Wait for 2 seconds
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce; // Set the vertical velocity of the Rigidbody2D component to jumpForce
        SoundManager.Instance.JumpSfx();
    }
}
