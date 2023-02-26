using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    public float magnitude;

    private void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionStay checks out!");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit checks out!");
    }
    private void OnMouseDown()
    {
        rb.AddForce(Vector2.up * magnitude, ForceMode2D.Impulse);
    }
}
