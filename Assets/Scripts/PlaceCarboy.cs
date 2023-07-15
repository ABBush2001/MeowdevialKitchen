using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceCarboy : MonoBehaviour
{

    public GameObject carboy;

    public Vector3 carboyOriginalPosition;

    public AudioSource corkSound;

    // Start is called before the first frame update
    void Start()
    {
        carboyOriginalPosition = carboy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        LeanTween.moveLocalY(this.gameObject, -0.5f, 0.5f);
        corkSound.Play();
        carboy.GetComponent<MeadMinigameManager1>().StartPartThree();
    }


}
