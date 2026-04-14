using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartsMiddle : MonoBehaviour
{
    public GameObject soundMng; //images inside game

    public GameObject[] cartsMiddle1 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle2 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle3 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle4 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle5 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle6 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle7 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle8 = new GameObject[4]; //images inside game
    public GameObject[] cartsMiddle9 = new GameObject[4]; //images inside game

    public int[] cartsData1 = new int[4]; //data cart
    public int[] cartsData2 = new int[4]; //images inside game
    public int[] cartsData3 = new int[4]; //images inside game
    public int[] cartsData4 = new int[4]; //images inside game
    public int[] cartsData5 = new int[4]; //images inside game
    public int[] cartsData6 = new int[4]; //images inside game
    public int[] cartsData7 = new int[4]; //images inside game
    public int[] cartsData8 = new int[4]; //images inside game
    public int[] cartsData9 = new int[4]; //images inside game

    public int[] cartsData1Owner = new int[4]; //data cart
    public int[] cartsData2Owner = new int[4]; //images inside game
    public int[] cartsData3Owner = new int[4]; //images inside game
    public int[] cartsData4Owner = new int[4]; //images inside game
    public int[] cartsData5Owner = new int[4]; //images inside game
    public int[] cartsData6Owner = new int[4]; //images inside game
    public int[] cartsData7Owner = new int[4]; //images inside game
    public int[] cartsData8Owner = new int[4]; //images inside game
    public int[] cartsData9Owner = new int[4]; //images inside game

    public void SetCart(int countStack, int numberSlot, int typeCart, bool show, int idOwner) //show - side of cart
    {
        soundMng.GetComponent<SoundManager>().PlaySound(0);

        if (show)
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
                        cartsMiddle1[numberSlot].SetActive(true);
                        cartsMiddle1[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData1[numberSlot] = typeCart;
                        cartsData1Owner[numberSlot] = idOwner;
                        break;
                    }
                case 1:
                    {
                        cartsMiddle2[numberSlot].SetActive(true);
                        cartsMiddle2[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData2[numberSlot] = typeCart;
                        cartsData2Owner[numberSlot] = idOwner;
                        break;
                    }
                case 2:
                    {
                        cartsMiddle3[numberSlot].SetActive(true);
                        cartsMiddle3[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData3[numberSlot] = typeCart;
                        cartsData3Owner[numberSlot] = idOwner;
                        break;
                    }
                case 3:
                    {
                        cartsMiddle4[numberSlot].SetActive(true);
                        cartsMiddle4[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData4[numberSlot] = typeCart;
                        cartsData4Owner[numberSlot] = idOwner;
                        break;
                    }
                case 4:
                    {
                        cartsMiddle5[numberSlot].SetActive(true);
                        cartsMiddle5[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData5[numberSlot] = typeCart;
                        cartsData5Owner[numberSlot] = idOwner;
                        break;
                    }
                case 5:
                    {
                        cartsMiddle6[numberSlot].SetActive(true);
                        cartsMiddle6[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData6[numberSlot] = typeCart;
                        cartsData6Owner[numberSlot] = idOwner;
                        break;
                    }
                case 6:
                    {
                        cartsMiddle7[numberSlot].SetActive(true);
                        cartsMiddle7[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData7[numberSlot] = typeCart;
                        cartsData7Owner[numberSlot] = idOwner;
                        break;
                    }
                case 7:
                    {
                        cartsMiddle8[numberSlot].SetActive(true);
                        cartsMiddle8[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData8[numberSlot] = typeCart;
                        cartsData8Owner[numberSlot] = idOwner;
                        break;
                    }
                case 8:
                    {
                        cartsMiddle9[numberSlot].SetActive(true);
                        cartsMiddle9[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData9[numberSlot] = typeCart;
                        cartsData9Owner[numberSlot] = idOwner;
                        break;
                    }
            }
        }
        else
        {
            switch (countStack)
            {
                case 0:
                    {
                        // Debug.Log('Type' + typeCart)
                        cartsMiddle1[numberSlot].SetActive(true);
                        cartsData1[numberSlot] = typeCart;
                        cartsData1Owner[numberSlot] = idOwner;
                        break;
                    }
                case 1:
                    {
                        cartsMiddle2[numberSlot].SetActive(true);
                        cartsData2[numberSlot] = typeCart;
                        cartsData2Owner[numberSlot] = idOwner;
                        break;
                    }
                case 2:
                    {
                        cartsMiddle3[numberSlot].SetActive(true);
                        cartsData3[numberSlot] = typeCart;
                        cartsData3Owner[numberSlot] = idOwner;
                        break;
                    }
                case 3:
                    {
                        cartsMiddle4[numberSlot].SetActive(true);
                        cartsData4[numberSlot] = typeCart;
                        cartsData4Owner[numberSlot] = idOwner;
                        break;
                    }
                case 4:
                    {
                        cartsMiddle5[numberSlot].SetActive(true);
                        cartsData5[numberSlot] = typeCart;
                        cartsData5Owner[numberSlot] = idOwner;
                        break;
                    }
                case 5:
                    {
                        cartsMiddle6[numberSlot].SetActive(true);
                        cartsData6[numberSlot] = typeCart;
                        cartsData6Owner[numberSlot] = idOwner;
                        break;
                    }
                case 6:
                    {
                        cartsMiddle7[numberSlot].SetActive(true);
                        cartsData7[numberSlot] = typeCart;
                        cartsData7Owner[numberSlot] = idOwner;
                        break;
                    }
                case 7:
                    {
                        cartsMiddle8[numberSlot].SetActive(true);
                        cartsData8[numberSlot] = typeCart;
                        cartsData8Owner[numberSlot] = idOwner;
                        break;
                    }
                case 8:
                    {
                        cartsMiddle9[numberSlot].SetActive(true);
                        cartsData9[numberSlot] = typeCart;
                        cartsData9Owner[numberSlot] = idOwner;
                        break;
                    }
            }
        }
    }
    
    public void HideAllCarts()
    {
        for(int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 0: { cartsMiddle1[j].SetActive(false); break; }
                    case 1: { cartsMiddle2[j].SetActive(false); break; }
                    case 2: { cartsMiddle3[j].SetActive(false); break; }
                    case 3: { cartsMiddle4[j].SetActive(false); break; }
                    case 4: { cartsMiddle5[j].SetActive(false); break; }
                    case 5: { cartsMiddle6[j].SetActive(false); break; }
                    case 6: { cartsMiddle7[j].SetActive(false); break; }
                    case 7: { cartsMiddle8[j].SetActive(false); break; }
                    case 8: { cartsMiddle9[j].SetActive(false); break; }
                }
            }
        }
    }
}
