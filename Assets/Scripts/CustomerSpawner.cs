using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject tavernScene;
    public GameObject humanPeasant;
    public GameObject wizard;
    public GameObject orc;
    public GameObject vampire;

    public GameObject seat1;
    public GameObject seat2;
    public GameObject seat3;
    public GameObject seat4;

    private Dictionary<int, GameObject>characterMap = new Dictionary<int, GameObject>();

    private void Start()
    {
        characterMap.Add(0, humanPeasant);
        characterMap.Add(1, wizard);
        characterMap.Add(2, orc);
        characterMap.Add(3, vampire);
    }

    // Update is called once per frame
    void Update()
    {
        //if the tavern scene is active AND there is an empty seat
        if(tavernScene.activeSelf)
        {
            //roll random value between 0-3, and assign character based on result
            int tmpRand = Random.Range(0, 4);

            if(seat1.transform.childCount == 0)
            {

                GameObject customer = Instantiate(characterMap[tmpRand]);
                customer.transform.SetPositionAndRotation(seat1.transform.position, Quaternion.identity);
                customer.transform.position += new Vector3(0, 1, 0);
                customer.transform.SetParent(seat1.transform);
            }
            else if(seat2.transform.childCount == 0)
            {
                GameObject customer = Instantiate(characterMap[tmpRand]);
                customer.transform.SetPositionAndRotation(seat2.transform.position, Quaternion.identity);
                customer.transform.position += new Vector3(0, 1, 0);
                customer.transform.SetParent(seat2.transform);
            }
            else if(seat3.transform.childCount == 0)
            {
                GameObject customer = Instantiate(characterMap[tmpRand]);
                customer.transform.SetPositionAndRotation(seat3.transform.position, Quaternion.identity);
                customer.transform.position += new Vector3(0, 1, 0);
                customer.transform.SetParent(seat3.transform);
            }
            else if(seat4.transform.childCount == 0)
            {
                GameObject customer = Instantiate(characterMap[tmpRand]);
                customer.transform.SetPositionAndRotation(seat4.transform.position, Quaternion.identity);
                customer.transform.position += new Vector3(0, 1, 0);
                customer.transform.SetParent(seat4.transform);
            }
        }
    }
}
