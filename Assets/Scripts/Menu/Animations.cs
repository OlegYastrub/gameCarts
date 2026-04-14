using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animations : MonoBehaviour
{
    public Text yourtext;
    public Color newColor;

    public bool turn = true;

    float alpha = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (turn)
        {
            alpha -= 0.01f;
            yourtext.color = new Color(yourtext.color.r, yourtext.color.g, yourtext.color.b, alpha);

            if (alpha <= 0.5f)
                alpha = 1f;
        }
        else
        {
            yourtext.color = new Color(yourtext.color.r, yourtext.color.g, yourtext.color.b, 1f);
        }
    }
}
