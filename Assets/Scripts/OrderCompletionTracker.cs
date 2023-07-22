using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderCompletionTracker : MonoBehaviour
{
    private string originalOrder;
    private string realOrder;

    public bool complete1 = false;
    public bool complete2 = false;
    public bool complete3 = false;
    public bool complete4 = false;

    public GameObject order1;
    public GameObject order2;
    public GameObject order3;
    public GameObject order4;

    public GameObject order1Button;
    public GameObject order2Button;
    public GameObject order3Button;
    public GameObject order4Button;

    public GameObject order1CompleteButton;
    public GameObject order2CompleteButton;
    public GameObject order3CompleteButton;
    public GameObject order4CompleteButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(order1.transform.childCount > 0 && order1.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getTally() == 2 && complete1 == false)
        {
            order1Button.SetActive(false);
            order1CompleteButton.SetActive(true);
            complete1 = true;

            for(int i = 0; i < order1.transform.GetChild(0).transform.childCount; i++)
            {
                if(order1.transform.GetChild(0).transform.GetChild(i).gameObject.name == "Cup")
                {
                    order1.transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        }
        else if(order2.transform.childCount > 0 && order2.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getTally() == 2 && complete2 == false)
        {
            order2Button.SetActive(false);
            order2CompleteButton.SetActive(true);
            complete2 = true;

            for (int i = 0; i < order2.transform.GetChild(0).transform.childCount; i++)
            {
                if (order2.transform.GetChild(0).transform.GetChild(i).gameObject.name == "Cup")
                {
                    order2.transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        }
        else if(order3.transform.childCount > 0 && order3.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getTally() == 2 && complete3 == false)
        {
            order3Button.SetActive(false);
            order3CompleteButton.SetActive(true);
            complete3 = true;

            for (int i = 0; i < order3.transform.GetChild(0).transform.childCount; i++)
            {
                if (order3.transform.GetChild(0).transform.GetChild(i).gameObject.name == "Cup")
                {
                    order3.transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        }
        else if(order4.transform.childCount > 0 && order4.transform.GetChild(0).GetComponent<CurrentPlateOrder>().getTally() == 2 && complete4 == false)
        {
            order4Button.SetActive(false);
            order4CompleteButton.SetActive(true);
            complete4 = true;

            for (int i = 0; i < order4.transform.GetChild(0).transform.childCount; i++)
            {
                if (order4.transform.GetChild(0).transform.GetChild(i).gameObject.name == "Cup")
                {
                    order4.transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        }
    }

    public void setCompleteRealOrder(string order)
    {
        realOrder = order;
    }

    public void setCompleteOriginalOrder(string order)
    {
        originalOrder = order;
    }

    public string getCompleteRealOrder()
    {
        return realOrder;
    }

    public string getCompleteOriginalOrder()
    {
        return originalOrder;
    }
}
