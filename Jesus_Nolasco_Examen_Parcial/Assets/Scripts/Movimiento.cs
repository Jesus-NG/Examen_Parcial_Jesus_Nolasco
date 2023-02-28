using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3 (-8.5f, 8.5f, 8.5f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3 (8.5f, 8.5f, 8.5f);
        Animator.SetBool("Corriendo", Horizontal != 0.0f);
    }

     private void FixedUpdate() 
    {
        Rigidbody2D.velocity = new Vector2(Speed * Horizontal, Rigidbody2D.velocity.y);
    }

}
