using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeadMinigameManager : MonoBehaviour
{
    public GameObject kitchenScene;
    public GameObject meadMinigame;

    public GameObject meadAnim;

    public int meadCounter = 0;

    public GameObject meadTracker;

    public Sprite meadFull;
    public Sprite mead1;
    public Sprite mead2;
    public Sprite mead3;
    public Sprite meadEmpty;

    public AudioSource meadAudio;

    private void Update()
    {
        if(meadCounter == 4)
        {
            StartCoroutine(StartMeadAnim());
            meadCounter = 0;
            meadTracker.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = meadFull;
        }
    }

    public int GetMeadCount()
    {
        return meadCounter;
    }

    public void UpdateMeadCount()
    {
        meadCounter++;

        switch(meadCounter)
        {
            case 1:
                meadTracker.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = mead1;
                break;
            case 2:
                meadTracker.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = mead2;
                break;
            case 3:
                meadTracker.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = mead3;
                break;
            case 4:
                meadTracker.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = meadEmpty;
                break;
        }
    }

    IEnumerator StartMeadAnim()
    {
        LeanTween.moveLocal(meadAnim.gameObject, new Vector3(71, -46, 0), 1).setEase(LeanTweenType.easeOutElastic);
        meadAudio.Play();
        yield return new WaitForSeconds(2);
        LeanTween.move(meadAnim.gameObject, new Vector3(-2196, -448, 0), 2).setEase(LeanTweenType.easeInElastic);
        yield return new WaitForSeconds(3);
        kitchenScene.SetActive(false);
        meadMinigame.SetActive(true);
    }
}
