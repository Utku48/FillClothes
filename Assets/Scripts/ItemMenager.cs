using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMenager : MonoBehaviour
{
    public Stack<GameObject> itemList = new Stack<GameObject>();
    public GameObject itemToPush;
    public GameObject itemToPush2;
    public GameObject Push1Parent;
    public GameObject Push2Parent;
    public int ItemNo = 0;
    public static ItemMenager Instance;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        for (int i = 0; i < 5; i++)
        {
            GameObject temp = Instantiate(itemToPush, Push1Parent.transform);
            GameObject temp2 = Instantiate(itemToPush2, Push2Parent.transform);

            itemList.Push(temp2);
            itemList.Push(temp);

        }

    }
    public Item GetCurrentItem()
    {
        if (itemList.Count != 0)
        {


            if (itemList.Pop().TryGetComponent(out Item currentItem))
            {
                return currentItem;

            }

        }
        return null;
    }

}
