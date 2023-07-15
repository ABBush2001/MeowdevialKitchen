using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntreeCountdown : MonoBehaviour
{
    public TextMeshProUGUI entreeCountdown;

    public GameObject pot;

    public GameObject rabbit;
    public GameObject lamb;
    public GameObject witch;
    public GameObject pig;
    public GameObject turkey;
    public GameObject bat;

    public AudioSource potSound;
    public Sprite boilingPot;
    public Sprite regularPot;

    public void CountDown(int i)
    {
        StartCoroutine(countdownClock(i));
    }

    IEnumerator countdownClock(int i)
    {
        potSound.Play();
        pot.GetComponent<SpriteRenderer>().sprite = boilingPot;
        float countdown = float.Parse(entreeCountdown.text);
        Debug.Log(countdown);
        while (countdown > 0)
        {
            yield return new WaitForSeconds(1);
            countdown -= 1;
            entreeCountdown.text = countdown.ToString();
        }

        entreeCountdown.text = "";
        potSound.Stop();
        pot.GetComponent<SpriteRenderer>().sprite = regularPot;

        //spawn item based on i
        if(i == 0)
        {
            GameObject entree = Instantiate(lamb);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        else if(i == 1)
        {
            GameObject entree = Instantiate(rabbit);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        else if(i == 2)
        {
            GameObject entree = Instantiate(witch);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        else if(i == 3)
        {
            GameObject entree = Instantiate(bat);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        else if(i == 4)
        {
            GameObject entree = Instantiate(pig);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        else if(i == 5)
        {
            GameObject entree = Instantiate(turkey);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
    }
}
