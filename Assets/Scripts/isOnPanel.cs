using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isOnPanel : MonoBehaviour
{

    public GameObject Panel;



    public void On_Click()
    {

        if (Panel != null)
        {
            Panel.SetActive(true);
        }

    }
}
