using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool put;
    public Transform parent;
    private int ItemNumber;
    public Material TriggerMaterial;
    public Material DefaultMaterial;


    void Start()
    {

        parent = transform.parent;//Parent Case
        DefaultMaterial = GetComponent<MeshRenderer>().material;


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

    //IEnumerator istediğimiz yerde tek bir kere,belirli aralıklarla çalışabilir.
    //performans için Update yerine kullanılır.
    IEnumerator ItemToItem()
    {
        gameObject.GetComponent<MeshRenderer>().material = TriggerMaterial;
        yield return new WaitForSeconds(0.1f);
        put = false;
        transform.parent = parent;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        ItemMenager.Instance.itemList.Push(gameObject);
        Debug.Log(ItemMenager.Instance.itemList.Count);
        gameObject.GetComponent<MeshRenderer>().material = DefaultMaterial;
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
                    StartCoroutine(ItemToItem());
                }


            }

        }

    }


}
