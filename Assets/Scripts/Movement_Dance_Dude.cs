using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Dance_Dude : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool walkUp = true;
    public float speedMove;
    public Animator animator;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("WalkUp", walkUp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(walkUp)
        {
            movement.x = 0f;
            movement.y = 1f;
            rb.MovePosition(rb.position + movement * speedMove * Time.fixedDeltaTime);
        
            if(rb.position.y > -1.98f)
            {
                walkUp = false;
            }
        }

        else
        {
            movement.x = 0f;
            movement.y = -1f;
            rb.MovePosition(rb.position + movement * speedMove * Time.fixedDeltaTime);

            if(rb.position.y < -2.0f)
            {
                walkUp = true;
            }
        }
    }
}
