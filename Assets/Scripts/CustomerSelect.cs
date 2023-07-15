using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerSelect : MonoBehaviour
{
    private GameObject gameManager;
    public bool orderTaken = false;
    public AudioSource selectSound;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        selectSound = GameObject.Find("CustomerSelectSound").GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (this.transform.GetChild(0).gameObject.activeSelf)
        {
            selectSound.Play();
            Debug.Log("Clicked!");
            gameManager.GetComponent<GenerateOrder>().genOrder(this.gameObject);
            orderTaken = true;
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        if (orderTaken == false)
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
        }
    }


    private void OnMouseExit()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
