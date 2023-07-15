using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MeatSelect : MonoBehaviour
{
    public GameObject entreeOutline;
    public GameObject entreePanel;
    public GameObject currentDrag;
    public TextMeshProUGUI entreeCountdown;

    public GameObject entreeSlider;
    public TextMeshProUGUI sliderText;


    private void OnMouseDown()
    {
        /*if (entreeCountdown.text == "" && this.gameObject.transform.childCount < 1 && currentDrag.transform.childCount < 1)
        {
            entreePanel.SetActive(true);
        }*/
        if (this.transform.childCount == 0)
        {
            sliderText.text = "Click Here to Stop The Slider!";
            entreeSlider.SetActive(true);
            entreeSlider.GetComponent<MovingSlider>().StartSlider();
        }
    }

    private void OnMouseEnter()
    {
        if (entreeCountdown.text == "" && this.gameObject.transform.childCount < 1 && currentDrag.transform.childCount < 1)
        {
            entreeOutline.SetActive(true);
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
