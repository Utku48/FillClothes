using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool GridDolu;
    public Transform putPoint;
    private GameObject PutObject;

    void Start()
    {
        PutObject = transform.GetChild(0).gameObject;//Put Object'imiz = Scriptin oldugu gameObjenin ilk Child objesi
    }

    void Update()
    {
        if (PutObject.transform.childCount < 1)//PutObjenin Child sayısı 1'den küçü
        {
            GridDolu = false;
        }
    }
}
