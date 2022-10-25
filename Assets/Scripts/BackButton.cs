using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BackButton : MonoBehaviour
{
    //BURASI BACK BUTTON DEĞİL TİK BUTTON'DUR // SORGULAMA // MENÇİSTIR KIRMIZIDIR //
    public Camera cam;
    public GameObject CamBackPos;
    public GameObject button;


    void Update()
    {
        if (cam.transform.position != CamBackPos.transform.position)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
    public void OnClick()
    {

        Vector3 kameraPos = cam.transform.position;
        kameraPos = CamBackPos.transform.position;
        transform.DOMove(kameraPos, 2);
        transform.DORotate(new Vector3(46, 0, 0), 2);
    }

}
