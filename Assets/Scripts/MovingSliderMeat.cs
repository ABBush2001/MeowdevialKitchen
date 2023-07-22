using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovingSliderMeat : MonoBehaviour
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

        //Fried bat
        if((this.GetComponent<Slider>().value > 0 && this.GetComponent<Slider>().value < 5) || (this.GetComponent<Slider>().value > 15 && this.GetComponent<Slider>().value < 20))
        {
            gameManager.GetComponent<EntreeButtonController>().FriedBatSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
        //Turkey leg
        else if((this.GetComponent<Slider>().value > 5 && this.GetComponent<Slider>().value < 8) || (this.GetComponent<Slider>().value > 12 && this.GetComponent<Slider>().value < 15))
        {
            gameManager.GetComponent<EntreeButtonController>().TurkeyLegSelected();
            sliderText.text = "";
            this.gameObject.SetActive(false);
        }
        //Roasted pig
        else
        {
            gameManager.GetComponent<EntreeButtonController>().RoastedPigSelected();
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

                this.GetComponent<Slider>().value += 0.1f;
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

                this.GetComponent<Slider>().value -= 0.1f;
                yield return new WaitForSeconds(0.001f);
            }

            if(clicked)
            {
                break;
            }
        }
    }
}
