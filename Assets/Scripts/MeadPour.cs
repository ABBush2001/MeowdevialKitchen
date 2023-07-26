using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MeadPour : MonoBehaviour
{
    public GameObject mead;

    public Sprite emptymead;
    public Sprite fullmead;

    public Sprite m1;
    public Sprite m2;
    public Sprite m3;

    public Vector3 meadOriginalScale;
    public Vector3 meadOriginalPosition;

    public AudioSource meadPourSound;

    private void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = emptymead;
        meadOriginalScale = mead.transform.localScale;
        meadOriginalPosition = mead.transform.localPosition;
    }

    private void Update()
    {
        if (mead.transform.localScale.y >= 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = fullmead;
            this.GetComponent<MeadMinigameManager1>().StartPartTwo();
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(pourMead());
    }

    IEnumerator pourMead()
    {
        if (this.GetComponent<SpriteRenderer>().sprite != fullmead)
        {
            meadPourSound.Play();
        }

        while(mead.transform.localScale.y < 1 && mead.transform.localPosition.y > -1.6f && Input.GetMouseButton(0))
        {
            mead.transform.localScale += new Vector3(0, 0.025f, 0);
            mead.transform.localPosition += new Vector3(0, 0.0125f, 0);
            yield return new WaitForSeconds(0.025f);

            if(mead.transform.localScale.y > 0.25 && mead.transform.localScale.y < 0.5)
            {
                this.GetComponent<SpriteRenderer>().sprite = m1;
            }
            else if(mead.transform.localScale.y > 0.5 && mead.transform.localScale.y < 0.75)
            {
                this.GetComponent<SpriteRenderer>().sprite = m2;
            }
            else if(mead.transform.localScale.y > 0.75 && mead.transform.localScale.y < 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = m3;
            }
        }
    }
}
