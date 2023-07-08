using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject tavernScene;
    public GameObject humanPeasant;

    public GameObject seat1;
    public GameObject seat2;
    public GameObject seat3;
    public GameObject seat4;

    // Update is called once per frame
    void Update()
    {
        //if the tavern scene is active AND there is an empty seat
        if(tavernScene.activeSelf)
        {
            if(seat1.transform.childCount == 0)
            {
                GameObject customer = Instantiate(humanPeasant);
                customer.transform.SetPositionAndRotation(seat1.transform.position, Quaternion.identity);
                customer.transform.SetParent(seat1.transform);
            }
            else if(seat2.transform.childCount == 0)
            {
                GameObject customer = Instantiate(humanPeasant);
                customer.transform.SetPositionAndRotation(seat2.transform.position, Quaternion.identity);
                customer.transform.SetParent(seat2.transform);
            }
            else if(seat3.transform.childCount == 0)
            {
                GameObject customer = Instantiate(humanPeasant);
                customer.transform.SetPositionAndRotation(seat3.transform.position, Quaternion.identity);
                customer.transform.SetParent(seat3.transform);
            }
            else if(seat4.transform.childCount == 0)
            {
                GameObject customer = Instantiate(humanPeasant);
                customer.transform.SetPositionAndRotation(seat4.transform.position, Quaternion.identity);
                customer.transform.SetParent(seat4.transform);
            }
        }
    }
}
