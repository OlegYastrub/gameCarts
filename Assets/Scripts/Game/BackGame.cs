using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackGame : MonoBehaviour, IPointerDownHandler
{
    public GameObject queues;
    public GameObject cartsRight;
    public GameObject exampleGame; //playerinfo
    public GameObject exampleText; //playerinfo
    public GameObject exampleImage; //playerinfo

    public void OnPointerDown(PointerEventData eventData)
    {
        if(queues.GetComponent<Queues>().gameExample)
        {
            exampleText.SetActive(false);
            exampleImage.SetActive(false);

            queues.GetComponent<Queues>().gameExample = false;

            cartsRight.SetActive(true);
            exampleGame.SetActive(true);
        }
        else
        {
            cartsRight.SetActive(false);
            exampleGame.SetActive(false);

            cartsRight.GetComponent<CartsMiddleRight>().BackPosition();
            queues.GetComponent<Queues>().cartToRightBack = true;
        }
    }
}
