using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SidesCountdown : MonoBehaviour
{
    public TextMeshProUGUI sidesCountdown;

    public GameObject cuttingBoard;

    public GameObject bread;
    public GameObject beans;
    public GameObject potato;

    public void CountDown(int i)
    {
        StartCoroutine(countdownClock(i));
    }

    IEnumerator countdownClock(int i)
    {
        float countdown = float.Parse(sidesCountdown.text);
        Debug.Log(countdown);
        while (countdown > 0)
        {
            yield return new WaitForSeconds(1);
            countdown -= 1;
            sidesCountdown.text = countdown.ToString();
        }
        sidesCountdown.text = "";

        if (i == 0)
        {
            GameObject side = Instantiate(potato);
            side.transform.SetPositionAndRotation(cuttingBoard.transform.position, Quaternion.identity);
            side.transform.SetParent(cuttingBoard.transform);
        }
        else if (i == 1)
        {
            GameObject side = Instantiate(bread);
            side.transform.SetPositionAndRotation(cuttingBoard.transform.position, Quaternion.identity);
            side.transform.SetParent(cuttingBoard.transform);
        }
        else if (i == 2)
        {
            GameObject side = Instantiate(beans);
            side.transform.SetPositionAndRotation(cuttingBoard.transform.position, Quaternion.identity);
            side.transform.SetParent(cuttingBoard.transform);
        }
    }
}
