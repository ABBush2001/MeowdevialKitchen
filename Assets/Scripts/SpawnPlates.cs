using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class SpawnPlates : MonoBehaviour
{
    //if number of plates != number of pending orders, spawn more plates
    //each plate corresponds to one customer - plate1 = customer1, plate 2 = customer2, etc

    public GameObject plate;
    public GameObject gameManager;
    public GameObject kitchenScene;
    
    public GameObject seat1Panel;
    public GameObject seat2Panel;
    public GameObject seat3Panel;
    public GameObject seat4Panel;


    public GameObject order1Seat;
    public GameObject order2Seat;
    public GameObject order3Seat;
    public GameObject order4Seat;

    public GameObject order1Button;
    public GameObject order2Button;
    public GameObject order3Button;
    public GameObject order4Button;

    public TextMeshProUGUI order1Text;
    public TextMeshProUGUI order2Text;
    public TextMeshProUGUI order3Text;
    public TextMeshProUGUI order4Text;

    public TextMeshProUGUI entree1Text;
    public TextMeshProUGUI entree2Text;
    public TextMeshProUGUI entree3Text;
    public TextMeshProUGUI entree4Text;

    public TextMeshProUGUI sides1Text;
    public TextMeshProUGUI sides2Text;
    public TextMeshProUGUI sides3Text;
    public TextMeshProUGUI sides4Text;

    public string order1 = "";
    public string order2 = "";
    public string order3 = "";
    public string order4 = "";


    //if plate = order in list, then do nothing - else, update plate to have order

    private void Update()
    {
        if (kitchenScene.activeSelf)
        {
            //if unfinished orders exist
            if (gameManager.GetComponent<OrderManager>().getOrderLength() > 0)
            {

                

                //check each order to see if it has a plate - if not, add order
                if(order1Seat.transform.childCount < 1)
                {
                    //if orderlist contains the correct seat number, assign it to said seat
                    if (gameManager.GetComponent<OrderManager>().getOrderBySeatNum("1") != "")
                    {

                        GameObject tempPlate = Instantiate(plate);
                        tempPlate.transform.SetPositionAndRotation(order1Seat.transform.position, Quaternion.identity);
                        tempPlate.transform.parent = order1Seat.transform;
                        tempPlate.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<OrderManager>().getOrderBySeatNum("1"));
                        //order1 = tempPlate.GetComponent<CurrentPlateOrder>().getOrder();
                        char[] orderNums = tempPlate.GetComponent<CurrentPlateOrder>().getOrder().ToCharArray();
                        order1Text.text = "Customer #" + orderNums[2];
                        order1Button.SetActive(true);
                        entree1Text.text = gameManager.GetComponent<GenerateOrder>().entreeMap[(int)char.GetNumericValue(orderNums[0])];
                        sides1Text.text = gameManager.GetComponent<GenerateOrder>().sidesMap[(int)char.GetNumericValue(orderNums[1])];
                        gameManager.GetComponent<OrderCompletionTracker>().complete1 = false;
                    }
                }
                if(order2Seat.transform.childCount < 1)
                {
                    if (gameManager.GetComponent<OrderManager>().getOrderBySeatNum("2") != "")
                    {
                        GameObject tempPlate = Instantiate(plate);
                        tempPlate.transform.SetPositionAndRotation(order2Seat.transform.position, Quaternion.identity);
                        tempPlate.transform.parent = order2Seat.transform;
                        tempPlate.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<OrderManager>().getOrderBySeatNum("2"));
                        char[] orderNums = tempPlate.GetComponent<CurrentPlateOrder>().getOrder().ToCharArray();
                        //order2 = tempPlate.GetComponent<CurrentPlateOrder>().getOrder();
                        order2Text.text = "Customer #" + orderNums[2];
                        order2Button.SetActive(true);
                        entree2Text.text = gameManager.GetComponent<GenerateOrder>().entreeMap[(int)char.GetNumericValue(orderNums[0])];
                        sides2Text.text = gameManager.GetComponent<GenerateOrder>().sidesMap[(int)char.GetNumericValue(orderNums[1])];
                        gameManager.GetComponent<OrderCompletionTracker>().complete2 = false;
                    }
                }
                if(order3Seat.transform.childCount < 1)
                {
                    if (gameManager.GetComponent<OrderManager>().getOrderBySeatNum("3") != "")
                    {
                        GameObject tempPlate = Instantiate(plate);
                        tempPlate.transform.SetPositionAndRotation(order3Seat.transform.position, Quaternion.identity);
                        tempPlate.transform.parent = order3Seat.transform;
                        tempPlate.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<OrderManager>().getOrderBySeatNum("3"));
                        char[] orderNums = tempPlate.GetComponent<CurrentPlateOrder>().getOrder().ToCharArray();
                        //order3 = tempPlate.GetComponent<CurrentPlateOrder>().getOrder();
                        order3Text.text = "Customer #" + orderNums[2];
                        order3Button.SetActive(true);
                        entree3Text.text = gameManager.GetComponent<GenerateOrder>().entreeMap[(int)char.GetNumericValue(orderNums[0])];
                        sides3Text.text = gameManager.GetComponent<GenerateOrder>().sidesMap[(int)char.GetNumericValue(orderNums[1])];
                        gameManager.GetComponent<OrderCompletionTracker>().complete3 = false;
                    }
                }
                if(order4Seat.transform.childCount < 1)
                {
                    if (gameManager.GetComponent<OrderManager>().getOrderBySeatNum("4") != "")
                    {
                        GameObject tempPlate = Instantiate(plate);
                        tempPlate.transform.SetPositionAndRotation(order4Seat.transform.position, Quaternion.identity);
                        tempPlate.transform.parent = order4Seat.transform;
                        tempPlate.GetComponent<CurrentPlateOrder>().setOrder(gameManager.GetComponent<OrderManager>().getOrderBySeatNum("4"));
                        char[] orderNums = tempPlate.GetComponent<CurrentPlateOrder>().getOrder().ToCharArray();
                        //order4 = tempPlate.GetComponent<CurrentPlateOrder>().getOrder();
                        order4Text.text = "Customer #" + orderNums[2];
                        order4Button.SetActive(true);
                        entree4Text.text = gameManager.GetComponent<GenerateOrder>().entreeMap[(int)char.GetNumericValue(orderNums[0])];
                        sides4Text.text = gameManager.GetComponent<GenerateOrder>().sidesMap[(int)char.GetNumericValue(orderNums[1])];
                        gameManager.GetComponent<OrderCompletionTracker>().complete4 = false;
                    }
                }
            }
        }
    }

    public void showPanel1()
    {
        if (seat1Panel.activeSelf)
        {
            seat1Panel.SetActive(false);
        }
        else
        {
            seat1Panel.SetActive(true);
        }
    }

    public void showPanel2()
    {
        if (seat2Panel.activeSelf)
        {
            seat2Panel.SetActive(false);
        }
        else
        {
            seat2Panel.SetActive(true);
        }
    }

    public void showPanel3()
    {
        if (seat3Panel.activeSelf)
        {
            seat3Panel.SetActive(false);
        }
        else
        {
            seat3Panel.SetActive(true);
        }
    }

    public void showPanel4()
    {
        if (seat4Panel.activeSelf)
        {
            seat4Panel.SetActive(false);
        }
        else
        {
            seat4Panel.SetActive(true);
        }
    }

}
