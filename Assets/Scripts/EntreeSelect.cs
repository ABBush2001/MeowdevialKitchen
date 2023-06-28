using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntreeSelect : MonoBehaviour
{
    public GameObject entreeOutline;
    public GameObject entreePanel;
    public TextMeshProUGUI entreeCountdown;

    private void OnMouseDown()
    {
        if (entreeCountdown.text == "")
        {
            entreePanel.SetActive(true);
        }
    }

    private void OnMouseEnter()
    {
        if (entreeCountdown.text == "")
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
