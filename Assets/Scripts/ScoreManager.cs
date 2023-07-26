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

    public GameObject kitchen;
    public GameObject tavern;
    public GameObject mead;
    public GameObject endScreen;

    public TextMeshProUGUI headScoreText;

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
        headScoreText.text = currentScore.ToString();
    }

    public void ShowResultsScreen()
    {
        kitchen.SetActive(false);
        tavern.SetActive(false);
        mead.SetActive(false);
        endScreen.SetActive(true);
        resultsScreen.SetActive(true);
        scoreText.text = "Score: " + currentScore.ToString();
    }
}
