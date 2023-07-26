using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnim : MonoBehaviour
{
    public GameObject button1;
    public GameObject button3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MenuAnim());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MenuAnim()
    {
        LeanTween.scale(button1, new Vector3(0, 0, 0), 0.1f);
        LeanTween.scale(button3, new Vector3(0, 0, 0), 0.1f);
        yield return new WaitForSeconds(3);
        LeanTween.scale(button1, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(button3, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeOutElastic);
    }
}
