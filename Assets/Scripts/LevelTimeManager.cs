using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTimeManager : MonoBehaviour
{
    public GameObject gameManager;

    public TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        if(timerText.text == "")
        {
            //reload level
            gameManager.GetComponent<SceneLoader>().loadScene1();
        }
    }
}
