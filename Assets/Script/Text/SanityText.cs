using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityText : MonoBehaviour
{
    public float BeginSanity = 50f;

    public Text SanityNumberText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SanityNumberText.text = BeginSanity.ToString("0");
        if (BeginSanity <= 0)
        {
            BeginSanity = 0;
        }
    }
}
