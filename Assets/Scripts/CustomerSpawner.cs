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
    public GameObject prince;

    public GameObject seat1;
    public GameObject seat2;
    public GameObject seat3;
    public GameObject seat4;

    public GameObject placeholder;

    private Dictionary<int, GameObject>characterMap = new Dictionary<int, GameObject>();

    private void Start()
    {
        characterMap.Add(0, humanPeasant);
        characterMap.Add(1, wizard);
        characterMap.Add(2, orc);
        characterMap.Add(3, vampire);
        characterMap.Add(4, prince);
    }

    // Update is called once per frame
    void Update()
    {
        //if the tavern scene is active AND there is an empty seat
        if(tavernScene.activeSelf)
        {
            //roll random value between 0-4, and assign character based on result
            int tmpRand = Random.Range(0, 5);

            if (seat1.transform.childCount == 0)
            {

                GameObject temp = Instantiate(placeholder);
                temp.transform.SetParent(seat1.transform);

                StartCoroutine(waitToSpawn(tmpRand, seat1));
            }
            else if(seat2.transform.childCount == 0)
            {
                GameObject temp = Instantiate(placeholder);
                temp.transform.SetParent(seat2.transform);

                StartCoroutine(waitToSpawn(tmpRand, seat2));
            }
            else if(seat3.transform.childCount == 0)
            {
                GameObject temp = Instantiate(placeholder);
                temp.transform.SetParent(seat3.transform);

                StartCoroutine(waitToSpawn(tmpRand, seat3));
            }
            else if(seat4.transform.childCount == 0)
            {
                GameObject temp = Instantiate(placeholder);
                temp.transform.SetParent(seat4.transform);

                StartCoroutine(waitToSpawn(tmpRand, seat4));
            }
        }
    }

    IEnumerator waitToSpawn(int character, GameObject seat)
    {
        int timeToWait = Random.Range(5, 11);

        for(int i = 0; i < timeToWait; i++)
        {
            yield return new WaitForSeconds(1);
        }

        //if character already exists
        while (GameObject.Find(characterMap[character].name + "(Clone)"))
        {
            Debug.Log("Updated!");
            character = Random.Range(0, 5);
        }

        //destroy the placeholder
        Destroy(seat.transform.GetChild(0).gameObject);

        GameObject customer = Instantiate(characterMap[character]);
        customer.transform.SetPositionAndRotation(seat.transform.position, Quaternion.identity);
        customer.transform.position += new Vector3(0, 1, 0);
        customer.transform.SetParent(seat.transform);
        StartCoroutine(fadeIn(customer));
    }

    IEnumerator fadeIn(GameObject customer)
    {
        Color tmp = customer.GetComponent<SpriteRenderer>().color;
        tmp.a = 0;
        customer.GetComponent<SpriteRenderer>().color = tmp;

        while(customer.GetComponent<SpriteRenderer>().color.a < 1)
        {
            tmp = customer.GetComponent<SpriteRenderer>().color;
            tmp.a += 0.1f;
            yield return new WaitForSeconds(0.1f);
            customer.GetComponent<SpriteRenderer>().color = tmp;
        }
    }    
}
