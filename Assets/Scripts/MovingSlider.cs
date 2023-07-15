using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovingSlider : MonoBehaviour
{
    public GameObject gameManager;
    public TextMeshProUGUI sliderText;


    bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSlider()
    {
        clicked = false;
        this.gameObject.SetActive(true);
        this.GetComponent<Slider>().value = 0;
        StartCoroutine(startSlider());
    }

    private void OnMouseDown()
    {
        clicked = true;

        //fried bat
        if(this.GetComponent<Slider>().value < 1.9f || this.GetComponent<Slider>().value > 18)
        {
            gameManager.GetComponent<EntreeButtonController>().FriedBatSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
        //witches' brew
        else if((this.GetComponent<Slider>().value > 1.9f && this.GetComponent<Slider>().value < 3.5f) || (this.GetComponent<Slider>().value > 16.7f && this.GetComponent<Slider>().value < 18f))
        {
            gameManager.GetComponent<EntreeButtonController>().WitchesBrewSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
        //garlic stew
        else if((this.GetComponent<Slider>().value > 3.5f && this.GetComponent<Slider>().value < 5) || (this.GetComponent<Slider>().value > 15.1 && this.GetComponent<Slider>().value < 16.7f))
        {
            gameManager.GetComponent<EntreeButtonController>().GarlicStewSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
        //turkey leg
        else if ((this.GetComponent<Slider>().value > 5 && this.GetComponent<Slider>().value < 6.7f) || (this.GetComponent<Slider>().value > 13.5f && this.GetComponent<Slider>().value < 15.1f))
        {
            gameManager.GetComponent<EntreeButtonController>().TurkeyLegSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
        //roasted pig
        else if ((this.GetComponent<Slider>().value > 6.7f && this.GetComponent<Slider>().value < 8.5f) || (this.GetComponent<Slider>().value > 11.5f && this.GetComponent<Slider>().value < 13.5f))
        {
            gameManager.GetComponent<EntreeButtonController>().RoastedPigSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
        //lamb stew
        else
        {
            gameManager.GetComponent<EntreeButtonController>().LambStewSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
    }

    IEnumerator startSlider()
    {
        while(!clicked)
        {
            while(this.GetComponent<Slider>().value < 20)
            {
                if(clicked)
                {
                    break;
                }

                this.GetComponent<Slider>().value += 0.01f;
                yield return new WaitForSeconds(0.001f);
            }

            if(clicked)
            {
                break;
            }

            while(this.GetComponent<Slider>().value > 0)
            {
                if(clicked)
                {
                    break;
                }

                this.GetComponent<Slider>().value -= 0.01f;
                yield return new WaitForSeconds(0.001f);
            }

            if(clicked)
            {
                break;
            }
        }
    }
}
