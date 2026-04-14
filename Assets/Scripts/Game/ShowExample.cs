using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowExample : MonoBehaviour, IPointerDownHandler
{
    public GameObject queues;
    public GameObject cartsRight;
    public GameObject exampleImage; //playerinfo
    public GameObject exampleText; //playerinfo

    public void OnPointerDown(PointerEventData eventData)
    {
        queues.GetComponent<Queues>().gameExample = true;

        exampleImage.SetActive(true);
        exampleText.SetActive(true);

        cartsRight.SetActive(false);

        gameObject.SetActive(false);
    }
}