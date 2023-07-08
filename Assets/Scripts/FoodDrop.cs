using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDrop : MonoBehaviour
{
    private GameObject currentDrag;

    private void OnMouseDown()
    {
        if (currentDrag.transform.childCount > 0)
        {
            currentDrag.transform.GetChild(0).gameObject.GetComponent<FoodDrag>().beingDragged = false;
            currentDrag.transform.GetChild(0).transform.SetPositionAndRotation(this.gameObject.transform.position, Quaternion.identity);
            currentDrag.transform.GetChild(0).transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            currentDrag.transform.GetChild(0).SetParent(this.gameObject.transform);
            this.gameObject.GetComponent<CurrentPlateOrder>().updateOrder();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentDrag = GameObject.Find("CurrentDrag");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
