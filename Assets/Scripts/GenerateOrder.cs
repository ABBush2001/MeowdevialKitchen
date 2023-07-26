using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerateOrder : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject seat1;
    public GameObject seat2;
    public GameObject seat3;
    public GameObject seat4;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    public TextMeshProUGUI entreeText1;
    public TextMeshProUGUI entreeText2;
    public TextMeshProUGUI entreeText3;
    public TextMeshProUGUI entreeText4;

    public TextMeshProUGUI sideText1;
    public TextMeshProUGUI sideText2;
    public TextMeshProUGUI sideText3;
    public TextMeshProUGUI sideText4;

    public Dictionary<int, string> entreeMap;
    public Dictionary<int, string> sidesMap;

    public Dictionary<string, int> entreeMapInverse;
    public Dictionary<string, int> sidesMapInverse;

    private int[] entreeID = {0, 1, 2, 3, 4, 5};
    /*
      0 - Lamb Stew
      1 - Rabbit Stew
      2 - Roasted Pig
      3 - Turkey Leg
      4 - Witches' Brew
      5 - Fried Bat
    */
    private int[] sidesID = {0, 1, 2};
    /*
      0 - Potato
      1 - Bread
      2 - Beans
     */

    private void Start()
    {
        entreeMap = new Dictionary<int, string>();
        sidesMap = new Dictionary<int, string>();
        entreeMapInverse = new Dictionary<string, int>();
        sidesMapInverse = new Dictionary<string, int>();


        entreeMap.Add(0, "Lamb Stew");
        entreeMap.Add(1, "Garlic Stew");
        entreeMap.Add(2, "Roasted Pig");
        entreeMap.Add(3, "Turkey Leg");
        entreeMap.Add(4, "Witches' Brew");
        entreeMap.Add(5, "Fried Bat");

        sidesMap.Add(0, "Baked Potato");
        sidesMap.Add(1, "Bread");
        sidesMap.Add(2, "Beans");

        entreeMapInverse.Add("Lamb Stew", 0);
        entreeMapInverse.Add("Garlic Stew", 1);
        entreeMapInverse.Add("Roasted Pig", 2);
        entreeMapInverse.Add("Turkey Leg", 3);
        entreeMapInverse.Add("Witches' Brew", 4);
        entreeMapInverse.Add("Fried Bat", 5);

        sidesMapInverse.Add("Baked Potato", 0);
        sidesMapInverse.Add("Bread", 1);
        sidesMapInverse.Add("Beans", 2);
    }

    public void genOrder(GameObject customer)
    {
        /*
          Seat IDs:
          1 - 4
         */
        //randomly generate values between 0 and 3 for entree, and between 0 and 2 for sides

        int entree = 0;
        int side = 0;

        if (customer.gameObject.name == "HumanPeasant(Clone)" || customer.gameObject.name == "Wizard(Clone)" || customer.gameObject.name == "Prince(Clone)")
        {
            entree = Random.Range(0, 4);
            side = Random.Range(0, 3);
        }
        else if(customer.gameObject.name == "Orc(Clone)")
        {
            entree = Random.Range(4, 6);
            side = Random.Range(0, 3);
        }
        else if(customer.gameObject.name == "Vampire(Clone)")
        {
            entree = 1;
            side = Random.Range(0, 3);
        }

        int seat;

        if (customer.transform.parent.name == "Seat1")
         {
            seat = 1;
         }
         else if(customer.transform.parent.name == "Seat2")
         {
            seat = 2;
         }
         else if(customer.transform.parent.name == "Seat3")
         {
            seat = 3;
         }
         else
         {
            seat = 4;
         }

         string order = entree.ToString() + "" + side.ToString() + "" + seat.ToString();
         gameManager.GetComponent<OrderManager>().AddOrder(order);

         //update panel
         if(seat == 1)
         {
            panel1.SetActive(true);
            LeanTween.scale(panel1, new Vector3(0, 0, 0), 0.001f);
            LeanTween.scale(panel1, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeOutElastic);
            entreeText1.text = entreeMap[entree];
            sideText1.text = sidesMap[side];
         }
         else if(seat == 2)
         {
            panel2.SetActive(true);
            LeanTween.scale(panel2, new Vector3(0, 0, 0), 0.001f);
            LeanTween.scale(panel2, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeOutElastic);
            entreeText2.text = entreeMap[entree];
            sideText2.text = sidesMap[side];
         }
         else if(seat == 3)
         {
            panel3.SetActive(true);
            LeanTween.scale(panel3, new Vector3(0, 0, 0), 0.001f);
            LeanTween.scale(panel3, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeOutElastic);
            entreeText3.text = entreeMap[entree];
            sideText3.text = sidesMap[side];
         }
         else
         {
            panel4.SetActive(true);
            LeanTween.scale(panel4, new Vector3(0, 0, 0), 0.001f);
            LeanTween.scale(panel4, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeOutElastic);
            entreeText4.text = entreeMap[entree];
            sideText4.text = sidesMap[side];
         }
    }
}
