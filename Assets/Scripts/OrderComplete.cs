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

        string tmp1 = "";
        string tmp2 = "";

        Debug.Log(plate1.transform.GetChild(0).gameObject.name);
        //add items on plate to real order

        for(int i = 0; i < plate1.transform.GetChild(0).transform.childCount; i++)
        {
            //for entree
            if(plate1.transform.GetChild(0).transform.GetChild(i).name == "Entree")
            {
                GameObject e_tmp = plate1.transform.GetChild(0).transform.GetChild(i).gameObject;

                for(int k = 0; k < e_tmp.transform.childCount; k++)
                {
                    if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }
            //for sides
            else if(plate1.transform.GetChild(0).transform.GetChild(i).name == "Sides")
            {
                GameObject s_tmp = plate1.transform.GetChild(0).transform.GetChild(i).gameObject;

                for (int k = 0; k < s_tmp.transform.childCount; k++)
                {
                    if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }

        }


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

        string tmp1 = "";
        string tmp2 = "";

        gameManager.GetComponent<OrderCompletionTracker>().setCompleteOriginalOrder(plate2.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getOrder());
        //add items on plate to real order

        for (int i = 0; i < plate2.transform.GetChild(0).transform.childCount; i++)
        {
            //for entree
            if (plate2.transform.GetChild(0).transform.GetChild(i).name == "Entree")
            {
                GameObject e_tmp = plate2.transform.GetChild(0).transform.GetChild(i).gameObject;

                for (int k = 0; k < e_tmp.transform.childCount; k++)
                {
                    if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }
            //for sides
            else if (plate2.transform.GetChild(0).transform.GetChild(i).name == "Sides")
            {
                GameObject s_tmp = plate2.transform.GetChild(0).transform.GetChild(i).gameObject;

                for (int k = 0; k < s_tmp.transform.childCount; k++)
                {
                    if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }

        }

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
            tmpRealOrder += "1";
        }
        else if (customerNum2.text.Contains("2"))
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            orderPanel2.SetActive(false);
            tmpRealOrder += "2";
        }
        else if (customerNum2.text.Contains("3"))
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
        completeButton2.SetActive(false);

        //return to tavern and pull up results screen
        gameManager.GetComponent<ResultsScreen>().DisplayResults();
    }
    public void removeOrderAndCustomer3()
    {
        string tmpRealOrder = "";

        gameManager.GetComponent<OrderCompletionTracker>().setCompleteOriginalOrder(plate3.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getOrder());
        //add items on plate to real order

        string tmp1 = "";
        string tmp2 = "";

        for (int i = 0; i < plate3.transform.GetChild(0).transform.childCount; i++)
        {
            //for entree
            if (plate3.transform.GetChild(0).transform.GetChild(i).name == "Entree")
            {
                GameObject e_tmp = plate3.transform.GetChild(0).transform.GetChild(i).gameObject;

                for (int k = 0; k < e_tmp.transform.childCount; k++)
                {
                    if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }
            //for sides
            else if (plate3.transform.GetChild(0).transform.GetChild(i).name == "Sides")
            {
                GameObject s_tmp = plate3.transform.GetChild(0).transform.GetChild(i).gameObject;

                for (int k = 0; k < s_tmp.transform.childCount; k++)
                {
                    if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }

        }

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
            tmpRealOrder += "1";
        }
        else if (customerNum3.text.Contains("2"))
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            orderPanel2.SetActive(false);
            tmpRealOrder += "2";
        }
        else if (customerNum3.text.Contains("3"))
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
        completeButton3.SetActive(false);

        //return to tavern and pull up results screen
        gameManager.GetComponent<ResultsScreen>().DisplayResults();
    }
    public void removeOrderAndCustomer4()
    {
        string tmpRealOrder = "";

        gameManager.GetComponent<OrderCompletionTracker>().setCompleteOriginalOrder(plate4.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getOrder());
        //add items on plate to real order

        string tmp1 = "";
        string tmp2 = "";

        for (int i = 0; i < plate4.transform.GetChild(0).transform.childCount; i++)
        {
            //for entree
            if (plate4.transform.GetChild(0).transform.GetChild(i).name == "Entree")
            {
                GameObject e_tmp = plate4.transform.GetChild(0).transform.GetChild(i).gameObject;

                for (int k = 0; k < e_tmp.transform.childCount; k++)
                {
                    if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (e_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = e_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }
            //for sides
            else if (plate4.transform.GetChild(0).transform.GetChild(i).name == "Sides")
            {
                GameObject s_tmp = plate4.transform.GetChild(0).transform.GetChild(i).gameObject;

                for (int k = 0; k < s_tmp.transform.childCount; k++)
                {
                    if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp1 == "")
                    {
                        tmp1 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                    else if (s_tmp.transform.GetChild(k).gameObject.activeSelf && tmp2 == "")
                    {
                        tmp2 = s_tmp.transform.GetChild(k).gameObject.name.Replace("(Clone)", "");
                    }
                }
            }

        }

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
            tmpRealOrder += "1";
        }
        else if (customerNum4.text.Contains("2"))
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            orderPanel2.SetActive(false);
            tmpRealOrder += "2";
        }
        else if (customerNum4.text.Contains("3"))
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
        completeButton4.SetActive(false);

        //return to tavern and pull up results screen
        gameManager.GetComponent<ResultsScreen>().DisplayResults();
    }
}
