using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntreeCountdown : MonoBehaviour
{
    public TextMeshProUGUI entreeCountdown;

    public void CountDown()
    {
        StartCoroutine(countdownClock());
    }

    IEnumerator countdownClock()
    {
        float countdown = float.Parse(entreeCountdown.text);
        Debug.Log(countdown);
        while (countdown > 0)
        {
            yield return new WaitForSeconds(1);
            countdown -= 1;
            entreeCountdown.text = countdown.ToString();
        }

        entreeCountdown.text = "";
    }
}
