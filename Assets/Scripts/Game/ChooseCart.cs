using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCart : MonoBehaviour, IPointerDownHandler
{
    public Text yourtext;

    public int slotCart;

    public GameObject playersbots; //playerinfo
    public GameObject stacksMiddle; //stack of carts on middle
    public GameObject queues; //playerinfo
    public GameObject[] cartsPlayer = new GameObject[9]; //images inside game

    public void OnPointerDown(PointerEventData eventData)
    {
        if (queues.GetComponent<Queues>().meQueue)
        {
            gameObject.SetActive(false);

            //Debug.Log(playersbots.GetComponent<PlayerBots>().playerCarts[slotCart]);
            stacksMiddle.GetComponent<CartsMiddle>().SetCart(queues.GetComponent<Queues>().countQueues, 0, playersbots.GetComponent<PlayerBots>().playerCarts[slotCart], true, 0);

            playersbots.GetComponent<PlayerBots>().playerCarts[slotCart] = -1;

            yourtext.text = "Ждите!\nСейчас ходит игрок №1";
            yourtext.fontSize = 35;

            queues.GetComponent<Queues>().meQueue = false;
            queues.GetComponent<Queues>().playerOneQueue = true;
        }
       // playerOneQueue = true;
        //if ()
    }
}
