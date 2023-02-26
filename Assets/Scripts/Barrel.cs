using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    Rigidbody2D rb;
    public float magnitude;

    private void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter checks out!");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay checks out!");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTriggerExit checks out!");
    }
    private void OnMouseDown()
    {
        rb.AddForce(Vector2.up * magnitude, ForceMode2D.Impulse);
    }
}
