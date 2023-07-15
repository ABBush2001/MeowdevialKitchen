using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    public GameObject resultsScreen;
    public TextMeshProUGUI scoreText;

    public AudioSource levelEndSound;
    public AudioSource mainSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        currentScore += 10;
    }

    public void ShowResultsScreen()
    {
        resultsScreen.SetActive(true);
        scoreText.text = "Score: " + currentScore.ToString();
    }

    
}
