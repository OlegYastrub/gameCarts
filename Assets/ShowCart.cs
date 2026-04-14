using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowCart : MonoBehaviour, IPointerDownHandler
{
    public GameObject cartShow;
    public GameObject cartHide;

    // Start is called before the first frame update
    void Start()
    {
        cartShow.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        cartShow.SetActive(true);
    }
}
