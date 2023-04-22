using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessText : MonoBehaviour
{
    public float BeginHappiness = 50f;

    public Text HappinessNumberText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HappinessNumberText.text = BeginHappiness.ToString("0");
        if (BeginHappiness <= 0)
        {
            BeginHappiness = 0;
        }
    }
}
