using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartsWon : MonoBehaviour
{
    public GameObject[] cartsWinBot1 = new GameObject[36]; //images inside game
    public GameObject[] cartsWinBot2 = new GameObject[36]; //images inside game
    public GameObject[] cartsWinBot3 = new GameObject[36]; //images inside game
    public GameObject[] cartsWinYour = new GameObject[36]; //images inside game

    public int[] dataCartsWinBot1 = new int[36]; //data inside game
    public int[] dataCartsWinBot2 = new int[36]; //data inside game
    public int[] dataCartsWinBot3 = new int[36]; //data inside game
    public int[] dataCartsWinYour = new int[36]; //data inside game

    public int GetIdxToAdd(int countStack)
    {
        int last = -1;

        switch (countStack)
        {
            case 0:
                {
                    for(int i = 0; i < 36; i++)
                    {
                        if (dataCartsWinYour[i] != 0)
                            last = i;
                    }
                    break;
                }
            case 1:
                {
                    for (int i = 0; i < 36; i++)
                    {
                        if (dataCartsWinBot1[i] != 0)
                            last = i;
                    }
                    break;
                }
            case 2:
                {
                    for (int i = 0; i < 36; i++)
                    {
                        if (dataCartsWinBot2[i] != 0)
                            last = i;
                    }
                    break;
                }
            case 3:
                {
                    for (int i = 0; i < 36; i++)
                    {
                        if (dataCartsWinBot3[i] != 0)
                            last = i;
                    }
                    break;
                }
        }
        return last;
    }

    public void SetCart(int countStack, int numberSlot, int typeCart)
    {
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

        switch (countStack)
        {
            case 0:
                {
                    // Debug.Log('Type' + typeCart)
                    cartsWinYour[numberSlot].SetActive(true);
                    cartsWinYour[numberSlot].GetComponent<Image>().sprite = cartSprite;
                    dataCartsWinYour[numberSlot] = typeCart;
                    break;
                }
            case 1:
                {
                    cartsWinBot1[numberSlot].SetActive(true);
                    cartsWinBot1[numberSlot].GetComponent<Image>().sprite = cartSprite;
                    dataCartsWinBot1[numberSlot] = typeCart;
                    break;
                }
            case 2:
                {
                    cartsWinBot2[numberSlot].SetActive(true);
                    cartsWinBot2[numberSlot].GetComponent<Image>().sprite = cartSprite;
                    dataCartsWinBot2[numberSlot] = typeCart;
                    break;
                }
            case 3:
                {
                    cartsWinBot3[numberSlot].SetActive(true);
                    cartsWinBot3[numberSlot].GetComponent<Image>().sprite = cartSprite;
                    dataCartsWinBot3[numberSlot] = typeCart;
                    break;
                }
        }
    }
}
