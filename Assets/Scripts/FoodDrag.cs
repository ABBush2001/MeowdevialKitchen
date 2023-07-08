using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDrag : MonoBehaviour
{
    public bool beingDragged = false;

    private void OnMouseDown()
    {
        beingDragged = true;
        Debug.Log("Being Dragged!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(beingDragged)
        {
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.transform.SetParent(GameObject.Find("CurrentDrag").transform);
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z += Camera.main.nearClipPlane;
            this.gameObject.transform.SetPositionAndRotation(mousePosition, Quaternion.identity);
        }
    }
}
