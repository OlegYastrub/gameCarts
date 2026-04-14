using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Queues : MonoBehaviour
{
    public int countQueues = 0;

    public GameObject soundMng; 

    public Text yourtext;

    public GameObject yourStack;
    public Text yourStackText;

    public GameObject yourtextObj;
    public GameObject Bot1text;
    public GameObject Bot2text;
    public GameObject Bot3text;

    public GameObject scoresEnd;
    public GameObject cartsRight;
    public GameObject backMenu;

    public GameObject panelScore;
    public GameObject analyzButton;

    public GameObject panelStackPlayes;
    public Text scoreStackPlayes;

    public GameObject middleWin;
    public GameObject middleDraws;
    public Text middleWinText;

    public Text scoreYourTextAfter;
    public Text scoreBot1TextAfter;
    public Text scoreBot2TextAfter;
    public Text scoreBot3TextAfter;
    public Text drawsTextAfter;

    public Text scoreYourText;
    public Text scoreBot1Text;
    public Text scoreBot2Text;
    public Text scoreBot3Text;
    public Text drawsText;

    public bool gameExample = false;

    public bool wonTable = false;

    public bool meQueue = true; 
    public bool playerOneQueue = false;
    public bool playerTwoQueue = false;
    public bool playerThreeQueue = false;

    public bool canShowCart = false;
    public bool canShowCartAfterHide = false;

    bool showCartTimer = false;
    public bool showCart = false;
    public int showStack = 0;
    int showStackSlot = 1;
    int showStackSlotAll = 0;

    public GameObject playersbots; //playerinfo
    public GameObject stacksMiddle; //stack of carts on middle
    public GameObject stacksMiddleCalc; //stack of carts on middle
    public GameObject tableScore;
    public GameObject stacksWon;

    public GameObject anims;

    public GameObject[] cartsBot1 = new GameObject[9]; //images inside game
    public GameObject[] cartsBot2 = new GameObject[9]; //images inside game
    public GameObject[] cartsBot3 = new GameObject[9]; //images inside game

    public GameObject cartsMiddle; //playerinfo

    public bool cartToRightBack = false;

    public GameObject drawPanel;
    public GameObject winPanel;

    float timer = 0.0f;

    int[] winners = new int[4]; //winners

    int GetType(int idCart)
    {
        int type = -1;

        switch (idCart)
        {
            case 1: { type = 1; break; }
            case 2: { type = 1; break; }
            case 3: { type = 1; break; }
            case 4: { type = 1; break; }
            case 5: { type = 2; break; }
            case 6: { type = 2; break; }
            case 7: { type = 2; break; }
            case 8: { type = 2; break; }
            case 9: { type = 3; break; }
            case 10: { type = 3; break; }
            case 11: { type = 3; break; }
            case 12: { type = 3; break; }
            case 13: { type = 4; break; }
            case 14: { type = 4; break; }
            case 15: { type = 4; break; }
            case 16: { type = 4; break; }
            case 17: { type = 5; break; }
            case 18: { type = 5; break; }
            case 19: { type = 5; break; }
            case 20: { type = 5; break; }
            case 21: { type = 6; break; }
            case 22: { type = 6; break; }
            case 23: { type = 6; break; }
            case 24: { type = 6; break; }
            case 25: { type = 7; break; }
            case 26: { type = 7; break; }
            case 27: { type = 7; break; }
            case 28: { type = 7; break; }
            case 29: { type = 8; break; }
            case 30: { type = 8; break; }
            case 31: { type = 8; break; }
            case 32: { type = 8; break; }
            case 33: { type = 9; break; }
            case 34: { type = 9; break; }
            case 35: { type = 9; break; }
            case 36: { type = 9; break; }
        }
        return type;
    }

    public List<int> GetWinner(int showStack)
    {
        List<int> winnersAll = new List<int>();

        switch (showStack)
        {
            case 0:
                {
                    int levelWin = 0;
                    int winnerNow = 0;
                    
                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData1[i]);
                        
                        if(levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData1Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData1[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData1Owner[i]);
                        }
                    }
                    break;
                }
            case 1:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData2[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData2Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData2[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData2Owner[i]);
                        }
                    }
                    break;
                }
            case 2:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData3[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData3Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData3[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData3Owner[i]);
                        }
                    }
                    break;
                }
            case 3:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData4[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData4Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData4[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData4Owner[i]);
                        }
                    }
                    break;
                }
            case 4:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData5[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData5Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData5[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData5Owner[i]);
                        }
                    }
                    break;
                }
            case 5:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData6[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData6Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData6[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData6Owner[i]);
                        }
                    }
                    break;
                }
            case 6:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData7[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData7Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData7[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData7Owner[i]);
                        }
                    }
                    break;
                }
            case 7:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData8[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData8Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData8[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData8Owner[i]);
                        }
                    }
                    break;
                }
            case 8:
                {
                    int levelWin = 0;
                    int winnerNow = 0;

                    for (int i = 0; i < 4; i++) //first will find winners
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData9[i]);

                        if (levelWin < typeCart)
                        {
                            levelWin = typeCart;
                            winnerNow = cartsMiddle.GetComponent<CartsMiddle>().cartsData9Owner[i];
                        }
                    }
                    for (int i = 0; i < 4; i++) //second will find draws
                    {
                        int typeCart = GetType(cartsMiddle.GetComponent<CartsMiddle>().cartsData9[i]);

                        if (levelWin == typeCart)
                        {
                            levelWin = typeCart;
                            winnersAll.Add(cartsMiddle.GetComponent<CartsMiddle>().cartsData9Owner[i]);
                        }
                    }
                    break;
                }
        }
        return winnersAll;
    }

    public void StartWin()
    {
        int highScore = 0;
        int idWinner = 0;
        int countWinner = 0;

        for (int i = 0; i < 4; i++)
        {
            if (highScore < playersbots.GetComponent<PlayerBots>().playerScore[i])
            {
                highScore = playersbots.GetComponent<PlayerBots>().playerScore[i];
                idWinner = i;
            } 
        }
        for (int i = 0; i < 4; i++)
        {
            if (highScore == playersbots.GetComponent<PlayerBots>().playerScore[i])
            {
                countWinner++;
            }
        }

        if(countWinner == 1)
        {
            winPanel.SetActive(true);

            if (idWinner == 0)
            {
                //Debug.Log("HOBANA1");
                soundMng.GetComponent<SoundManager>().PlaySound(1);
                middleWinText.text = "Вы победили!";
                tableScore.GetComponent<MoveTable>().winText.text = "Вы победили!";
            }
            else
            {
                //Debug.Log("HOBANA");
                soundMng.GetComponent<SoundManager>().PlaySound(2);
                middleWinText.text = "Победил игрок №" + idWinner + "!";
                tableScore.GetComponent<MoveTable>().winText.text = "Победил игрок №" + idWinner + "!";
            }
            middleWin.SetActive(true);
        }
        else
        {
           // Debug.Log("HOBANA2");
            soundMng.GetComponent<SoundManager>().PlaySound(3);
            drawPanel.SetActive(true);
            middleDraws.SetActive(true);
            //tableScore.GetComponent<MoveTable>().winText.text = "Ничья между игроками";
        }

        yourStack.SetActive(false);

        analyzButton.SetActive(true);
        //stacksMiddleCalc.GetComponent<CartsMiddleCalc>().HideAllCarts();

        scoreYourTextAfter.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[0];
        scoreBot1TextAfter.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[1];
        scoreBot2TextAfter.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[2];
        scoreBot3TextAfter.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[3];
        drawsTextAfter.text = "" + playersbots.GetComponent<PlayerBots>().drawScore;
       
        scoresEnd.SetActive(true);
       //stacksMiddleCalc.GetComponent<CartsMiddleCalc>().HideAllScores();
        stacksMiddleCalc.GetComponent<CartsMiddleCalc>().HideAllCarts();

        cartsRight.GetComponent<CartsRight>().LoadCarts();
        cartsRight.GetComponent<CartsRight>().UpCarts();
        cartsRight.SetActive(true);
    }

    public void ResetCartsMiddleCalc()
    {
        stacksMiddleCalc.GetComponent<CartsMiddleCalc>().BackPosition();

        Debug.Log(showStackSlot + " showStackSlot and showStack " + showStack);

        for (int i = 0; i < 4; i++)
        {
            if(i == 0)
            {
                switch (showStack)
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
            else
            {
                switch (showStack)
                {
                    case 0: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData1[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData1Owner[i], false); break; }
                    case 1: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData2[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData2Owner[i], false); break; }
                    case 2: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData3[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData3Owner[i], false); break; }
                    case 3: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData4[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData4Owner[i], false); break; }
                    case 4: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData5[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData5Owner[i], false); break; }
                    case 5: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData6[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData6Owner[i], false); break; }
                    case 6: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData7[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData7Owner[i], false); break; }
                    case 7: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData8[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData8Owner[i], false); break; }
                    case 8: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(i, cartsMiddle.GetComponent<CartsMiddle>().cartsData9[i], cartsMiddle.GetComponent<CartsMiddle>().cartsData9Owner[i], false); break; }
                }
            }
        }
    }

    void Update()
    {
        if (playerOneQueue)
        {
            timer += 0.01f;

            if (timer >= 0.9f)
            {
                cartsBot1[countQueues].SetActive(false);
                //Debug.Log(countQueues + " номер стопки. Выбрано " + playersbots.GetComponent<PlayerBots>().botThreeCarts[countQueues]);
                stacksMiddle.GetComponent<CartsMiddle>().SetCart(countQueues, 1, playersbots.GetComponent<PlayerBots>().botOneCarts[countQueues], false, 1);
                playersbots.GetComponent<PlayerBots>().botOneCarts[countQueues] = -1;

                timer = 0f;
                playerOneQueue = false;

                yourtext.text = "Сейчас ходит игрок №2";
                yourtext.fontSize = 35;

                playerTwoQueue = true;
            }
        }
        else if (playerTwoQueue)
        {
            timer += 0.01f;

            if (timer >= 0.9f)
            {
                cartsBot2[countQueues].SetActive(false);
                // Debug.Log(countQueues + " номер стопки. Выбрано " + playersbots.GetComponent<PlayerBots>().botThreeCarts[countQueues]);
                stacksMiddle.GetComponent<CartsMiddle>().SetCart(countQueues, 2, playersbots.GetComponent<PlayerBots>().botTwoCarts[countQueues], false, 2);
                playersbots.GetComponent<PlayerBots>().botTwoCarts[countQueues] = -1;

                timer = 0f;
                playerTwoQueue = false;
                yourtext.text = "Сейчас ходит игрок №3";
                yourtext.fontSize = 35;

                playerThreeQueue = true;
            }
        }
        else if (playerThreeQueue)
        {
            timer += 0.01f;

            if (timer >= 0.9f)
            {
                cartsBot3[countQueues].SetActive(false);
                //  Debug.Log(countQueues + " номер стопки. Выбрано " + playersbots.GetComponent<PlayerBots>().botThreeCarts[countQueues]);
                stacksMiddle.GetComponent<CartsMiddle>().SetCart(countQueues, 3, playersbots.GetComponent<PlayerBots>().botThreeCarts[countQueues], false, 3);
                playersbots.GetComponent<PlayerBots>().botTwoCarts[countQueues] = -1;

                timer = 0f;
                playerThreeQueue = false;

                countQueues++;

                if (countQueues < 9)
                {
                    yourtext.text = "Ваш ход. Выберите карту, \nчтобы поместить ее в центр стола";
                    yourtext.fontSize = 32;

                    meQueue = true;
                }
                else
                {
                    yourtext.text = "Сейчас карты будут вскрыты\n и начнется подсчет взяток";
                    yourtext.fontSize = 35;

                    showCartTimer = true;
                    // showCart = true;
                }
            }
        }
        else if (showCartTimer)
        {
            timer += 0.01f;

            if (timer >= 1.8f)
            {
               // yourtext.text = "Вы";
                yourtext.fontSize = 75;

                anims.GetComponent<Animations>().turn = false;

                showCartTimer = false;
                showCart = true;
               // canShowCart = false;
                canShowCartAfterHide = true;


                yourtextObj.SetActive(false);
                Bot1text.SetActive(false);
                Bot2text.SetActive(false);
                Bot3text.SetActive(false);

                scoreStackPlayes.text = "1";
                panelStackPlayes.SetActive(true);

                stacksMiddle.GetComponent<CartsMiddle>().HideAllCarts();
                ResetCartsMiddleCalc();
                stacksMiddleCalc.GetComponent<CartsMiddleCalc>().ShowAllCarts();
                stacksMiddleCalc.GetComponent<CartsMiddleCalc>().ShowAllScores();
            }
           // Debug.Log("64");
        }
        else if (showCart)
        {
            if (canShowCart) //after showing of table with score
            {
              //  Debug.Log("can");
                timer += 0.01f;

               // scoreStackPlayes.text = "" + (showStack + 1);

                if (timer >= 0.2f)
                {
                    //  Debug.Log(showStackSlot + " convulsion " + cartsMiddle.GetComponent<CartsMiddle>().cartsData1[showStackSlot]);

                    if (showStackSlot <= 3)
                    {
                        switch (showStack)
                        {
                            case 0: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData1[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData1Owner[showStackSlot], true); break; }
                            case 1: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData2[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData2Owner[showStackSlot], true); break; }
                            case 2: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData3[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData3Owner[showStackSlot], true); break; }
                            case 3: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData4[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData4Owner[showStackSlot], true); break; }
                            case 4: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData5[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData5Owner[showStackSlot], true); break; }
                            case 5: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData6[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData6Owner[showStackSlot], true); break; }
                            case 6: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData7[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData7Owner[showStackSlot], true); break; }
                            case 7: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData8[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData8Owner[showStackSlot], true); break; }
                            case 8: { stacksMiddleCalc.GetComponent<CartsMiddleCalc>().SetCart(showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData9[showStackSlot], cartsMiddle.GetComponent<CartsMiddle>().cartsData9Owner[showStackSlot], true); break; }
                        }
                    }
                    /* switch (showStack)
                     {
                         case 0: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData1[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData1Owner[showStackSlot]); break; }
                         case 1: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData2[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData2Owner[showStackSlot]); break; }
                         case 2: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData3[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData3Owner[showStackSlot]); break; }
                         case 3: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData4[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData4Owner[showStackSlot]); break; }
                         case 4: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData5[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData5Owner[showStackSlot]); break; }
                         case 5: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData6[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData6Owner[showStackSlot]); break; }
                         case 6: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData7[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData7Owner[showStackSlot]); break; }
                         case 7: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData8[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData8Owner[showStackSlot]); break; }
                         case 8: { stacksMiddle.GetComponent<CartsMiddle>().SetCart(showStack, showStackSlot, cartsMiddle.GetComponent<CartsMiddle>().cartsData9[showStackSlot], true, cartsMiddle.GetComponent<CartsMiddle>().cartsData9Owner[showStackSlot]); break; }
                     }*/

                    if (showStackSlot >= 3)
                    {
                        showStackSlot = 1;

                        if (showStack >= 9)
                        {
                            showCart = false;
                            //showStack++;
                        }
                        else
                        {
                            canShowCart = false;

                            List<int> winnersAll = GetWinner(showStack);

                            for (int i = 0; i < winnersAll.Count; i++)
                            {
                                
                                //Debug.Log("Winner " + winnersAll[i]);

                                stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position = new Vector3(
                                    stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position.x,
                                    stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position.y + 50,
                                    stacksMiddleCalc.GetComponent<CartsMiddleCalc>().cartsMiddle[winnersAll[i]].transform.position.z);
                            }
                            if(winnersAll.Count == 1)
                            {
                                if(winnersAll[0] == 0)
                                {
                                    yourStackText.text = "Взятка Ваша!";
                                }
                                else
                                {
                                    yourStackText.text = "Взятка к №" + winnersAll[0] + "!";
                                }
                                playersbots.GetComponent<PlayerBots>().playerScore[winnersAll[0]] += 1;
                            }
                            else
                            {
                                yourStackText.text = "Несколько старших карт,\n взятка ни чья - <b>N</b>";
                            }
                            // textStackPlayes.text = "";

                            panelStackPlayes.SetActive(false);

                            yourStack.SetActive(true);

                            if (winnersAll.Count > 1)
                            {
                                playersbots.GetComponent<PlayerBots>().drawScore += 1;
                                soundMng.GetComponent<SoundManager>().PlaySound(3);
                            }
                            else if (winnersAll.Count == 1)
                            {
                                if (winnersAll[0] == 0)
                                    soundMng.GetComponent<SoundManager>().PlaySound(1);
                                else
                                    soundMng.GetComponent<SoundManager>().PlaySound(2);
                            }

                            scoreYourText.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[0];
                            scoreBot1Text.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[1];
                            scoreBot2Text.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[2];
                            scoreBot3Text.text = "" + playersbots.GetComponent<PlayerBots>().playerScore[3];
                            drawsText.text = "" + playersbots.GetComponent<PlayerBots>().drawScore;

                            stacksMiddleCalc.GetComponent<CartsMiddleCalc>().scorePlayersText[0].text = "" + playersbots.GetComponent<PlayerBots>().playerScore[0];
                            stacksMiddleCalc.GetComponent<CartsMiddleCalc>().scorePlayersText[1].text = "" + playersbots.GetComponent<PlayerBots>().playerScore[1];
                            stacksMiddleCalc.GetComponent<CartsMiddleCalc>().scorePlayersText[2].text = "" + playersbots.GetComponent<PlayerBots>().playerScore[2];
                            stacksMiddleCalc.GetComponent<CartsMiddleCalc>().scorePlayersText[3].text = "" + playersbots.GetComponent<PlayerBots>().playerScore[3];
                            stacksMiddleCalc.GetComponent<CartsMiddleCalc>().scoreDrawsText.text = "" + playersbots.GetComponent<PlayerBots>().drawScore;
                            

                            tableScore.GetComponent<MoveTable>().startScore = true; //showTable

                            showStack++;
                            showStackSlotAll++;
                        }
                    }
                    else
                    {
                        showStackSlot++;
                        showStackSlotAll++;
                    }
                    timer = 0f;
                }
            }
            else if (canShowCartAfterHide)
            {

                timer += 0.01f;

                if (timer >= 1.5f)
                {
                    canShowCartAfterHide = false;
                    canShowCart = true;
                    timer = 0f;
                }
            }
            //Debug.Log("23");
        }
        else if(cartToRightBack)
        {
            timer += 0.01f;

            if (timer >= 0.0f)
            {
                cartToRightBack = false;
                timer = 0f;

                int highScore = 0;
                int idWinner = 0;
                int countWinner = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (highScore < playersbots.GetComponent<PlayerBots>().playerScore[i])
                    {
                        highScore = playersbots.GetComponent<PlayerBots>().playerScore[i];
                        idWinner = i;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (highScore == playersbots.GetComponent<PlayerBots>().playerScore[i])
                    {
                        countWinner++;
                    }
                }

                if (countWinner == 1)
                {
                    if (idWinner == 0)
                    {
                        middleWinText.text = "Вы победили!";
                    }
                    else
                    {
                        middleWinText.text = "Победил игрок №" + idWinner + "!";
                    }
                    middleWin.SetActive(true);
                    gameObject.SetActive(true);
                }
                else
                {
                    middleDraws.SetActive(true);
                }

                panelScore.SetActive(true);
                cartsRight.SetActive(true);

                scoresEnd.SetActive(true);
                analyzButton.SetActive(true);

                backMenu.SetActive(false);

                stacksMiddleCalc.GetComponent<CartsMiddleCalc>().HideAllCarts();
            }
           // Debug.Log("23 23");
        }
    }
}
