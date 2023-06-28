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
        gameManager.GetComponent<EntreeCountdown>().CountDown();
    }

    public void RabbitStewSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown();
    }

    public void WitchesBrewSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown();
    }

    public void FriedBatSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown();
    }

    public void RoastedPigSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown();
    }

    public void TurkeyLegSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdown.text = "20";
        gameManager.GetComponent<EntreeCountdown>().CountDown();
    }
}
