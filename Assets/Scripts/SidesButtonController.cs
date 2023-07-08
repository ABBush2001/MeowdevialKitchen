using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SidesButtonController : MonoBehaviour
{
    public GameObject sidesPanel;
    public TextMeshProUGUI sidesCountdown;
    public GameObject gameManager;

    public void PotatoSelected()
    {
        sidesPanel.SetActive(false);
        sidesCountdown.text = "20";
        gameManager.GetComponent<SidesCountdown>().CountDown(0);
    }

    public void BreadSelected()
    {
        sidesPanel.SetActive(false);
        sidesCountdown.text = "20";
        gameManager.GetComponent<SidesCountdown>().CountDown(1);
    }

    public void BeansSelected()
    {
        sidesPanel.SetActive(false);
        sidesCountdown.text = "20";
        gameManager.GetComponent<SidesCountdown>().CountDown(2);
    }
}
