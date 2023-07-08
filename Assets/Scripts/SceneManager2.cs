using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager2 : MonoBehaviour
{
    public GameObject tavern;
    public GameObject kitchen;

    public GameObject pot;
    public GameObject cuttingBoard;

   public void toKitchen()
    {
        tavern.SetActive(false);
        kitchen.SetActive(true);

        if (pot.transform.childCount > 0)
        {
            pot.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().size = new Vector2(17, 15);
        }
        if(cuttingBoard.transform.childCount > 0)
        {
            cuttingBoard.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().size = new Vector2(3, 3);
        }
    }

    public void toTavern()
    {
        kitchen.SetActive(false);
        tavern.SetActive(true);
    }
}
