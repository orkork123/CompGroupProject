using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{
    public float speed;
    public float jump;
    private float Move;
    private Rigidbody2D player;
    private bool isJumping = false;
    public Sprite[] runningSprites;
    public Sprite[] jumpingSprites;
    private SpriteRenderer spriteRenderer;
    private int frame;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        player.velocity = new Vector2(speed * Move, player.velocity.y);

        if(Input.GetButtonDown("Jump") && !isJumping) {
            player.AddForce(new Vector2(player.velocity.x, jump));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Ground")) {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Ground")) {
            isJumping = true;
        }
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Animate), 0f);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Animate()
    {
        frame++;

        if (frame >= runningSprites.Length) {
            frame = 0;
        }

        if (frame >= 0 && frame < runningSprites.Length) {
            if(!isJumping) {
                spriteRenderer.sprite = runningSprites[frame];
            } else {
                spriteRenderer.sprite = jumpingSprites[frame];
            }
        }

        Invoke(nameof(Animate), 1f / GameManager.Instance.gameSpeed);
    }
}