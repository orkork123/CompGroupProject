using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{

    //public float BeginMoney = Money.MoneyNumber;

    public float BeginMoney = 10f;

    
    public Text MoneyNumberText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       MoneyNumberText.text = BeginMoney.ToString("0");
       if (BeginMoney <= 0)
       {
        BeginMoney = 0;
       }
    }
}
