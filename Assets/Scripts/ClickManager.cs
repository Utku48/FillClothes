// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ClickManager : MonoBehaviour
// {
//     public Camera cam;
//     private RaycastHit hit;
//     private Ray ray;
//     public GameObject scale;
//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             if (Physics.Raycast(ray, out hit))
//             {
//                 if (hit.collider.CompareTag("cell"))
//                 {
//                     if (hit.collider.gameObject.TryGetComponent(out Cell cell))
//                     {
//                         if (cam.GetComponent<ManagerForButton>().enabled == false)
//                         {



//                             Item currentItem = ItemMenager.Instance.GetCurrentItem();
//                             if (currentItem != null)
//                             {

//                                 if (cell.GridDolu == false)
//                                 {

//                                     currentItem.PlaceItemToGrid(cell.putPoint);
//                                     cell.GridDolu = true;
//                                     currentItem.transform.localScale = scale.transform.localScale;


//                                 }
//                                 else
//                                 {

//                                 }

//                             }

//                         }
//                     }

//                 }
//             }
//         }
//     }

// }
