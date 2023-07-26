using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject tavern;
    public GameObject kitchen;
    public GameObject mead;
    public GameObject temp;

    public GameObject settingsPanel;
    public GameObject tutorialPanel;

    public GameObject gameManager;

    private string lastScreen;

    private void Start()
    {
        lastScreen = "";
    }

    public void Opensettings()
    {
        if(tavern.activeSelf)
        {
            lastScreen = tavern.name;
            tavern.SetActive(false);

        }
        else if(kitchen.activeSelf)
        {
            lastScreen = kitchen.name;
            kitchen.SetActive(false);
        }
        else
        {
            lastScreen = mead.name;
            mead.SetActive(false);
        }

        temp.SetActive(true);
        settingsPanel.SetActive(true);
    }

    public void OpenTutorial()
    {
        settingsPanel.SetActive(false);
        tutorialPanel.SetActive(true);
    }

    public void CloseTutorial()
    {
        settingsPanel.SetActive(true);
        tutorialPanel.SetActive(false);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        temp.SetActive(false);

        if(lastScreen == tavern.name)
        {
            tavern.SetActive(true);
        }
        else if(lastScreen == kitchen.name)
        {
            kitchen.SetActive(true);
        }
        else
        {
            mead.SetActive(true);
        }
    }

    public void QuitGame()
    {
        gameManager.GetComponent<SceneLoader>().loadScene2();
    }
}
