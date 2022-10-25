using System.Globalization;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraMove : MonoBehaviour
{

    public Camera MainCamera;
    private RaycastHit hit;
    private Ray ray;
    private GameObject TargetObject;
    public GameObject scale;
    public GameObject scale2;
    public Transform ZoomTarget;
    public Transform ZoomTarget2;
    public List<CaseActive> kontrol;



    void Update()
    {

        if (Input.GetMouseButtonDown(0))//Mouse'a tıkladıgımda
        {
            ray = MainCamera.ScreenPointToRay(Input.mousePosition);//Işın gönder


            if (Physics.Raycast(ray, out hit))//Işının çarptığı obje bilgilerini hit'de tut
            {
                if (hit.transform.tag == "Raf")//Eğer Işının çarptığı objenin tag'i Raf ise
                {

                    // TargetObject = hit.transform.gameObject;//Target Objem hit'in çarptıgı gameObject'in transformu
                    ZoomCamera(ZoomTarget.transform);

                }
                else if (hit.transform.tag == "Raf2")
                {
                    ZoomCamera2(ZoomTarget2.transform);

                }


                //Yerleştirme
                if (hit.collider.CompareTag("cell"))
                {
                    if (hit.collider.gameObject.TryGetComponent(out Cell cell) && TakeBackButton.check == true)
                    {
                        if (MainCamera.GetComponent<ManagerForButton>().enabled == false)
                        {


                            #region Seçili olan Case'in Child Objelerinin yerleştirilmesi

                            CaseActive aktifcase = null;
                            for (int i = 0; i < kontrol.Count; i++)//listeyi döndür
                            {
                                if (kontrol[i].isSelected == true)//isSelected'i true olanı al
                                {
                                    aktifcase = kontrol[i];//aktifcase yap
                                }
                            }

                            if (aktifcase.transform.childCount > 0)//aktifcase child'ı > 0 ise

                            #endregion seçili olan Case'nin Child Objelerinin yerleştirilmesi

                            {
                                Item currentItem = ItemMenager.Instance.GetCurrentItem();
                                if (currentItem != null)
                                {

                                    if (cell.GridDolu == false)
                                    {

                                        aktifcase.transform.GetChild(0).GetComponent<Item>().PlaceItemToGrid(cell.putPoint);
                                        cell.GridDolu = true;
                                        // currentItem.transform.localScale = scale.transform.localScale;


                                    }


                                }
                            }

                        }
                    }


                }
            }
        }
    }
    public void ZoomCamera(Transform target)// Parantez içi = TargetObject oldu.
    {
        transform.DOMove(ZoomTarget.transform.position, 2);
        transform.DORotate(new Vector3(51, 0, 0), 2);


    }
    public void ZoomCamera2(Transform target)
    {
        transform.DOMove(ZoomTarget2.transform.position, 2);
        transform.DORotate(new Vector3(51, 0, 0), 2);


    }

}




