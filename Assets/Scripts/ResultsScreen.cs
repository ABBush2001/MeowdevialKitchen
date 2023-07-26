using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultsScreen : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject tavernButton;

    public GameObject resultsScreen;

    public TextMeshProUGUI entreeResults;
    public TextMeshProUGUI sideResults;

    public GameObject order1;
    public GameObject order2;
    public GameObject order3;
    public GameObject order4;

    public AudioSource coinsJingle;

   public void DisplayResults()
    {

        //display results screen and update text
        string realOrder = gameManager.GetComponent<OrderCompletionTracker>().getCompleteRealOrder();
        //string originalOrder = gameManager.GetComponent<OrderCompletionTracker>().getCompleteOriginalOrder();

        Debug.Log(realOrder);

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
        else
        {
            gameManager.GetComponent<ScoreManager>().UpdateScore();
        }

        if(!originalList[1].Equals(realList[1]))
        {
            sideResults.text = "Not Quite! +0";
        }
        else
        {
            gameManager.GetComponent<ScoreManager>().UpdateScore();
        }

        //delete the plate
        if (originalList[2] == '1')
        {
            Debug.Log("Item getting destroyed!");
            Destroy(order1.transform.GetChild(0).gameObject);
            gameManager.GetComponent<OrderManager>().removeOrder(originalOrder);
        }
        else if(originalList[2] == '2')
        {
            Destroy(order2.transform.GetChild(0).gameObject);
            gameManager.GetComponent<OrderManager>().removeOrder(originalOrder);
        }
        else if (originalList[2] == '3')
        {
            Destroy(order3.transform.GetChild(0).gameObject);
            gameManager.GetComponent<OrderManager>().removeOrder(originalOrder);
        }
        else if (originalList[2] == '4')
        {
            Destroy(order4.transform.GetChild(0).gameObject);
            gameManager.GetComponent<OrderManager>().removeOrder(originalOrder);
        }

        StartCoroutine(playSound());
        resultsScreen.SetActive(true);
        tavernButton.SetActive(false);
        LeanTween.scale(resultsScreen, new Vector3(0, 0, 0), 0.001f);
        LeanTween.scale(resultsScreen, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeOutElastic);
    }

    public void ReturnToGame()
    {
        resultsScreen.SetActive(false);
        tavernButton.SetActive(true);
        gameManager.GetComponent<MeadMinigameManager>().UpdateMeadCount();
    }

    IEnumerator playSound()
    {
        coinsJingle.Play();
        yield return new WaitForSeconds(2);
        coinsJingle.Stop();
    }
}
