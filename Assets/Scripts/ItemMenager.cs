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

    public Vector3 inCase1Position;
    public Quaternion inCase1Rotation;

    public Vector3 inCase2Position;
    public Quaternion inCase2Rotation;


    private void Awake()
    {
        inCase1Position = new Vector3(0.5f, 1, 0);
        inCase1Rotation = Quaternion.Euler(new Vector3(90, 0, 0));

        inCase2Position = new Vector3(0.6f, 1, 0);
        inCase2Rotation = Quaternion.Euler(new Vector3(90, 0, 0));

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        for (int i = 0; i < 8; i++)
        {
            GameObject temp = Instantiate(itemToPush, Push1Parent.transform);
            temp.transform.localPosition = inCase1Position;
            temp.transform.localRotation = inCase1Rotation;

            GameObject temp2 = Instantiate(itemToPush2, Push2Parent.transform);
            temp2.transform.localPosition = inCase2Position;
            temp2.transform.localRotation = inCase2Rotation;

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
