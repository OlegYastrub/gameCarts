using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBots : MonoBehaviour
{
    public int[] playerCarts = new int[9];
    public int[] botOneCarts = new int[9];
    public int[] botTwoCarts = new int[9];
    public int[] botThreeCarts = new int[9];


    public int drawScore = 0;
    public int[] playerScore = new int[4];

    public GameObject playersb; //LoadCarts

    //public int[] carts = new int[36]; //all number carts
    List<int> parts = new List<int>();

    void Start()
    {
        for(int i = 0; i < 36; i++)
        {
            parts.Add(i + 1); //Add carts to list
        }

        for (int j = 0; j < 9; j++)
        {
            int randomCart = Random.Range(0, parts.Count);
            playerCarts[j] = parts[randomCart];
            // Debug.Log("Player: " + playerCarts[j]);

            parts.RemoveAt(randomCart);
        }

        for (int j = 0; j < 9; j++)
        {
            int randomCart = Random.Range(0, parts.Count);
            botOneCarts[j] = parts[randomCart];

           // Debug.Log("Bot1: " + botOneCarts[j]);

            parts.RemoveAt(randomCart);
        }

        for (int j = 0; j < 9; j++)
        {
            int randomCart = Random.Range(0, parts.Count);
            botTwoCarts[j] = parts[randomCart];

          //  Debug.Log("Bot2: " + botTwoCarts[j]);

            parts.RemoveAt(randomCart);
        }

        for (int j = 0; j < 9; j++)
        {
            int randomCart = Random.Range(0, parts.Count);
            botThreeCarts[j] = parts[randomCart];

        //    Debug.Log("Bot3: " + botThreeCarts[j]);

            parts.RemoveAt(randomCart);
        }
        /*foreach (int aPart in parts)
        {
            Console.WriteLine(aPart);
        }*/
        playersb.GetComponent<LoadPlayerCart>().LoadCarts();
      //  Debug.Log(playerCarts[0]);
    }
}
