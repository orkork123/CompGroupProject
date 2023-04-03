using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endings : MonoBehaviour
{

    public MoneyText MoneyText;
    public SanityText SanityText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoneyText.BeginMoney <= 0)
        {   
            Application.LoadLevel("MoneyEnding");
        }
        if (SanityText.BeginSanity <= 0)
        {
            Application.LoadLevel("SanityEnding");
        }
    }
}
