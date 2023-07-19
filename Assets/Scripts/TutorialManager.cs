using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialPanel;

    public GameObject page1;
    public GameObject page2;

    public GameObject button1;
    public GameObject button2;

    public GameObject tutorialButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenTutorial()
    {
        tutorialPanel.SetActive(true);
        tutorialButton.SetActive(false);
    }

    public void NextPage()
    {
        page1.SetActive(false);
        page2.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(true);
    }

    public void LastPage()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        button1.SetActive(true);
        button2.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        tutorialPanel.SetActive(false);
        tutorialButton.SetActive(true);
    }
}
