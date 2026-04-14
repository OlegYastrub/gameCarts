using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPlayerCart : MonoBehaviour
{
    public GameObject[] cartsPlayer = new GameObject[9]; //images inside game
    public GameObject playersbots; //playerinfo
    public Sprite casr;

    void Start()
    {
       
    }

    public void LoadCarts()
    {
        Debug.Log(playersbots.GetComponent<PlayerBots>().playerCarts[0]);

        SetCart(0, playersbots.GetComponent<PlayerBots>().playerCarts[0]);
        SetCart(1, playersbots.GetComponent<PlayerBots>().playerCarts[1]);
        SetCart(2, playersbots.GetComponent<PlayerBots>().playerCarts[2]);
        SetCart(3, playersbots.GetComponent<PlayerBots>().playerCarts[3]);
        SetCart(4, playersbots.GetComponent<PlayerBots>().playerCarts[4]);
        SetCart(5, playersbots.GetComponent<PlayerBots>().playerCarts[5]);
        SetCart(6, playersbots.GetComponent<PlayerBots>().playerCarts[6]);
        SetCart(7, playersbots.GetComponent<PlayerBots>().playerCarts[7]);
        SetCart(8, playersbots.GetComponent<PlayerBots>().playerCarts[8]);
    }

    void SetCart(int numberSlot, int numberCart)
    {
        switch (numberCart)
        {
            case 1: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/6kre"); break; }
            case 2: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/6pik"); break; }
            case 3: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/6bub"); break; }
            case 4: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/6ch"); break; }
            case 5: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/7kre"); break; }
            case 6: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/7pik"); break; }
            case 7: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/7bub"); break; }
            case 8: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/7ch"); break; }
            case 9: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/8kre"); break; }
            case 10: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/8pik"); break; }
            case 11: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/8bub"); break; }
            case 12: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/8ch"); break; }
            case 13: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/9kre"); break; }
            case 14: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/9pik"); break; }
            case 15: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/9bub"); break; }
            case 16: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/9ch"); break; }
            case 17: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/10kre"); break; }
            case 18: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/10pik"); break; }
            case 19: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/10bub"); break; }
            case 20: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/10ch"); break; }
            case 21: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Vkre"); break; }
            case 22: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Vpik"); break; }
            case 23: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Vbub"); break; }
            case 24: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Vch"); break; }
            case 25: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Dkre"); break; }
            case 26: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Dpik"); break; }
            case 27: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Dbub"); break; }
            case 28: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Dch"); break; }
            case 29: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Kkre"); break; }
            case 30: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Kpik"); break; }
            case 31: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Kbub"); break; }
            case 32: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Kch"); break; }
            case 33: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Tkre"); break; }
            case 34: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Tpik"); break; }
            case 35: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Tbub"); break; }
            case 36: { cartsPlayer[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/Tch"); break; }
        }
    }
    
    void Update()
    {
        
    }
}
