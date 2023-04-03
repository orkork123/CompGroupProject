using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePop : MonoBehaviour
{

    public GameObject Message;
    public MoneyText Moneytext;
    public SanityText Sanitytext;
    public float Speed = 0.5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Moneytext.BeginMoney -= 10;
                Sanitytext.BeginSanity += 10;
            }
            Message.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Message.SetActive(false);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moneytext.BeginMoney += Speed * Time.deltaTime;
    }
}
