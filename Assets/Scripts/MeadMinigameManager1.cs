using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeadMinigameManager1 : MonoBehaviour
{
    //Keeps track of which stage of the mead minigame the player is in
    public GameObject carboyTop;

    public GameObject meadScene;
    public GameObject kitchenScene;

    public GameObject tavernButton;

    public GameObject slider;

    public TextMeshProUGUI part1Text;
    public TextMeshProUGUI part2Text;
    public TextMeshProUGUI part3Text;

    public GameObject meadAnim;

    public AudioSource meadAudio;

    public void StartPartTwo()
    {
        part1Text.text = "";
        part2Text.text = "Click The Bottletop to Seal The Bottle!";
        this.GetComponent<MeadPour>().enabled = false;
        carboyTop.SetActive(true);
    }

    public void StartPartThree()
    {
        part2Text.text = "";
        part3Text.text = "Rapidly Click To Complete Fermentation!";
        carboyTop.GetComponent<PlaceCarboy>().enabled = false;
        this.GetComponent<MeadSpellClicker>().enabled = true;
        this.GetComponent<MeadSpellClicker>().StartPart();
    }

    public void EndMinigame()
    {
        part3Text.text = "";
        part1Text.text = "Hold Down On The Bottle To Fill!";

        this.GetComponent<MeadPour>().mead.transform.localScale = this.GetComponent<MeadPour>().meadOriginalScale;
        this.GetComponent<MeadPour>().mead.transform.localPosition = this.GetComponent<MeadPour>().meadOriginalPosition;

        carboyTop.transform.localPosition = new Vector3(-3.70329f, 3.371183f, 0);
        carboyTop.SetActive(false);

        this.GetComponent<MeadSpellClicker>().enabled = false;
        this.GetComponent<MeadPour>().enabled = true;

        StartCoroutine(meadEndAnim());
    }

    IEnumerator meadEndAnim()
    {
        LeanTween.moveLocal(meadAnim.gameObject, new Vector3(13, -51.4043f, 0), 1).setEase(LeanTweenType.easeOutElastic);
        meadAudio.Play();
        yield return new WaitForSeconds(2);
        LeanTween.move(meadAnim.gameObject, new Vector3(-2102, -51.4043f, 0), 2).setEase(LeanTweenType.easeInElastic);
        yield return new WaitForSeconds(3);
        kitchenScene.SetActive(true);
        meadScene.SetActive(false);
        tavernButton.SetActive(true);
    }
}
