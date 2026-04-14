using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTable : MonoBehaviour
{
    public GameObject panelScore;
    public GameObject queues;

    public GameObject cartDownImg;
    public GameObject winPanel;
    public GameObject winCongrPanel;

    public Text winText;

    public bool startScore = false;
    public bool backScore = false;

    bool timerStart = false;
    float timer = 0f;
    float xPos = Screen.width / 3 + 20f;
    float startPosition = 0f;
    
    void Start()
    {
        startPosition = panelScore.transform.position.x;
    }
    
    void Update()
    {
        if (startScore)
        {
            

            xPos -= 6f;
            panelScore.transform.position = new Vector3(panelScore.transform.position.x - 6f, panelScore.transform.position.y, panelScore.transform.position.z);

           // Debug.Log(panelScore.transform.position.x);

            if (xPos <= 0)
            {
                timerStart = true;
                startScore = false;
            }
        }
        else if (backScore)
        {
            xPos += 6f;
            panelScore.transform.position = new Vector3(panelScore.transform.position.x + 6f, panelScore.transform.position.y, panelScore.transform.position.z);

            // Debug.Log(panelScore.transform.position.x);

            if (xPos >= Screen.width / 3 + 20f)
            {
                panelScore.transform.position = new Vector3(startPosition, panelScore.transform.position.y, panelScore.transform.position.z);
                // startScore = false;
                backScore = false;


                queues.GetComponent<Queues>().yourStack.SetActive(false);

                queues.GetComponent<Queues>().ResetCartsMiddleCalc();
                queues.GetComponent<Queues>().canShowCartAfterHide = true;

                queues.GetComponent<Queues>().scoreStackPlayes.text = "" + (queues.GetComponent<Queues>().showStack + 1);

                if (!(queues.GetComponent<Queues>().showStack >= 9))
                {
                    queues.GetComponent<Queues>().panelStackPlayes.SetActive(true);
                }
            }
        }
        else if (timerStart)
        {
            timer += 0.01f;

            if (timer >= 2.2f)
            {
                timerStart = false;
                timer = 0f;

                if (queues.GetComponent<Queues>().showStack >= 9)
                {
                    if (!queues.GetComponent<Queues>().wonTable)
                    {
                        queues.GetComponent<Queues>().StartWin();
                        queues.GetComponent<Queues>().wonTable = true;
                        queues.GetComponent<Queues>().showCart = false;

                        cartDownImg.SetActive(false);
                        winCongrPanel.SetActive(true);
                    }
                }
                else
                {
                    backScore = true;
                }
            }
        }
    }
}
