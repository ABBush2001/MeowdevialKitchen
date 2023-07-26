using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDrop : MonoBehaviour
{
    private GameObject currentDrag;

    private bool isEntree = false;
    private bool entreeAlreadyExists = false;
    private bool isSide = false;
    private bool sideExists = false;

    private void OnMouseDown()
    {
        if (currentDrag.transform.childCount > 0)
        {
            //Activate food on plate and destroy dragged object
            string food = currentDrag.transform.GetChild(0).name.Replace("(Clone)", "");

            Debug.Log(this.transform.childCount);

            for (int i = 0; i < this.transform.childCount; i++)
            {
                //look through entrees
                if(this.transform.GetChild(i).name == "Entree" && entreeAlreadyExists == false)
                {
                    GameObject e_tmp = this.transform.GetChild(i).gameObject;

                    for(int j = 0; j < e_tmp.transform.childCount; j++)
                    {
                        //if the entree
                        if(e_tmp.transform.GetChild(j).name == food)
                        {
                            isEntree = true;
                        }
                        else if(e_tmp.transform.GetChild(j).gameObject.activeSelf)
                        {
                            entreeAlreadyExists = true;
                        }
                    }

                    if (isEntree && !entreeAlreadyExists)
                    {
                        for (int a = 0; a < this.transform.GetChild(i).transform.childCount; a++)
                        {
                            if (this.transform.GetChild(i).transform.GetChild(a).name == food)
                            {
                                this.transform.GetChild(i).transform.GetChild(a).gameObject.SetActive(true);
                                Destroy(currentDrag.transform.GetChild(0).gameObject);
                                this.gameObject.GetComponent<CurrentPlateOrder>().updateOrder();
                            }
                        }

                    }

                }
                else if(this.transform.GetChild(i).name == "Sides" && sideExists == false)
                {

                    GameObject s_tmp = this.transform.GetChild(i).gameObject;

                    for(int k = 0; k < s_tmp.transform.childCount; k++)
                    {
                        //if the side
                        if(s_tmp.transform.GetChild(k).gameObject.name == food)
                        {
                            isSide = true;
                        }
                        else if(s_tmp.transform.GetChild(k).gameObject.activeSelf)
                        {
                            sideExists = true;
                        }
                    }

                    if (isSide && !sideExists)
                    {
                        for (int a = 0; a < this.transform.GetChild(i).transform.childCount; a++)
                        {
                            if (this.transform.GetChild(i).transform.GetChild(a).name == food)
                            {
                                this.transform.GetChild(i).transform.GetChild(a).gameObject.SetActive(true);
                                Destroy(currentDrag.transform.GetChild(0).gameObject);
                                this.gameObject.GetComponent<CurrentPlateOrder>().updateOrder();
                            }
                        }
                    }
                }


            }


            /*currentDrag.transform.GetChild(0).gameObject.GetComponent<FoodDrag>().beingDragged = false;
            currentDrag.transform.GetChild(0).transform.SetPositionAndRotation(this.gameObject.transform.position, Quaternion.identity);
            currentDrag.transform.GetChild(0).transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            currentDrag.transform.GetChild(0).SetParent(this.gameObject.transform);
            this.gameObject.GetComponent<CurrentPlateOrder>().updateOrder();*/
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
