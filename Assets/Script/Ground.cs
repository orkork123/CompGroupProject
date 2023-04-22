using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Update() {
        float speed  = GameManager.Instance.gameSpeed / transform.localScale.x;
        meshRenderer.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }

    // public float speed = 0.5f;
    // private float groundWidth;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     SpriteRenderer groundSprite = GetComponent<SpriteRenderer>();
    //     groundWidth = groundSprite.bounds.size.x;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     transform.Translate(Vector2.left * speed * Time.deltaTime);
    //     if(transform.position.x < -groundWidth / 2) {
    //         Vector2 groundOffset = new Vector2(groundWidth * 2f, 0);
    //         transform.position = (Vector2) transform.position + groundOffset;
    //     }
    // }
}
