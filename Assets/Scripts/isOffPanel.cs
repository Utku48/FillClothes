using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isOffPanel : MonoBehaviour
{

    public GameObject Panel;



    public void On_Click()
    {

        if (Panel != null)
        {
            Panel.SetActive(false);
        }

    }
}
