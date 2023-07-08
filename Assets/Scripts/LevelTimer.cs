using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    public TextMeshProUGUI timer;

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
            countdown -= 1;
            timer.text = countdown.ToString();
        }
        timer.text = "";
    }
}
