using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject NPC;

    public int INDEX;
    
    public Sprite FirstSprite, SecondSprite;

    private SpriteRenderer rend;

    public string SceneName;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        rend = NPC.GetComponent<SpriteRenderer>();
        //FirstSprite = Resources.Load<Sprite>("Teacher");
        //SecondSprite = Resources.Load<Sprite>("ClockIcon");
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index ++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            Application.LoadLevel(SceneName);
        }

        if (index == INDEX)
        {
            rend.sprite = SecondSprite;
        }
    }
}