using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }
    public SpriteRenderer[] professors; // An array of SpriteRenderer components.
    private int currentSpriteIndex = 0; // Index of the current sprite.
    private float timer = 0.0f; // Timer for tracking the elapsed time.
    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null) {
            Instance = this;
        } else {
            DestroyImmediate(gameObject);
        }

        gameSpeed = initialGameSpeed;
        professors[currentSpriteIndex].enabled = true;
    }

    private void OnDestroy() {
        if(Instance == this) {
            Instance = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;

        // Increment the timer.
        timer += Time.deltaTime;

        // If 10 seconds have elapsed, hide the current sprite and show the next one.
        if(timer >= 20.0f) {
            int previousSpriteIndex = currentSpriteIndex;
            currentSpriteIndex = currentSpriteIndex + 1; // Move to the next sprite.
            if(currentSpriteIndex >= professors.Length) {
                Time.timeScale = 0;
            } else {
                professors[previousSpriteIndex].enabled = false; // Hide the current sprite.
                professors[currentSpriteIndex].enabled = true; // Show the next sprite.
                timer = 0.0f; // Reset the timer.
            }
        }
    }
}
