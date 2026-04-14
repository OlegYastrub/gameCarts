using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomRules : MonoBehaviour
{
    public Text text;
    public Text text2;
    public Text text3;

    // Start is called before the first frame update
    void Start()
    {
        text.fontSize = Screen.width / 20;
        text2.fontSize = Screen.width / 20;
        text3.fontSize = Screen.width / 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
