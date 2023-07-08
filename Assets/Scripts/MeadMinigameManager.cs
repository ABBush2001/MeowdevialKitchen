using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeadMinigameManager : MonoBehaviour
{
    private int meadCounter = 0;

    public int GetMeadCount()
    {
        return meadCounter;
    }

    public void UpdateMeadCount()
    {
        meadCounter++;
    }
}
