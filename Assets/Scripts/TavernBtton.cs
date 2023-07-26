using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernBtton : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject kitchenButton;
    public GameObject tavernButton;

    /*public GameObject highlight;

    private void OnMouseDown()
    {
        gameManager.GetComponent<SceneManager2>().toTavern();
    }

    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }*/

    public void ToTavern()
    {
        gameManager.GetComponent<SceneManager2>().toTavern();
        kitchenButton.SetActive(true);
        tavernButton.SetActive(false);
    }
}
