using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPack : MonoBehaviour
{

    public float BeginMoney = Money.MoneyNumber;

    public Button Pack1;
    public Button Pack2;
    public Button Pack3;

    public GameObject CardResult;

    private Sprite FirstPackCard, SecondPackCard, ThirdPackCard;

    private Image rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = CardResult.GetComponent<Image>();

        FirstPackCard = Resources.Load<Sprite>("CharmanderCard");
        SecondPackCard = Resources.Load<Sprite>("DittoCard");
        ThirdPackCard = Resources.Load<Sprite>("EeveeCard");

        Button Pack1Button = Pack1.GetComponent<Button>();
        Button Pack2Button = Pack2.GetComponent<Button>();
        Button Pack3Button = Pack3.GetComponent<Button>();

        Pack1Button.onClick.AddListener(Pack1Click);
        Pack2Button.onClick.AddListener(Pack2Click);
        Pack3Button.onClick.AddListener(Pack3Click);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pack1Click(){
        int luck = 0;
        if (Money.MoneyNumber >= 10) 
        {
            luck = Random.Range(0,10);
            if (luck >= 5)
            { 
                FirstPackCard = Resources.Load<Sprite>("CharmanderCard");
                Debug.Log("Pack1Cards UNLUCKY");
            }
            else
            {
                FirstPackCard = Resources.Load<Sprite>("CharizardCard");
                Debug.Log("Pack1Cards LUCKY");
            }
            rend.sprite = FirstPackCard;
            Debug.Log("Pack1Cards result");
            Money.MoneyNumber = Money.MoneyNumber - 10;
        }
    }

    void Pack2Click(){
        if (Money.MoneyNumber >= 20)
        {
            rend.sprite = SecondPackCard;
            Debug.Log("Pack2Cards result");
            Money.MoneyNumber = Money.MoneyNumber - 20;
        }
    }

    void Pack3Click(){
        if (Money.MoneyNumber >= 30)
        {
            rend.sprite = ThirdPackCard;
            Debug.Log("Pack3Cards result");
            Money.MoneyNumber = Money.MoneyNumber - 30;
        }
    }


}
