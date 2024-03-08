using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private float flapStrength = 10.0f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Flap();
            anim.SetTrigger("flap");
        }
    }

    private void Flap()
    {
        rb.velocity = new Vector2(0, 0);
        rb.velocity = new Vector2(0, rb.velocity.y + flapStrength);
    }

    private void SetDefaultSprite()
    {
        anim.SetTrigger("default");
    }
}
