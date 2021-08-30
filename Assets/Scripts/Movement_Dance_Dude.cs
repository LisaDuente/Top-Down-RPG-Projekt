using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Dance_Dude : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool walkUp = true;
    public float speedMove;
    public Animator animator;
    public bool walkDown = false;
    public bool stop = false;

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


        if (stop)
        {
            rb.MovePosition(rb.position); //Bewege dich zu deiner jetzigen position
            return;
        }

        if(walkDown)
        {
            Debug.Log("Ich gehe zur Seite");

            if(rb.position.y > -2.079f)
            {
                Debug.Log("Noch nicht unten");
                movement.x = 0f;
                movement.y = -1f;
                rb.MovePosition(rb.position + movement * speedMove * Time.fixedDeltaTime);
            }
            else
            {
                Debug.Log("Ich bin unten");
                movement.x = 1f;
                movement.y = 0f;
                rb.MovePosition(rb.position + movement * speedMove * Time.fixedDeltaTime);

                if(rb.position.x > -3.07f)
                {
                    stop = true;
                }
            }    
        }
        else
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

    void DoDanceInteraction()
    {
        walkDown = true;
    }
}
