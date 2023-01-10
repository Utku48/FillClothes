using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImages : MonoBehaviour
{
    public Sprite newbuttonImage;
    public Button button;

    public void ChangeSprite()
    {
        button.image.sprite = newbuttonImage;

    }

}
