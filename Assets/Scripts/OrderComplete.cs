using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class OrderComplete : MonoBehaviour
{
    //delete the plate and customer

    public GameObject gameManager;

    public GameObject plate1;
    public GameObject plate2;
    public GameObject plate3;
    public GameObject plate4;

    public GameObject order1;
    public GameObject order2;
    public GameObject order3;
    public GameObject order4;

    public GameObject orderPanel1;
    public GameObject orderPanel2;
    public GameObject orderPanel3;
    public GameObject orderPanel4;

    public GameObject completeButton1;
    public GameObject completeButton2;
    public GameObject completeButton3;
    public GameObject completeButton4;

    public TextMeshProUGUI customerNum1;
    public TextMeshProUGUI customerNum2;
    public TextMeshProUGUI customerNum3;
    public TextMeshProUGUI customerNum4;

    public void removeOrderAndCustomer1()
    {
        string tmpRealOrder = "";

        gameManager.GetComponent<MeadMinigameManager>().UpdateMeadCount();

        Debug.Log(plate1.transform.GetChild(0).gameObject.name);
        //add items on plate to real order

        string tmp1 = plate1.transform.GetChild(0).transform.GetChild(0).gameObject.name.Replace("(Clone)", "");
        string tmp2 = plate1.transform.GetChild(0).transform.GetChild(1).gameObject.name.Replace("(Clone)", "");

        if (gameManager.GetComponent<GenerateOrder>().entreeMap.ContainsValue(tmp1))
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp1];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp2];
        }
        else
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp2];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp1];
        }

        //Destroy(plate1.transform.GetChild(0).gameObject);
        if(customerNum1.text.Contains("1"))
        {
            Destroy(order1.transform.GetChild(0).gameObject);
            orderPanel1.SetActive(false);
            tmpRealOrder += "1";
        }
        else if(customerNum1.text.Contains("2"))
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            orderPanel2.SetActive(false);
            tmpRealOrder += "2";
        }
        else if(customerNum1.text.Contains("3"))
        {
            Destroy(order3.transform.GetChild(0).gameObject);
            orderPanel3.SetActive(false);
            tmpRealOrder += "3";
        }
        else
        {
            Destroy(order4.transform.GetChild(0).gameObject);
            orderPanel4.SetActive(false);
            tmpRealOrder += "4";
        }
        gameManager.GetComponent<OrderCompletionTracker>().setCompleteRealOrder(tmpRealOrder);
        completeButton1.SetActive(false);

        //return to tavern and pull up results screen
        gameManager.GetComponent<ResultsScreen>().DisplayResults();
    }
    public void removeOrderAndCustomer2()
    {
        string tmpRealOrder = "";

        gameManager.GetComponent<MeadMinigameManager>().UpdateMeadCount();

        gameManager.GetComponent<OrderCompletionTracker>().setCompleteOriginalOrder(plate2.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getOrder());
        //add items on plate to real order

        string tmp1 = plate2.transform.GetChild(0).transform.GetChild(0).gameObject.name.Replace("(Clone)", "");
        string tmp2 = plate2.transform.GetChild(0).transform.GetChild(1).gameObject.name.Replace("(Clone)", "");

        if (gameManager.GetComponent<GenerateOrder>().entreeMap.ContainsValue(tmp1))
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp1];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp2];
        }
        else
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp2];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp1];
        }

        Destroy(plate2.transform.GetChild(0).gameObject);
        if (customerNum2.text.Contains("1"))
        {
            Destroy(order1.transform.GetChild(0).gameObject);
            orderPanel1.SetActive(false);
        }
        else if (customerNum2.text.Contains("2"))
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            orderPanel2.SetActive(false);
        }
        else if (customerNum2.text.Contains("3"))
        {
            Destroy(order3.transform.GetChild(0).gameObject);
            orderPanel3.SetActive(false);
        }
        else
        {
            Destroy(order4.transform.GetChild(0).gameObject);
            orderPanel4.SetActive(false);
        }
        gameManager.GetComponent<OrderCompletionTracker>().setCompleteRealOrder(tmpRealOrder);
        completeButton2.SetActive(false);

        //return to tavern and pull up results screen
        gameManager.GetComponent<ResultsScreen>().DisplayResults();
    }
    public void removeOrderAndCustomer3()
    {
        string tmpRealOrder = "";

        gameManager.GetComponent<MeadMinigameManager>().UpdateMeadCount();

        gameManager.GetComponent<OrderCompletionTracker>().setCompleteOriginalOrder(plate3.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getOrder());
        //add items on plate to real order

        string tmp1 = plate3.transform.GetChild(0).transform.GetChild(0).gameObject.name.Replace("(Clone)", "");
        string tmp2 = plate3.transform.GetChild(0).transform.GetChild(1).gameObject.name.Replace("(Clone)", "");

        if (gameManager.GetComponent<GenerateOrder>().entreeMap.ContainsValue(tmp1))
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp1];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp2];
        }
        else
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp2];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp1];
        }

        Destroy(plate3.transform.GetChild(0).gameObject);
        if (customerNum3.text.Contains("1"))
        {
            Destroy(order1.transform.GetChild(0).gameObject);
            orderPanel1.SetActive(false);
        }
        else if (customerNum3.text.Contains("2"))
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            orderPanel2.SetActive(false);
        }
        else if (customerNum3.text.Contains("3"))
        {
            Destroy(order3.transform.GetChild(0).gameObject);
            orderPanel3.SetActive(false);
        }
        else
        {
            Destroy(order4.transform.GetChild(0).gameObject);
            orderPanel4.SetActive(false);
        }
        gameManager.GetComponent<OrderCompletionTracker>().setCompleteRealOrder(tmpRealOrder);
        completeButton3.SetActive(false);

        //return to tavern and pull up results screen
        gameManager.GetComponent<ResultsScreen>().DisplayResults();
    }
    public void removeOrderAndCustomer4()
    {
        string tmpRealOrder = "";

        gameManager.GetComponent<MeadMinigameManager>().UpdateMeadCount();

        gameManager.GetComponent<OrderCompletionTracker>().setCompleteOriginalOrder(plate4.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getOrder());
        //add items on plate to real order

        string tmp1 = plate4.transform.GetChild(0).transform.GetChild(0).gameObject.name.Replace("(Clone)", "");
        string tmp2 = plate4.transform.GetChild(0).transform.GetChild(1).gameObject.name.Replace("(Clone)", "");

        if (gameManager.GetComponent<GenerateOrder>().entreeMap.ContainsValue(tmp1))
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp1];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp2];
        }
        else
        {
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().entreeMapInverse[tmp2];
            tmpRealOrder += gameManager.GetComponent<GenerateOrder>().sidesMapInverse[tmp1];
        }

        Destroy(plate4.transform.GetChild(0).gameObject);
        if (customerNum4.text.Contains("1"))
        {
            Destroy(order1.transform.GetChild(0).gameObject);
            orderPanel1.SetActive(false);
        }
        else if (customerNum4.text.Contains("2"))
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            orderPanel2.SetActive(false);
        }
        else if (customerNum4.text.Contains("3"))
        {
            Destroy(order3.transform.GetChild(0).gameObject);
            orderPanel3.SetActive(false);
        }
        else
        {
            Destroy(order4.transform.GetChild(0).gameObject);
            orderPanel4.SetActive(false);
        }
        gameManager.GetComponent<OrderCompletionTracker>().setCompleteRealOrder(tmpRealOrder);
        completeButton4.SetActive(false);

        //return to tavern and pull up results screen
        gameManager.GetComponent<ResultsScreen>().DisplayResults();
    }
}
