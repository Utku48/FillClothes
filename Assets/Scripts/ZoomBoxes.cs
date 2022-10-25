using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ZoomBoxes : MonoBehaviour
{
    public GameObject Cases;
    public GameObject TargetPos;
    public GameObject TargetPos2;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Mouse'a tıkladıgımda
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//Işın gönder
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))//Işının çarptığı obje bilgilerini hit'de tut
            {
                if (hit.transform.tag == "Raf")//Eğer Işının çarptığı objenin tag'i Raf ise
                {
                    //  TargetPos = hit.transform.gameObject;//Target Objem hit'in çarptıgı gameObject'in transformu
                    ZoomCamera(TargetPos.transform);
                }
                else if (hit.transform.tag == "Raf2")
                {
                    ZoomCamera2(TargetPos2.transform);
                }
            }
        }

    }
    public void ZoomCamera(Transform target)// Parantez içi = TargetObject oldu.
    {
        //Vector3 pos = target.localPosition;
        //pos.z -= 1.47f;
        transform.DOMove(TargetPos.transform.localPosition, 2);
    }
    public void ZoomCamera2(Transform target)
    {
        transform.DOMove(TargetPos2.transform.localPosition, 2);
    }
}
