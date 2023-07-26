using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject Camera;

    public void loadScene1()
    {
        StartCoroutine(nextLevel());
    }

    public void loadScene2()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator nextLevel()
    {
        Camera.GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
