using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntreeSelect : MonoBehaviour
{
    public GameObject entreeOutline;
    public GameObject entreePanel;
    public GameObject currentDrag;
    public TextMeshProUGUI entreeCountdown;

    public GameObject soupSlider;
    public GameObject meatSlider;
    public TextMeshProUGUI sliderText;

    public TextMeshProUGUI meatCountdown;

    public GameObject potOutline;
    public GameObject meatOutline;

    private void OnMouseDown()
    {

        //for soups
        if (this.transform.childCount == 0 && this.transform.gameObject.name == "EntreePot" && potOutline.activeSelf)
        {
            sliderText.text = "Click Here to Stop The Slider!";
            soupSlider.SetActive(true);
            soupSlider.GetComponent<MovingSlider>().StartSlider();
        }
        //for meats
        else if(this.transform.gameObject.name == "RawTurkeyLeg" && meatOutline.activeSelf)
        {
            sliderText.text = "Click Here to Stop The Slider!";
            meatSlider.SetActive(true);
            meatSlider.GetComponent<MovingSliderMeat>().StartSlider();
        }
    }

    private void OnMouseEnter()
    {
        if(this.gameObject.name == "EntreePot")
        {
            if (entreeCountdown.text == "" && currentDrag.transform.childCount < 1)
            {
                entreeOutline.SetActive(true);
            }
        }
        else
        {
            if (meatCountdown.text == "" && currentDrag.transform.childCount < 1)
            {
                entreeOutline.SetActive(true);
            }
        }
        
    }

    private void OnMouseExit()
    {
        entreeOutline.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
