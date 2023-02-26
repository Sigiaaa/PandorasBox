using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    Rigidbody2D rb;
    public float magnitude;
    public float speed = 5f, jumpHeight = 5f;
    [SerializeField] 
    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter checks out!");
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
