using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenButton : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject tavernButton;
    public GameObject kitchenButton;

    //public GameObject highlight;

    /*private void OnMouseDown()
    {
        gameManager.GetComponent<SceneManager2>().toKitchen();
    }

    private void OnMouseEnter()
    {
        //highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        //highlight.SetActive(false);
    }*/

    public void ToKitchen()
    {
        gameManager.GetComponent<SceneManager2>().toKitchen();
        tavernButton.SetActive(true);
        kitchenButton.SetActive(false);
    }

}
