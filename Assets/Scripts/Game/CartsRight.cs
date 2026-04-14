using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartsRight : MonoBehaviour
{
    public GameObject cartsMiddle; //playerinfo
    public GameObject queues; //playerinfo

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

    public void UpCarts()
    {
        for(int j = 0; j < 9; j++)
        {
            List<int> winnersAll = queues.GetComponent<Queues>().GetWinner(j);

            for (int i = 0; i < winnersAll.Count; i++)
            {
                //playersbots.GetComponent<PlayerBots>().playerScore[winnersAll[i]] += 1;
                //Debug.Log("Winner " + winnersAll[i]);
                
                switch (j)
                {
                    case 0: { cartsMiddle1[winnersAll[i]].transform.position = new Vector3(cartsMiddle1[winnersAll[i]].transform.position.x, cartsMiddle1[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle1[winnersAll[i]].transform.position.z); break; }
                    case 1: { cartsMiddle2[winnersAll[i]].transform.position = new Vector3(cartsMiddle2[winnersAll[i]].transform.position.x, cartsMiddle2[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle2[winnersAll[i]].transform.position.z); break; }
                    case 2: { cartsMiddle3[winnersAll[i]].transform.position = new Vector3(cartsMiddle3[winnersAll[i]].transform.position.x, cartsMiddle3[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle3[winnersAll[i]].transform.position.z); break; }
                    case 3: { cartsMiddle4[winnersAll[i]].transform.position = new Vector3(cartsMiddle4[winnersAll[i]].transform.position.x, cartsMiddle4[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle4[winnersAll[i]].transform.position.z); break; }
                    case 4: { cartsMiddle5[winnersAll[i]].transform.position = new Vector3(cartsMiddle5[winnersAll[i]].transform.position.x, cartsMiddle5[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle5[winnersAll[i]].transform.position.z); break; }
                    case 5: { cartsMiddle6[winnersAll[i]].transform.position = new Vector3(cartsMiddle6[winnersAll[i]].transform.position.x, cartsMiddle6[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle6[winnersAll[i]].transform.position.z); break; }
                    case 6: { cartsMiddle7[winnersAll[i]].transform.position = new Vector3(cartsMiddle7[winnersAll[i]].transform.position.x, cartsMiddle7[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle7[winnersAll[i]].transform.position.z); break; }
                    case 7: { cartsMiddle8[winnersAll[i]].transform.position = new Vector3(cartsMiddle8[winnersAll[i]].transform.position.x, cartsMiddle8[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle8[winnersAll[i]].transform.position.z); break; }
                    case 8: { cartsMiddle9[winnersAll[i]].transform.position = new Vector3(cartsMiddle9[winnersAll[i]].transform.position.x, cartsMiddle9[winnersAll[i]].transform.position.y + 10.0f, cartsMiddle9[winnersAll[i]].transform.position.z); break; }
                }

            }
        }
    }

    public void LoadCarts()
    {
        for(int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 0: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData1[j], true); break; }
                    case 1: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData2[j], true); break; }
                    case 2: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData3[j], true); break; }
                    case 3: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData4[j], true); break; }
                    case 4: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData5[j], true); break; }
                    case 5: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData6[j], true); break; }
                    case 6: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData7[j], true); break; }
                    case 7: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData8[j], true); break; }
                    case 8: { SetCart(i, j, cartsMiddle.GetComponent<CartsMiddle>().cartsData9[j], true); break; }
                }
            }
        }
    }

    public void SetCart(int countStack, int numberSlot, int typeCart, bool show) //show - side of cart
    {
        //soundMng.GetComponent<SoundManager>().PlaySound();

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
                        cartsMiddle1[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData1[numberSlot] = typeCart;
                        break;
                    }
                case 1:
                    {
                        cartsMiddle2[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData2[numberSlot] = typeCart;
                        break;
                    }
                case 2:
                    {
                        cartsMiddle3[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData3[numberSlot] = typeCart;
                        break;
                    }
                case 3:
                    {
                        cartsMiddle4[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData4[numberSlot] = typeCart;
                        break;
                    }
                case 4:
                    {
                        cartsMiddle5[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData5[numberSlot] = typeCart;
                        break;
                    }
                case 5:
                    {
                        cartsMiddle6[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData6[numberSlot] = typeCart;
                        break;
                    }
                case 6:
                    {
                        cartsMiddle7[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData7[numberSlot] = typeCart;
                        break;
                    }
                case 7:
                    {
                        cartsMiddle8[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData8[numberSlot] = typeCart;
                        break;
                    }
                case 8:
                    {
                        cartsMiddle9[numberSlot].GetComponent<Image>().sprite = cartSprite;
                        cartsData9[numberSlot] = typeCart;
                        break;
                    }
            }
        }
        else
        {
            switch (countStack)
            {
                case 0: { cartsData1[numberSlot] = typeCart; break; }
                case 1: { cartsData2[numberSlot] = typeCart; break; }
                case 2: { cartsData3[numberSlot] = typeCart; break; }
                case 3: { cartsData4[numberSlot] = typeCart; break; }
                case 4: { cartsData5[numberSlot] = typeCart; break; }
                case 5: { cartsData6[numberSlot] = typeCart; break; }
                case 6: { cartsData7[numberSlot] = typeCart; break; }
                case 7: { cartsData8[numberSlot] = typeCart; break; }
                case 8: { cartsData9[numberSlot] = typeCart; break; }
            }
        }
    }
}
