using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntreeCountdown : MonoBehaviour
{
    public TextMeshProUGUI meatCountdown;
    public TextMeshProUGUI soupCountdown;

    public GameObject pot;
    public GameObject meats;

    public GameObject rabbit;
    public GameObject lamb;
    public GameObject witch;
    public GameObject pig;
    public GameObject turkey;
    public GameObject bat;

    public AudioSource potSound;
    public Sprite boilingPot;
    public Sprite regularPot;

    public GameObject cookingBat;
    public GameObject cookingPig;
    public GameObject cookingTurkey;

    public void CountDownMeat(int i)
    {
        StartCoroutine(countdownClockMeat(i));
    }

    public void CountdownSoup(int i)
    {
        StartCoroutine(countdownClockSoup(i));
    }

    IEnumerator countdownClockMeat(int i)
    {
        //display sprite
        if (i == 3)
        {
            cookingBat.SetActive(true);
        }
        else if (i == 4)
        {
            cookingPig.SetActive(true);
        }
        else if (i == 5)
        {
            cookingTurkey.SetActive(true);
        }

        potSound.Play();
        //pot.GetComponent<SpriteRenderer>().sprite = boilingPot;
        float countdown = 10;
        Debug.Log(countdown);
        while (countdown > 0)
        {
            yield return new WaitForSeconds(1);
            countdown -= 1;
            meatCountdown.text = countdown.ToString();

            //swap out sprite for cooking
            if (countdown <= 10)
            {
                if (i == 4)
                {
                    cookingPig.GetComponent<SpriteRenderer>().sprite = pig.GetComponent<SpriteRenderer>().sprite;
                }
                else if (i == 5)
                {
                    cookingTurkey.GetComponent<SpriteRenderer>().sprite = turkey.GetComponent<SpriteRenderer>().sprite;
                }
            }

        }

        meatCountdown.text = "";
        potSound.Stop();
        //pot.GetComponent<SpriteRenderer>().sprite = regularPot;

        
        if(i == 3)
        {
            GameObject entree = Instantiate(bat);
            entree.transform.SetPositionAndRotation(meats.transform.position, Quaternion.identity);
            entree.transform.position += new Vector3(1, -2, 0);
            entree.transform.SetParent(meats.transform);
            cookingBat.SetActive(false);
        }
        else if(i == 4)
        {
            GameObject entree = Instantiate(pig);
            entree.transform.SetPositionAndRotation(meats.transform.position, Quaternion.identity);
            entree.transform.position += new Vector3(1, -2, 0);
            entree.transform.SetParent(meats.transform);
            cookingPig.SetActive(false);
            cookingPig.GetComponent<SpriteRenderer>().sprite = entree.gameObject.GetComponent<SpriteRenderer>().sprite;
        }
        else if(i == 5)
        {
            GameObject entree = Instantiate(turkey);
            entree.transform.SetPositionAndRotation(meats.transform.position, Quaternion.identity);
            entree.transform.position += new Vector3(1, -2, 0);
            entree.transform.SetParent(meats.transform);
            cookingTurkey.SetActive(false);
            cookingTurkey.GetComponent<SpriteRenderer>().sprite = entree.gameObject.GetComponent<SpriteRenderer>().sprite;
        }
    }

    IEnumerator countdownClockSoup(int i)
    {
        potSound.Play();
        //pot.GetComponent<SpriteRenderer>().sprite = boilingPot;
        float countdown = 10;
        Debug.Log(countdown);
        while (countdown > 0)
        {
            yield return new WaitForSeconds(1);
            countdown -= 1;
            soupCountdown.text = countdown.ToString();
        }

        soupCountdown.text = "";
        potSound.Stop();
        pot.GetComponent<SpriteRenderer>().sprite = regularPot;

        //spawn item based on i
        if (i == 0)
        {
            GameObject entree = Instantiate(lamb);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        else if (i == 1)
        {
            GameObject entree = Instantiate(rabbit);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        else if (i == 2)
        {
            GameObject entree = Instantiate(witch);
            entree.transform.SetPositionAndRotation(pot.transform.position, Quaternion.identity);
            entree.transform.SetParent(pot.transform);
        }
        
    }
}
