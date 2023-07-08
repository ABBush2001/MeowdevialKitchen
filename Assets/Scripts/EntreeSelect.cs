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


    private void OnMouseDown()
    {
        if (entreeCountdown.text == "" && this.gameObject.transform.childCount < 1 && currentDrag.transform.childCount < 1)
        {
            entreePanel.SetActive(true);
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
