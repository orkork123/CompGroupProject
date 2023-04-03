using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    public SanityText Sanitytext;
    public MoneyText Moneytext;
    
    public GameObject Wall;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown("space"))
        {
            Moneytext.BeginMoney -= 10;
            Instantiate(Wall, transform.position, Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.collider.tag == "Enemy")
        {
            Sanitytext.BeginSanity -= 1;
            Destroy(colInfo.gameObject);
            Debug.Log("YOOOOOOOO");
        }
    }
}
