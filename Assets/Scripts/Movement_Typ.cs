using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Typ : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public float moveSpeed;
    public bool walkLeft = true;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("WalkLeft", walkLeft);
    
    }

    void FixedUpdate()
    {
        if(walkLeft)
        {
            movement.x = -1f;
            movement.y = 0f;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            
            if(rb.position.x < 41.0f)
            {
                walkLeft = false;
            }
        }
        else
        {
            movement.x = 1f;
            movement.y = 0f;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            
            if(rb.position.x > 77.0f)
            {
                walkLeft = true;
            }
        }
        
    }
}
