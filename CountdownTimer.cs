using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public GameObject textDisplay;
    public int SecondsRemain = 30;
    public bool reduceTime = false;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = SecondsRemain + " Secs";
    }

    void Update()
    {
        if (reduceTime == false && SecondsRemain > 0)
        {
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        reduceTime = true;
        yield return new WaitForSeconds(1);
        SecondsRemain -= 1;
        textDisplay.GetComponent<Text>().text = SecondsRemain + " Secs";
        reduceTime = false;
    }
}
