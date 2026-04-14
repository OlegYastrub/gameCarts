using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HideCart : MonoBehaviour, IPointerDownHandler
{
    public GameObject cartShow;

    public void OnPointerDown(PointerEventData eventData)
    {
        cartShow.SetActive(false);
    }
}

