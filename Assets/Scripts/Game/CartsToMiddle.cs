using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CartsToMiddle : MonoBehaviour, IPointerDownHandler
{
    public GameObject cartsMiddle; 
    public GameObject stacksMiddleCalc;
    public GameObject queues;
    public GameObject panelScore;
    public GameObject cartsRight;

    public int stack = 0;
   // public int slot = 0;

    public void OnPointerDown(PointerEventData eventData)
    {
        panelScore.SetActive(false);
        queues.GetComponent<Queues>().cartToRightBack = true;
        cartsRight.SetActive(false);
        
        queues.GetComponent<Queues>().middleWin.SetActive(false);
        queues.GetComponent<Queues>().middleDraws.SetActive(false);

        stacksMiddleCalc.GetComponent<CartsMiddleCalc>().BackPosition();

        for (int i = 0; i < 4; i++)
        {
            switch (stack)
            {
                case 0: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData1[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData1Owner[i], true); break; }
                case 1: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData2[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData2Owner[i], true); break; }
                case 2: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData3[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData3Owner[i], true); break; }
                case 3: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData4[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData4Owner[i], true); break; }
                case 4: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData5[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData5Owner[i], true); break; }
                case 5: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData6[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData6Owner[i], true); break; }
                case 6: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData7[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData7Owner[i], true); break; }
                case 7: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData8[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData8Owner[i], true); break; }
                case 8: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData9[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData9Owner[i], true); break; }
            }
        }

        List<int> winnersAll = queues.GetComponent<Queues>().GetWinner(stack);

        for (int i = 0; i < winnersAll.Count; i++)
        {
            stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position = new Vector3(
                stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position.x,
                stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position.y + 50,
                stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position.z);
        }

        stacksMiddleCalc.GetComponent<CartsMiddleCalc>().ShowAllCarts();
    }
}
