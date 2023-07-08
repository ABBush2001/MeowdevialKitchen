using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    private ArrayList orderList = new ArrayList();

    public void AddOrder(string order)
    {
        orderList.Add(order);
    }

    public bool orderExists(string order)
    {
        return orderList.Contains(order);
    }

    public string getOrder()
    {
        string tmp = orderList[0].ToString();
        orderList.RemoveAt(0);
        if (orderList.Count > 0)
        {
            orderList.Insert(orderList.Count - 1, tmp);
        }
        else
        {
            orderList.Add(tmp);
        }
        return tmp;
    }

    public string getOrderBySeatNum(string i)
    {
        foreach(string order in orderList)
        {
            char[] tmpArr = order.ToCharArray();
            if (tmpArr[2] == i.ToCharArray()[0])
            {
                return order;
            }
        }

        return "";
    }

    public void removeOrder(string order)
    {
        if(orderList.Contains(order))
        {
            orderList.Remove(order);
        }
    }

    public int getOrderLength()
    {
        return orderList.Count;
    }
}
