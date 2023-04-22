using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameSceneManager : MonoBehaviour
{
    private float delay = 5f; // Delay in seconds
    public Button[] buttons;
    public GameObject[] dialogues;
    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        foreach(GameObject dialogue in dialogues) {
            dialogue.gameObject.SetActive(false); // Hide the dialogue initially
        }
        foreach(Button button in buttons) {
            button.interactable = false; // Disable the button initially
            button.gameObject.SetActive(false); // Hide the button initially
        }
        dialogues[0].gameObject.SetActive(true);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= delay) {
            int previousIndex = currentIndex;
            currentIndex = currentIndex + 1; // Move to the next dialogue.
            if(currentIndex >= dialogues.Length) {
                dialogues[previousIndex].gameObject.SetActive(false);
                foreach(Button button in buttons) {
                    button.interactable = true; // Enable the button
                    button.gameObject.SetActive(true); // Show the button
                }
                Time.timeScale = 0;
            } else {
                dialogues[previousIndex].gameObject.SetActive(false); // Hide the current sprite.
                dialogues[currentIndex].gameObject.SetActive(true); // Show the next sprite.
            }
            timer = 0.0f; // Reset the timer.
        }
    }
}
