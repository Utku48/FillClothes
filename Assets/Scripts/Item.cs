using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool put;
    public Transform parent;
    private int ItemNumber;


    void Start()
    {

        parent = transform.parent;//Parent Case


    }


    public void PlaceItemToGrid(Transform placingTransform)//Parantezin içi koyulacaağı yer
    {

        //Yerleşecek olan Item Yerleştiği Grid'in parenti'i haline gelecek

        transform.parent = placingTransform;
        if (placingTransform.parent.GetComponent<Cell>().GridDolu == false)
        {
            Vector3 pos = Vector3.zero;
            pos.y += 0.5f;
            transform.localPosition = pos;
            transform.localRotation = Quaternion.Euler(Vector3.zero);
            put = true;
            ItemNumber = ItemMenager.Instance.ItemNo;
            ItemMenager.Instance.ItemNo++;
        }

    }



    void OnTriggerEnter(Collider other)
    {

        Item obj = other.GetComponent<Item>();//Temas edilen objenin içinde Item Comp.'a bakar


        if (obj)

        {
            if (obj.put == true)
            {

                if (ItemNumber > obj.ItemNumber)
                {
                    put = false;
                    transform.parent = parent;
                    transform.localPosition = Vector3.zero;
                    transform.localRotation = Quaternion.Euler(Vector3.zero);
                    ItemMenager.Instance.itemList.Push(gameObject);
                    Debug.Log(ItemMenager.Instance.itemList.Count);
                }


            }

        }

    }


}
