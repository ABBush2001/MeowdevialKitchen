using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class MeadSpellClicker : MonoBehaviour
{
    private float counter = 1.0f;

    public GameObject slider;

    public AudioSource meadClickerSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartPart()
    {
        slider.SetActive(true);
        slider.GetComponent<Slider>().value = 1;
        StartCoroutine(counterStarter());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (this.gameObject.GetComponent<MeadSpellClicker>().enabled)
        {
            meadClickerSound.Play();
            slider.GetComponent<Slider>().value -= 0.5f;
        }
    }

    IEnumerator counterStarter()
    {
        while(slider.GetComponent<Slider>().value > 0)
        {
            slider.GetComponent<Slider>().value += 0.1f;
            yield return new WaitForSeconds(0.1f);
        }

        slider.SetActive(false);
        this.GetComponent<MeadMinigameManager1>().EndMinigame();
    }
}
