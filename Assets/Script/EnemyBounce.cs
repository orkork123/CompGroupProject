using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    public Player PlayerObject;
    // Start is called before the first frame update
    void Start()
    {
        double randomNumber = Random.Range(0, 2);
        if (randomNumber <= 0.5f)
        {
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(60, -15));
        }

        else
        {
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(-60, -15));
        }

    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.collider.tag == "Player")
        {
            //Destroy(colInfo.gameObject);
            Debug.Log("Player Hit!");
        }
    }
}

