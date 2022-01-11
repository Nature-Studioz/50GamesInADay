using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerGame : MonoBehaviour
{
    int Clicks;
    public TMPro.TextMeshProUGUI Texta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Clicks += 1;
            Texta.text = Clicks.ToString();
        }
    }
}
