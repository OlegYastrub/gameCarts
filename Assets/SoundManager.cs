using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioClip tas, winYou, winBot, draws;
    public AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        tas = Resources.Load<AudioClip>("tas");
        winYou = Resources.Load<AudioClip>("winYou");
        winBot = Resources.Load<AudioClip>("winBot");
        draws = Resources.Load<AudioClip>("draws");

        audioSrc.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySound(int type)
    {
        switch(type)
        {
            case 0:
                {
                    audioSrc.PlayOneShot(tas);
                    break;
                }
            case 1:
                {
                    audioSrc.PlayOneShot(winYou);
                    break;
                }
            case 2:
                {
                    audioSrc.PlayOneShot(winBot);
                    break;
                }
            case 3:
                {
                    audioSrc.PlayOneShot(draws);
                    break;
                }
        }
    }
}
