using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    public TextMeshProUGUI timer;

    public GameObject settingsPanel;
    public GameObject tutorialPanel;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(countdownClock()); 
    }

    IEnumerator countdownClock()
    {
        float countdown = 300;
        while (countdown > 0)
        {
            yield return new WaitForSeconds(1);
            if (!settingsPanel.activeSelf && !tutorialPanel.activeSelf)
            {
                countdown -= 1;
                timer.text = countdown.ToString();
            }
        }
        timer.text = "";
    }
}
