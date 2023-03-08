using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5;
    public Rigidbody2D rb;
    public Vector2 v;

    public Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        v = rb.velocity;
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Speed",0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //animator.SetFloat("Horizontal", -1);
            //animator.SetFloat("Speed",1);
            v.x = -speed;
            rb.velocity = v;
            if (Input.GetKey(KeyCode.RightArrow))
            {
                v.x = 0;
                rb.velocity = v;
            }
        }

        else if(Input.GetKey(KeyCode.RightArrow))
        {
            //animator.SetFloat("Horizontal", 1);
            //animator.SetFloat("Speed",1);
            v.x = speed;
            rb.velocity = v;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                v.x = 0;
                rb.velocity = v;
            }
        }

        else
        {
            v.x = 0;
            rb.velocity = v;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            //animator.SetFloat("Vertical", 1);
            //animator.SetFloat("Speed",1);
            v.y = speed;
            rb.velocity = v;
            if (Input.GetKey(KeyCode.DownArrow))
            {
                v.y = 0;
                rb.velocity = v;
            }
        }

        else if(Input.GetKey(KeyCode.DownArrow))
        {
            //animator.SetFloat("Vertical", -1);
            //animator.SetFloat("Speed",1);
            v.y = -speed;
            rb.velocity = v;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                v.y = 0;
                rb.velocity = v;
            }
        }

        else
        {
            //animator.SetFloat("Speed",0);
            v.y =0;
            rb.velocity = v;
        }
    }
}
