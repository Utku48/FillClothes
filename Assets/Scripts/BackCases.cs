using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BackCases : MonoBehaviour
{
    public GameObject Cases;
    public Transform SpawnCases;


    public void On_Clikced2()
    {

        Vector3 pos = Cases.transform.position;
        pos = SpawnCases.transform.position;
        transform.DOMove(pos, 2);

        //z= -1.7

    }
}

