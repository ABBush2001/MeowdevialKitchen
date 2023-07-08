using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SidesSelect : MonoBehaviour
{
    public GameObject sidesOutline;
    public GameObject sidesPanel;
    public GameObject currentDrag;
    public TextMeshProUGUI sidesCountdown;

    private void OnMouseDown()
    {
        if (sidesCountdown.text == "" && this.gameObject.transform.childCount < 1 && currentDrag.transform.childCount < 1)
        {
            sidesPanel.SetActive(true);
        }
    }

    private void OnMouseEnter()
    {
        if (sidesCountdown.text == "" && this.gameObject.transform.childCount < 1 && currentDrag.transform.childCount < 1)
        {
            sidesOutline.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        sidesOutline.SetActive(false);
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
