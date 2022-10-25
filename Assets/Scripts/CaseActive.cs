
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseActive : MonoBehaviour
{

    public static bool isOn = false;
    public bool isSelected = false;

    [SerializeField] private Color color, color2;

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Case")
                {
                    if (hit.collider.gameObject.GetComponent<CaseActive>().isSelected == false)
                    {

                        hit.collider.gameObject.GetComponent<CaseActive>().isSelected = true;
                        hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = color;
                        isOn = true;


                    }
                    else
                    {
                        for (int i = 0; i < gameObject.transform.parent.GetComponent<CaseControl>().CaseList.Count; i++)
                        {
                            gameObject.transform.parent.GetComponent<CaseControl>().CaseList[i].isSelected = false;
                            gameObject.transform.parent.GetComponent<CaseControl>().CaseList[i].gameObject.GetComponent<MeshRenderer>().material.color = color2;
                            isOn = false;
                        }

                    }
                }
            }
        }
    }
}




