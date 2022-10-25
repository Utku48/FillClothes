
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBackButton : MonoBehaviour
{

    public bool OnOff = false;
    public Camera cam;
    public GameObject CamBackPos;
    public GameObject button;
    public static bool check = false;

    void Update()
    {
        if (cam.transform.position != CamBackPos.transform.position)
        {
            button.SetActive(true);
            check = true;

        }
        else
        {
            button.SetActive(false);
            check = false;

        }

    }
    public void On_CLick()
    {
        if (!OnOff)
        {
            OnOff = true;
            cam.GetComponent<ManagerForButton>().enabled = true;
        }
        else
        {
            OnOff = false;
            cam.GetComponent<ManagerForButton>().enabled = false;
        }
    }
}
