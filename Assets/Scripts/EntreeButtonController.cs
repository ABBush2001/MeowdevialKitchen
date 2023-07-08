using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntreeButtonController : MonoBehaviour
{
    public GameObject entreePanel;
    public TextMeshProUGUI entreeCountdown;
    public GameObject gameManager;

    public void LambStewSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown(0);
    }

    public void RabbitStewSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown(1);
    }

    public void WitchesBrewSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown(2);
    }

    public void FriedBatSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown(3);
    }

    public void RoastedPigSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown(4);
    }

    public void TurkeyLegSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown(5);
    }
}
