using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntreeButtonController : MonoBehaviour
{
    public GameObject pot;

    public GameObject entreePanel;
    public TextMeshProUGUI entreeCountdownSoup;
    public TextMeshProUGUI entreeCountdownMeat;
    public GameObject gameManager;

    public Sprite lambbroth;
    public Sprite witchbroth;
    public Sprite garlicbroth;

    public void LambStewSelected()
    {
        pot.GetComponent<SpriteRenderer>().sprite = lambbroth;
        entreePanel.SetActive(false);
        entreeCountdownSoup.text = "10";
        gameManager.GetComponent<EntreeCountdown>().CountdownSoup(0);
    }

    public void GarlicStewSelected()
    {
        pot.GetComponent<SpriteRenderer>().sprite = garlicbroth;
        entreePanel.SetActive(false);
        entreeCountdownSoup.text = "10";
        gameManager.GetComponent<EntreeCountdown>().CountdownSoup(1);
    }

    public void WitchesBrewSelected()
    {
        pot.GetComponent<SpriteRenderer>().sprite = witchbroth;
        entreePanel.SetActive(false);
        entreeCountdownSoup.text = "10";
        gameManager.GetComponent<EntreeCountdown>().CountdownSoup(2);
    }

    public void FriedBatSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdownMeat.text = "10";
        gameManager.GetComponent<EntreeCountdown>().CountDownMeat(3);
    }

    public void RoastedPigSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdownMeat.text = "10";
        gameManager.GetComponent<EntreeCountdown>().CountDownMeat(4);
    }

    public void TurkeyLegSelected()
    {
        entreePanel.SetActive(false);
        entreeCountdownMeat.text = "10";
        gameManager.GetComponent<EntreeCountdown>().CountDownMeat(5);
    }
}
