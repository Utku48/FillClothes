using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerForButton : MonoBehaviour
{


    public Transform SpawnPush1;
    public Transform SpawnPush2;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))//Mouse'a tıkladıgımda
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//Işın gönder
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Item item = hit.collider.GetComponent<Item>();

                if (item && hit.collider.CompareTag("tshirt"))
                {
                    item.put = false;
                    item.transform.parent = SpawnPush1;
                    item.gameObject.transform.localPosition = Vector3.zero;
                    item.gameObject.transform.localScale = new Vector3(3, 3, 3);
                    GameObject temp = item.gameObject;

                    ItemMenager.Instance.itemList.Push(temp);

                    // Debug.Log(ItemMenager.Instance.itemList.Count);
                }
                else if (item && hit.collider.CompareTag("shirt"))
                {
                    item.put = false;
                    item.transform.parent = SpawnPush2;
                    item.gameObject.transform.localPosition = Vector3.zero;
                    item.gameObject.transform.localScale = new Vector3(2.5f, 3, 2.5f);
                    GameObject temp2 = item.gameObject;

                    ItemMenager.Instance.itemList.Push(temp2);

                    Debug.Log(ItemMenager.Instance.itemList.Count);
                }

            }
        }
    }
}


