using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOrders : MonoBehaviour
{
    public GameObject gameManager;
    
    public GameObject order1;
    public GameObject order2;
    public GameObject order3;
    public GameObject order4;

    // Update is called once per frame
    void Update()
    {
        if(gameManager.GetComponent<SpawnPlates>().order1 != "")
        {
            order1.transform.GetChild(0).gameObject.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<SpawnPlates>().order1);
            gameManager.GetComponent<SpawnPlates>().order1 = "";
        }
        if (gameManager.GetComponent<SpawnPlates>().order2 != "")
        {
            order2.transform.GetChild(0).gameObject.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<SpawnPlates>().order2);
            gameManager.GetComponent<SpawnPlates>().order2 = "";
        }
        if (gameManager.GetComponent<SpawnPlates>().order3 != "")
        {
            order3.transform.GetChild(0).gameObject.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<SpawnPlates>().order3);
            gameManager.GetComponent<SpawnPlates>().order3 = "";
        }
        if (gameManager.GetComponent<SpawnPlates>().order4 != "")
        {
            order4.transform.GetChild(0).gameObject.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<SpawnPlates>().order4);
            gameManager.GetComponent<SpawnPlates>().order4 = "";
        }
    }
}
