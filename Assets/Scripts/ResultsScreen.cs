using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultsScreen : MonoBehaviour
{
    public GameObject gameManager;


    public GameObject resultsScreen;

    public TextMeshProUGUI entreeResults;
    public TextMeshProUGUI sideResults;

    public GameObject order1;
    public GameObject order2;
    public GameObject order3;
    public GameObject order4;

   public void DisplayResults()
    {

        //display results screen and update text
        string realOrder = gameManager.GetComponent<OrderCompletionTracker>().getCompleteRealOrder();
        //string originalOrder = gameManager.GetComponent<OrderCompletionTracker>().getCompleteOriginalOrder();
        
        char[] tmpArr = realOrder.ToCharArray();
        
        string originalOrder = gameManager.GetComponent<OrderManager>().getOrderBySeatNum(tmpArr[2].ToString());

        Debug.Log(realOrder);
        Debug.Log(originalOrder);

        entreeResults.text = "Perfect! +10";
        sideResults.text = "Perfect! +10";
        
        char[] originalList = originalOrder.ToCharArray();
        char[] realList = realOrder.ToCharArray();


        if (!originalList[0].Equals(realList[0]))
        {
            entreeResults.text = "Not Quite! +0";
        }
        if(!originalList[1].Equals(realList[1]))
        {
            sideResults.text = "Not Quite! +0";
        }

        //delete the plate
        if (originalList[2] == '1')
        {
            Debug.Log("Item getting destroyed!");
            Destroy(order1.transform.GetChild(0).gameObject);
            gameManager.GetComponent<OrderManager>().removeOrder(originalOrder);
        }

        resultsScreen.SetActive(true);
    }

    public void ReturnToGame()
    {
        resultsScreen.SetActive(false);

        if(gameManager.GetComponent<MeadMinigameManager>().GetMeadCount() == 5)
        {
            Debug.Log("Minigame limit reached!");
        }
    }
}
