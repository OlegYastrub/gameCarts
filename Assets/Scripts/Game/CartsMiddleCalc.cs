using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartsMiddleCalc : MonoBehaviour
{
    public GameObject soundMng; //images inside game

    public GameObject[] cartsMiddle = new GameObject[4]; //images inside game
    public int[] cartsData = new int[4]; //data cart
    public int[] cartsDataOwner = new int[4]; //data cart

    public GameObject[] scorePlayers = new GameObject[4]; //score panel players
    public Text[] scorePlayersText = new Text[4]; //score text players

    public GameObject scoreDraws; //score panel draw
    public Text scoreDrawsText; //score text draw

    public Vector3[] beginPosition = new Vector3[4];

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            beginPosition[i] = cartsMiddle[i].transform.position;
        }
    }

    public void BackPosition()
    {
        for (int i = 0; i < 4; i++)
        {
            cartsMiddle[i].transform.position = beginPosition[i];
        }
    }

    public void ShowAllScores()
    {
        scoreDraws.SetActive(true);

        for (int i = 0; i < 4; i++)
        {
            scorePlayers[i].SetActive(true);
        }
    }

    public void HideAllScores()
    {
        scoreDraws.SetActive(false);

        for (int i = 0; i < 4; i++)
        {
            scorePlayers[i].SetActive(false);
        }
    }

    public void ShowAllCarts()
    {
        for (int i = 0; i < 4; i++)
        {
            cartsMiddle[i].SetActive(true);
        }
    }

    public void HideAllCarts()
    {
        for (int i = 0; i < 4; i++)
        {
            cartsMiddle[i].SetActive(false);
        }
    }

    public void SetCart(int numberSlot, int typeCart, int idOwner, bool show) //show - side of cart
    {
        soundMng.GetComponent<SoundManager>().PlaySound(0);

        Sprite cartSprite = Resources.Load<Sprite>("Carts/6kre");

        switch (typeCart)
        {
            case 1: { cartSprite = Resources.Load<Sprite>("Carts/6kre"); break; }
            case 2: { cartSprite = Resources.Load<Sprite>("Carts/6pik"); break; }
            case 3: { cartSprite = Resources.Load<Sprite>("Carts/6bub"); break; }
            case 4: { cartSprite = Resources.Load<Sprite>("Carts/6ch"); break; }
            case 5: { cartSprite = Resources.Load<Sprite>("Carts/7kre"); break; }
            case 6: { cartSprite = Resources.Load<Sprite>("Carts/7pik"); break; }
            case 7: { cartSprite = Resources.Load<Sprite>("Carts/7bub"); break; }
            case 8: { cartSprite = Resources.Load<Sprite>("Carts/7ch"); break; }
            case 9: { cartSprite = Resources.Load<Sprite>("Carts/8kre"); break; }
            case 10: { cartSprite = Resources.Load<Sprite>("Carts/8pik"); break; }
            case 11: { cartSprite = Resources.Load<Sprite>("Carts/8bub"); break; }
            case 12: { cartSprite = Resources.Load<Sprite>("Carts/8ch"); break; }
            case 13: { cartSprite = Resources.Load<Sprite>("Carts/9kre"); break; }
            case 14: { cartSprite = Resources.Load<Sprite>("Carts/9pik"); break; }
            case 15: { cartSprite = Resources.Load<Sprite>("Carts/9bub"); break; }
            case 16: { cartSprite = Resources.Load<Sprite>("Carts/9ch"); break; }
            case 17: { cartSprite = Resources.Load<Sprite>("Carts/10kre"); break; }
            case 18: { cartSprite = Resources.Load<Sprite>("Carts/10pik"); break; }
            case 19: { cartSprite = Resources.Load<Sprite>("Carts/10bub"); break; }
            case 20: { cartSprite = Resources.Load<Sprite>("Carts/10ch"); break; }
            case 21: { cartSprite = Resources.Load<Sprite>("Carts/Vkre"); break; }
            case 22: { cartSprite = Resources.Load<Sprite>("Carts/Vpik"); break; }
            case 23: { cartSprite = Resources.Load<Sprite>("Carts/Vbub"); break; }
            case 24: { cartSprite = Resources.Load<Sprite>("Carts/Vch"); break; }
            case 25: { cartSprite = Resources.Load<Sprite>("Carts/Dkre"); break; }
            case 26: { cartSprite = Resources.Load<Sprite>("Carts/Dpik"); break; }
            case 27: { cartSprite = Resources.Load<Sprite>("Carts/Dbub"); break; }
            case 28: { cartSprite = Resources.Load<Sprite>("Carts/Dch"); break; }
            case 29: { cartSprite = Resources.Load<Sprite>("Carts/Kkre"); break; }
            case 30: { cartSprite = Resources.Load<Sprite>("Carts/Kpik"); break; }
            case 31: { cartSprite = Resources.Load<Sprite>("Carts/Kbub"); break; }
            case 32: { cartSprite = Resources.Load<Sprite>("Carts/Kch"); break; }
            case 33: { cartSprite = Resources.Load<Sprite>("Carts/Tkre"); break; }
            case 34: { cartSprite = Resources.Load<Sprite>("Carts/Tpik"); break; }
            case 35: { cartSprite = Resources.Load<Sprite>("Carts/Tbub"); break; }
            case 36: { cartSprite = Resources.Load<Sprite>("Carts/Tch"); break; }
        }

        if(show)
            cartsMiddle[numberSlot].GetComponent<Image>().sprite = cartSprite;
        else
            cartsMiddle[numberSlot].GetComponent<Image>().sprite = Resources.Load<Sprite>("Carts/cartRb2");

        cartsData[numberSlot] = typeCart;
        cartsDataOwner[numberSlot] = idOwner;
    }
}
