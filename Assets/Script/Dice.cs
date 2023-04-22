using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    private int D1 = 0;
    private int D2 = 0;
    private int D3 = 0;
    private int D4 = 0;
    private int D5 = 0;
    private int D6 = 0;
    public GameObject DiceOne, DiceTwo, DiceThree, DiceFour, DiceFive, DiceSix;
    public Sprite OneDotDice, TwoDotDice, ThirdDotDice, FourthDotDice, FifthDotDice, SixthDotDice;
    private SpriteRenderer Rend1,Rend2,Rend3,Rend4,Rend5,Rend6;
    public MoneyText moneytext;
    public GameObject CasinoNPC;

    // Start is called before the first frame update
    void Start()
    {
        D1 = Random.Range(1,6);
        D2 = Random.Range(1,6);
        D3 = Random.Range(1,6);
        D4 = Random.Range(1,6);
        D5 = Random.Range(1,6);
        D6 = Random.Range(1,6);

        Rend1 = DiceOne.GetComponent<SpriteRenderer>();  
        Rend2 = DiceTwo.GetComponent<SpriteRenderer>();
        Rend3 = DiceThree.GetComponent<SpriteRenderer>();
        Rend4 = DiceFour.GetComponent<SpriteRenderer>();
        Rend5 = DiceFive.GetComponent<SpriteRenderer>();
        Rend6 = DiceSix.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (D1 == 1)
            {
                Rend1.sprite = OneDotDice;
            }
            if (D1 == 2)
            {
                Rend1.sprite = TwoDotDice;
            }
            if (D1 == 3)
            {
                Rend1.sprite = ThirdDotDice;
            }
            if (D1 == 4)
            {
                Rend1.sprite = FourthDotDice;
            }
            if (D1 == 5)
            {
                Rend1.sprite = FifthDotDice;
            }
            if (D1 == 6)
            {
                Rend1.sprite = SixthDotDice;
            }

            if (D2 == 1)
            {
                Rend2.sprite = OneDotDice;
            }
            if (D2 == 2)
            {
                Rend2.sprite = TwoDotDice;
            }
            if (D2 == 3)
            {
                Rend2.sprite = ThirdDotDice;
            }
            if (D2 == 4)
            {
                Rend2.sprite = FourthDotDice;
            }
            if (D2 == 5)
            {
                Rend2.sprite = FifthDotDice;
            }
            if (D2 == 6)
            {
                Rend2.sprite = SixthDotDice;
            }

            if (D3 == 1)
            {
                Rend3.sprite = OneDotDice;
            }
            if (D3 == 2)
            {
                Rend3.sprite = TwoDotDice;
            }
            if (D3 == 3)
            {
                Rend3.sprite = ThirdDotDice;
            }
            if (D3 == 4)
            {
                Rend3.sprite = FourthDotDice;
            }
            if (D3 == 5)
            {
                Rend3.sprite = FifthDotDice;
            }
            if (D3 == 6)
            {
                Rend3.sprite = SixthDotDice;
            }

            if (D4 == 1)
            {
                Rend4.sprite = OneDotDice;
            }
            if (D4 == 2)
            {
                Rend4.sprite = TwoDotDice;
            }
            if (D4 == 3)
            {
                Rend4.sprite = ThirdDotDice;
            }
            if (D4 == 4)
            {
                Rend4.sprite = FourthDotDice;
            }
            if (D4 == 5)
            {
                Rend4.sprite = FifthDotDice;
            }
            if (D4 == 6)
            {
                Rend4.sprite = SixthDotDice;
            }

            if (D5 == 1)
            {
                Rend5.sprite = OneDotDice;
            }
            if (D5 == 2)
            {
                Rend5.sprite = TwoDotDice;
            }
            if (D5 == 3)
            {
                Rend5.sprite = ThirdDotDice;
            }
            if (D5 == 4)
            {
                Rend5.sprite = FourthDotDice;
            }
            if (D5 == 5)
            {
                Rend5.sprite = FifthDotDice;
            }
            if (D5 == 6)
            {
                Rend5.sprite = SixthDotDice;
            }

            if (D6 == 1)
            {
                Rend6.sprite = OneDotDice;
            }
            if (D6 == 2)
            {
                Rend6.sprite = TwoDotDice;
            }
            if (D6 == 3)
            {
                Rend6.sprite = ThirdDotDice;
            }
            if (D6 == 4)
            {
                Rend6.sprite = FourthDotDice;
            }
            if (D6 == 5)
            {
                Rend6.sprite = FifthDotDice;
            }
            if (D6 == 6)
            {
                Rend6.sprite = SixthDotDice;
            }

            moneytext.BeginMoney = moneytext.BeginMoney + D1 + D2 + D3 + D4 + D5 + D6;

            //Destroy(gameObject);

            CasinoNPC.SetActive(false);
        }
    }

}
