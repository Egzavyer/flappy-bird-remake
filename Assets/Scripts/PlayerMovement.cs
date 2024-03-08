using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private float flapStrength = 10.0f;
    private void Start()
    {
        //Get the Rigidbody2D and Animator components from the Player object
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        //If the player presses the Jump button, flap and trigger the flap animation
        if (Input.GetButtonDown("Jump"))
        {
            Flap();
            anim.SetTrigger("flap");
        }
    }

    private void Flap()
    {
        //Set the velocity of the Rigidbody2D to a new Vector2 with the y component set to the flapStrength
        rb.velocity = new Vector2(0, 0);
        rb.velocity = new Vector2(0, rb.velocity.y + flapStrength);
    }

    private void SetDefaultSprite()
    {
        //Trigger the default animation after the flap animation has finished
        anim.SetTrigger("default");
    }
}
