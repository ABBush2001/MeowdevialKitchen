using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentPlateOrder : MonoBehaviour
{
    public string order;
    public int tally = 0;

    private void Start()
    {
        order = "";
    }

    public void setOrder(string newOrder)
    {
        order = newOrder;
    }

    public string getOrder()
    {
        return order;
    }

    public void updateOrder()
    {
        tally++;
    }

    public int getTally()
    {
        return tally;
    }
}
