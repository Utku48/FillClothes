using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DragBoxes : MonoBehaviour
{
    float directionX;
    float MousePositionX;
    public float Limit;
    public float SwerveValue;





    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//Işın gönder
        RaycastHit hit;
        //Swerve Mekaniği
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = transform.localPosition;
            directionX = position.x;
            MousePositionX = Camera.main.ScreenToViewportPoint(Input.mousePosition).x;//Mouse'nin İlk konumunu alıp  MousePositionX'e atıyor. Yani SpawnPos


        }
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit))//Işının çarptığı obje bilgilerini hit'de tut
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Case"))
                {

                    float NewMousePositionX = Camera.main.ScreenToViewportPoint(Input.mousePosition).x;//Mouse'nin anlık konumunu alıp  MousePositionX'e atıyor.
                    float distanceX = NewMousePositionX - MousePositionX;//AnlıkKonum-İlkKonum

                    float positionX = directionX + (distanceX * SwerveValue);//Hızını ayarladık

                    positionX = Mathf.Clamp(positionX/*<=SınırlandırılanDeğer*/, -Limit, +Limit);//Gidilecek MaksPos ile MinPos'u ayarladık.
                    Vector3 position = transform.localPosition;
                    position.x = positionX;
                    transform.localPosition = position;



                }
            }
        }
    }
}

